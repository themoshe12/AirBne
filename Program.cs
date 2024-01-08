using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var main = new AirBNE();
            main.FormClosed += new FormClosedEventHandler(FormClosed);
            main.Show();
            Application.Run();
        }

        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0)
            {
                    IFormatter formatter = new BinaryFormatter();
                    using (Stream stream = new FileStream("items.mdl", FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        foreach (Rentable item in AirBNE.items)
                            formatter.Serialize(stream, item);
                        stream.Dispose();
                    }
                    using (Stream stream = new FileStream("users.mdl", FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        foreach (User user in AirBNE.users)
                            formatter.Serialize(stream, user);
                        stream.Dispose();
                    }
                Application.ExitThread();
            }
            else
                Application.OpenForms[0].FormClosed += FormClosed;
        }
    }
}
