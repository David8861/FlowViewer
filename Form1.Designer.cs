using System.Drawing.Configuration;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace FlowViewer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            
            topmenu = new MenuStrip();
            filemenu = new ToolStripMenuItem();
            toolOpen = new ToolStripMenuItem();
            fileseperate = new ToolStripSeparator();
            toolSave = new ToolStripMenuItem();
            viewmenu = new ToolStripMenuItem();
            bigger = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            smaller = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            reset = new ToolStripMenuItem();
            aboutmenu = new ToolStripMenuItem();
            topmenu.SuspendLayout();
            SuspendLayout();
            

            // 
            // topmenu
            // 
            topmenu.AllowDrop = true;
            topmenu.Items.AddRange(new ToolStripItem[] { filemenu, viewmenu, aboutmenu });
            topmenu.Location = new Point(0, 0);
            topmenu.Name = "topmenu";
            topmenu.Size = new Size(1000, 24);
            topmenu.TabIndex = 3;
            topmenu.Text = "Menu";
            // 
            // filemenu
            // 
            filemenu.DropDownItems.AddRange(new ToolStripItem[] { toolOpen, fileseperate, toolSave });
            filemenu.Name = "filemenu";
            filemenu.Size = new Size(37, 20);
            filemenu.Text = "File";
            // 
            // toolOpen
            // 
            toolOpen.Name = "toolOpen";
            toolOpen.Size = new Size(103, 22);
            toolOpen.Text = "Open";
            toolOpen.Click += toolOpen_Click;
            // 
            // fileseperate
            // 
            fileseperate.Name = "fileseperate";
            fileseperate.Size = new Size(100, 6);
            // 
            // toolSave
            // 
            toolSave.Name = "toolSave";
            toolSave.Size = new Size(103, 22);
            toolSave.Text = "Save";
            toolSave.Click += toolSave_Click;
            // 
            // viewmenu
            // 
            viewmenu.DropDownItems.AddRange(new ToolStripItem[] { bigger, toolStripSeparator1, smaller, toolStripSeparator2, reset });
            viewmenu.Name = "viewmenu";
            viewmenu.Size = new Size(44, 20);
            viewmenu.Text = "View";
            // 
            // bigger
            // 
            bigger.Name = "bigger";
            bigger.Size = new Size(103, 22);
            bigger.Text = "Bigger";
            bigger.Click += bigger_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(100, 6);
            // 
            // smaller
            // 
            smaller.Name = "smaller";
            smaller.Size = new Size(103, 22);
            smaller.Text = "Smaller";
            smaller.Click += smaller_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(100, 6);
            // 
            // reset
            // 
            reset.Name = "reset";
            reset.Size = new Size(103, 22);
            reset.Text = "Reset";
            reset.Click += reset_Click;
            // 
            // aboutmenu
            // 
            aboutmenu.Name = "aboutmenu";
            aboutmenu.Size = new Size(52, 20);
            aboutmenu.Text = "About";
            aboutmenu.Click += aboutmenu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(topmenu);
            MainMenuStrip = topmenu;
            Name = "Form1";
            Text = "Flow Viewer";
            topmenu.ResumeLayout(false);
            topmenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        
        private MenuStrip topmenu;
        private ToolStripMenuItem filemenu;
        private ToolStripMenuItem viewmenu;
        private ToolStripMenuItem aboutmenu;
        private ToolStripMenuItem toolOpen;
        private ToolStripMenuItem toolSave;
        private ToolStripSeparator fileseperate;
        private ToolStripMenuItem bigger;
        private ToolStripMenuItem smaller;
        private ToolStripMenuItem reset;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
    }
}
