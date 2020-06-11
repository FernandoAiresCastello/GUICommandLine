using GUICommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICommandLineTest
{
    public class ConsoleWindow : GUIConsoleWindow
    {
        public override void Submit(string text)
        {
            base.Submit(text);
        }
    }
}
