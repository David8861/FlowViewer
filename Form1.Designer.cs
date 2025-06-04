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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            topmenu = new MenuStrip();
            filemenu = new ToolStripMenuItem();
            toolOpen = new ToolStripMenuItem();
            toolExit = new ToolStripMenuItem();
            fileseperate = new ToolStripSeparator();
            toolSave = new ToolStripMenuItem();
            viewmenu = new ToolStripMenuItem();
            bigger = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            smaller = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            reset = new ToolStripMenuItem();
            aboutmenu = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            menuStrip1 = new MenuStrip();
            toolsmenu = new ToolStripMenuItem();
            highlight = new ToolStripMenuItem();
            drawpen = new ToolStripMenuItem();
            forwardfunction = new ToolStripMenuItem();
            backwardfunction = new ToolStripMenuItem();
            fileseperate2 = new ToolStripSeparator();
            
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
            this.topmenu.BackColor = Color.SkyBlue;
            // 
            // filemenu
            // 
            filemenu.DropDownItems.AddRange(new ToolStripItem[] { toolOpen, fileseperate, toolSave, fileseperate2, toolExit });
            filemenu.Name = "filemenu";
            filemenu.Size = new Size(37, 20);
            filemenu.Text = "File";

            fileseperate2.Name = "fileseperate2";
            fileseperate2.Size = new Size(100, 6);

            toolExit.Name = "tool Exit";
            toolExit.Size = new Size();
            toolExit.Text = "Exit";
            toolExit.Click += toolExit_Click;

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
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(131, 6);
            // 
            // Dock Menu
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolsmenu, forwardfunction, backwardfunction });
            menuStrip1.Location = new Point(0, 597);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 53);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "Dock";
            
            // 
            // Tools Menu
            // 
            toolsmenu.DropDownItems.AddRange(new ToolStripItem[] { highlight, toolStripSeparator3, drawpen });
            toolsmenu.Name = "toolsmenu";
            toolsmenu.Padding = new Padding(0, 15, 0, 15);
            toolsmenu.Size = new Size(39, 49);
            toolsmenu.Text = "Tools";
            toolsmenu.AutoSize = true;
            // 
            // highlight
            // 
            highlight.Name = "highlight";
            highlight.Size = new Size(134, 22);
            highlight.Text = "Highlighter";
            // 
            // drawpen
            // 
            drawpen.Name = "drawpen";
            drawpen.Size = new Size(134, 22);
            drawpen.Text = "Pen";
            // 
            // forwardfunction
            // 
            forwardfunction.Alignment = ToolStripItemAlignment.Right;
            forwardfunction.Name = "forwardfunction";
            forwardfunction.Padding = new Padding(10, 0, 10, 0);
            forwardfunction.Size = new Size(74, 49);
            forwardfunction.Text = "Forward";
            // 
            // backwardfunction
            // 
            backwardfunction.Alignment = ToolStripItemAlignment.Right;
            backwardfunction.BackgroundImageLayout = ImageLayout.None;
            backwardfunction.Name = "backwardfunction";
            backwardfunction.Padding = new Padding(10, 0, 10, 0);
            backwardfunction.Size = new Size(56, 49);
            backwardfunction.Text = "Back";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(topmenu);
            Controls.Add(menuStrip1);
            
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private ToolStripMenuItem toolExit;
        private ToolStripMenuItem toolOpen;
        private ToolStripMenuItem toolSave;
        private ToolStripSeparator fileseperate;
        private ToolStripSeparator fileseperate2;
        private ToolStripMenuItem bigger;
        private ToolStripMenuItem smaller;
        private ToolStripMenuItem reset;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolsmenu;
        private ToolStripMenuItem highlight;
        private ToolStripMenuItem drawpen;
        private ToolStripMenuItem forwardfunction;
        private ToolStripMenuItem backwardfunction;
    }
}
