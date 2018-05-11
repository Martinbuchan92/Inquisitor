using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inquisitor
{
    static class Program
    {

        const String PATH = @"C:\Users\intro\Documents\Inquisitor\";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inquisitor());
        }

       public  static void Write(String writeItem, String[] toWrite)
        {
            String type = writeItem.ToUpper();
            int caseSwitch = 0;
            if (type.Equals("ABILITIES"))
            {
                caseSwitch = 0;
            }
            switch (caseSwitch)
            {
                case 0:
                    System.IO.File.WriteAllLines(PATH + writeItem+ ".txt", toWrite);
                break;

            }

        }

        public static String[] Read(String readItem)
        {
            String type = readItem.ToUpper();
            if (type.Equals("ABILITIES"))
            {
               return System.IO.File.ReadAllLines(PATH + readItem + ".txt");
            }

            return null;
        }
    }
}
