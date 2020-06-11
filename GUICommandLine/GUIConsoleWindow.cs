using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICommandLine
{
    public partial class GUIConsoleWindow : Form
    {
        public GUIConsoleWindow()
        {
            InitializeComponent();

            TxtInput.KeyDown += TxtInput_KeyDown;

            SetWindowColors(Color.LightGray, Color.FromArgb(20, 20, 20));
            SetTextAreaColors(Color.LightGray, Color.Black);
            SetTextAreaFontSize(12);
            ShowStatusBar(false);
            ShowMenuBar(false);
            ShowScrollBar(false);
            ClearInput();
            ClearOutput();
        }

        private void TxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                string input = TxtInput.Text.Trim();
                ClearInput();
                Submit(input);
            }
        }

        public void SetTitle(string title)
        {
            Text = title;
        }

        public void SetTextAreaColors(Color foreground, Color background)
        {
            TxtInput.ForeColor = foreground;
            TxtInput.BackColor = background;
            TxtOutput.ForeColor = foreground;
            TxtOutput.BackColor = background;
        }

        public void SetWindowColors(Color foreground, Color background)
        {
            ForeColor = foreground;
            BackColor = background;
        }

        public void SetTextAreaFont(Font font)
        {
            TxtInput.Font = font;
            TxtOutput.Font = font;
        }

        public void SetTextAreaFontSize(int size)
        {
            TxtInput.Font = new Font(TxtInput.Font.FontFamily, size);
            TxtOutput.Font = new Font(TxtOutput.Font.FontFamily, size);
        }

        public void ShowStatusBar(bool show)
        {
            if (show)
                StatusBar.Show();
            else
                StatusBar.Hide();
        }

        public void ShowMenuBar(bool show)
        {
            if (show)
                MenuBar.Show();
            else
                MenuBar.Hide();
        }

        public void SetBorderSize(int size)
        {
            RootPanel.Padding = new Padding(size);
        }

        public void ShowScrollBar(bool show)
        {
            TxtOutput.ScrollBars = show ? ScrollBars.Vertical : ScrollBars.None;
        }

        public void SetWordWrap(bool wrap)
        {
            TxtOutput.WordWrap = wrap;
        }

        public void ClearOutput()
        {
            TxtOutput.Text = "";
        }

        public void ClearInput()
        {
            TxtInput.Text = "";
        }

        public void Print(string text)
        {
            TxtOutput.AppendText(text);
        }

        public void Println(string text)
        {
            Print(text + Environment.NewLine);
        }

        public virtual void Submit(string text)
        {
            // override in subclass
            Println("> " + text);
        }
    }
}
