using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON_02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
			Models.DatabaseContext databaseContext = null;

			try
			{

				databaseContext =
					new Models.DatabaseContext();

			//	databaseContext.Database.EnsureCreated(); 
				
				Models.Person person =
					new Models.Person
					{
						Id = 1,
						Age = 47,
						IsSupervisor = true,
						FullName = "Mr. Ali Azimzadeh",
					};

				databaseContext.People.Add(person);

				databaseContext.SaveChanges();

				int intNewId = person.Id;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}
	
    }
}
