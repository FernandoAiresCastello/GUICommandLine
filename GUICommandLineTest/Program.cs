using GUICommandLine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICommandLineTest
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConsoleWindow window = new ConsoleWindow();
            //window.SetTextAreaColors(Color.Cyan, Color.DarkBlue);
            //window.SetWindowColors(Color.Yellow, Color.Magenta);
            //window.SetTextAreaFont(new Font("Segoe UI", 14));
            //window.SetBorderSize(10);
            Application.Run(window);
        }
    }
}
