using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LESSON_01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var configurationBuilder =
                    new Microsoft.Extensions.Configuration.ConfigurationBuilder()
                 .SetBasePath(basePath: System.IO.Directory.GetCurrentDirectory())
                 .AddJsonFile(path: "appsettings.json", optional: true, reloadOnChange: true)
                 .Build()
                 ;

            Settings.ConnectionStrings connectionStrings =
                            new Settings.ConnectionStrings();

            configurationBuilder
                .GetSection(key: "ConnectionStrings")
                .Bind(instance: connectionStrings)
                ;

            Models.DatabaseContext databaseContext = 
                new Models.DatabaseContext(connectionString:connectionStrings.MyConnectionString);

            try
            {
                databaseContext.Database.EnsureCreated();
               // databaseContext.Database.Migrate();

                var person = new Models.Person()
                {
                    Age = 30,
                    FullName = "Ali Azimzadeh",
                    Id = 100,
                    IsSupervisor = true
                };

                databaseContext
                    .People
                    .Add(entity: person)
                    ;

                //اطلاعات را در دیتابیس ذخیره می کنیم
                databaseContext
                    .SaveChanges()
                    ;

                //اطلاعات را از دیتابیس می خوانیم
                //var data = databaseContext
                //    .People
                //    .ToList()
                //    ;

                //dataGridViewPerson
                //    .DataSource = data;
            }
            catch (Exception ex)
            {
                //پیغام مناسب به کاربر نمایش می دهیم
                //خطا را لاگ می کنیم
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
        }
    }
}
