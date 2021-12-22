using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace LESSON_01
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var configurationBuilder =
            //       new Microsoft.Extensions.Configuration.ConfigurationBuilder()
            //    .SetBasePath(basePath: System.IO.Directory.GetCurrentDirectory())
            //    .AddJsonFile(path: "appsettings.json", optional: true, reloadOnChange: true)
            //    .Build()
            //    ;

            //Settings.ApplicationSettings applicationSettings =
            //                new Settings.ApplicationSettings();

            //configurationBuilder
            //    .GetSection(key: "Settings")
            //    .Bind(instance: applicationSettings)
            //    ;

            //StringBuilder result = new StringBuilder();
            //result
            //    .Append($"Age:{applicationSettings.Age}")
            //    .AppendLine()
            //    .Append($"FullName:{applicationSettings.FullName}")
            //    .AppendLine()
            //    .Append($"Salary:{applicationSettings.Salary}")
            //    .AppendLine()
            //    .Append($"IsTeacher:{applicationSettings.IsTeacher}")
            //    .AppendLine()
            //    .Append($"CompanyName:{applicationSettings.Company.CompanyName}")
            //    .AppendLine()
            //    .Append($"EmployeeCount:{applicationSettings.Company.EmployeeCount}")
            //    .AppendLine()
            //    .Append("Courses:")
            //    .AppendLine();

            //foreach (string item in applicationSettings.courses)
            //{
            //    result.Append(item)
            //        .Append("-");
            //}

            //MessageBox.Show(result.ToString());


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
