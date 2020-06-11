namespace GUICommandLine
{
    partial class GUIConsoleWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIConsoleWindow));
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.RootPanel = new System.Windows.Forms.Panel();
            this.TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.InputPanel.SuspendLayout();
            this.RootPanel.SuspendLayout();
            this.TablePanel.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(489, 24);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 316);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(489, 22);
            this.StatusBar.TabIndex = 1;
            this.StatusBar.Text = "statusStrip1";
            // 
            // InputPanel
            // 
            this.InputPanel.AutoSize = true;
            this.InputPanel.Controls.Add(this.TxtInput);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputPanel.Location = new System.Drawing.Point(3, 243);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(463, 26);
            this.InputPanel.TabIndex = 1;
            // 
            // TxtInput
            // 
            this.TxtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInput.Location = new System.Drawing.Point(0, 0);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(463, 26);
            this.TxtInput.TabIndex = 0;
            this.TxtInput.Text = "Input area";
            // 
            // RootPanel
            // 
            this.RootPanel.Controls.Add(this.TablePanel);
            this.RootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RootPanel.Location = new System.Drawing.Point(0, 24);
            this.RootPanel.Name = "RootPanel";
            this.RootPanel.Padding = new System.Windows.Forms.Padding(10);
            this.RootPanel.Size = new System.Drawing.Size(489, 292);
            this.RootPanel.TabIndex = 2;
            // 
            // TablePanel
            // 
            this.TablePanel.ColumnCount = 1;
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel.Controls.Add(this.InputPanel, 0, 1);
            this.TablePanel.Controls.Add(this.OutputPanel, 0, 0);
            this.TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanel.Location = new System.Drawing.Point(10, 10);
            this.TablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.RowCount = 2;
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TablePanel.Size = new System.Drawing.Size(469, 272);
            this.TablePanel.TabIndex = 0;
            // 
            // OutputPanel
            // 
            this.OutputPanel.Controls.Add(this.TxtOutput);
            this.OutputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputPanel.Location = new System.Drawing.Point(3, 3);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(463, 234);
            this.OutputPanel.TabIndex = 0;
            // 
            // TxtOutput
            // 
            this.TxtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOutput.Location = new System.Drawing.Point(0, 0);
            this.TxtOutput.MaxLength = 100000;
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.ReadOnly = true;
            this.TxtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtOutput.Size = new System.Drawing.Size(463, 234);
            this.TxtOutput.TabIndex = 1;
            this.TxtOutput.TabStop = false;
            this.TxtOutput.Text = "Output area";
            // 
            // GUIConsoleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 338);
            this.Controls.Add(this.RootPanel);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.Name = "GUIConsoleWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.RootPanel.ResumeLayout(false);
            this.TablePanel.ResumeLayout(false);
            this.TablePanel.PerformLayout();
            this.OutputPanel.ResumeLayout(false);
            this.OutputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Panel RootPanel;
        private System.Windows.Forms.TableLayoutPanel TablePanel;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.TextBox TxtOutput;
    }
}

