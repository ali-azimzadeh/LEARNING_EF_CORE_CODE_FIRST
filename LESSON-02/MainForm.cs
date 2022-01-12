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
			//Models.DatabaseContext databaseContext = null;

			//try
			//{

			//	databaseContext =
			//		new Models.DatabaseContext();

			////	databaseContext.Database.EnsureCreated(); 
				
			//	Models.Person person =
			//		new Models.Person
			//		{
			//			Id = 1,
			//			Age = 47,
			//			IsSupervisor = true,
			//			FullName = "Mr. Ali Azimzadeh",
			//		};

			//	databaseContext.People.Add(person);

			//	databaseContext.SaveChanges();

			//	int intNewId = person.Id;
			//}
			//catch (System.Exception ex)
			//{
			//	System.Windows.Forms.MessageBox.Show(ex.Message);
			//}
			//finally
			//{
			//	if (databaseContext != null)
			//	{
			//		databaseContext.Dispose();
			//		//databaseContext = null;
			//	}
			//}
		}

        private void HashButton_Click(object sender, EventArgs e)
        {
			//HashedPasswordTextBox.Text =
			//	Security.Hash.GetSha1(passwordTextBox.Text);

			HashedPasswordTextBox.Text =
							Security.Hash.GetMD5(passwordTextBox.Text);

			MessageBox.Show(HashedPasswordTextBox.Text.Length.ToString());

        }

        private void EncryptConnectionStringButton_Click(object sender, EventArgs e)
        {
			Security.ConnectionStringEncryption connectionStringEncryption =
				new Security.ConnectionStringEncryption();

			connectionStringEncryption
				.Encryption(app_ConfigPathName: Application.ExecutablePath);
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
			Security.ConnectionStringEncryption connectionStringEncryption =
						new Security.ConnectionStringEncryption();

			connectionStringEncryption
				.Decryption(app_ConfigPathName: Application.ExecutablePath);
		}

        private void HashFileButton_Click(object sender, EventArgs e)
        {
			HashFileTextBox.Text =
				Security.Hash.GetSha1ByPathName(filePathTextBox.Text);
        }

        private void browsButton_Click(object sender, EventArgs e)
        {
			if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
				filePathTextBox.Text =
					openFileDialog.FileName;
            }
        }
    }
}
