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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            topmenu.SuspendLayout();
            menuStrip1.SuspendLayout();
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
            bigger.Size = new Size(113, 22);
            bigger.Text = "Bigger";
            bigger.Click += bigger_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(110, 6);
            // 
            // smaller
            // 
            smaller.Name = "smaller";
            smaller.Size = new Size(113, 22);
            smaller.Text = "Smaller";
            smaller.Click += smaller_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(110, 6);
            // 
            // reset
            // 
            reset.Name = "reset";
            reset.Size = new Size(113, 22);
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
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem4, toolStripMenuItem5 });
            menuStrip1.Location = new Point(0, 617);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Padding = new Padding(10, 10, 10, 0);
            toolStripMenuItem1.Size = new Size(56, 29);
            toolStripMenuItem1.Text = "Back";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Padding = new Padding(10, 0, 10, 0);
            toolStripMenuItem4.Size = new Size(74, 29);
            toolStripMenuItem4.Text = "Forward";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Padding = new Padding(10, 0, 10, 0);
            toolStripMenuItem5.Size = new Size(59, 29);
            toolStripMenuItem5.Text = "Tools";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(topmenu);
            Controls.Add(menuStrip1);
            MainMenuStrip = topmenu;
            Name = "Form1";
            Text = "Flow Viewer";
            topmenu.ResumeLayout(false);
            topmenu.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
    }
}
