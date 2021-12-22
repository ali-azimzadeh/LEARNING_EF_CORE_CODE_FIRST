using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON_02
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

			// **************************************************

			// **************************************************
			//			MainForm startupForm = new MainForm();
			Form1 startupForm = new Form1();

			System.Windows.Forms.Application.Run(startupForm);

			if (startupForm != null)
			{
				if (startupForm.IsDisposed == false)
				{
					startupForm.Dispose();
				}

				//startupForm = null;
			}
			// **************************************************         
		}
	}
}
