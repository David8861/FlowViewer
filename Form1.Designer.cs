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
            fileseperate = new ToolStripSeparator();
            toolSave = new ToolStripMenuItem();
            fileseperate2 = new ToolStripSeparator();
            toolExit = new ToolStripMenuItem();
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
            drawpen = new ToolStripMenuItem();
            highlight = new ToolStripMenuItem();
            topmenu.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // topmenu
            // 
            topmenu.AllowDrop = true;
            topmenu.BackgroundImage = (Image)resources.GetObject("topmenu.BackgroundImage");
            topmenu.BackgroundImageLayout = ImageLayout.Stretch;
            topmenu.Items.AddRange(new ToolStripItem[] { filemenu, viewmenu, aboutmenu });
            topmenu.Location = new Point(0, 0);
            topmenu.Name = "topmenu";
            topmenu.Padding = new Padding(10);
            topmenu.Size = new Size(1000, 40);
            topmenu.TabIndex = 3;
            topmenu.Text = "Menu";
            // 
            // filemenu
            // 
            filemenu.DropDownItems.AddRange(new ToolStripItem[] { toolOpen, fileseperate, toolSave, fileseperate2, toolExit });
            filemenu.Font = new Font("Georgia", 9.75F);
            filemenu.ForeColor = Color.Black;
            filemenu.ImageTransparentColor = SystemColors.ActiveBorder;
            filemenu.Name = "filemenu";
            filemenu.Size = new Size(42, 20);
            filemenu.Text = "File";
            filemenu.Click += filemenu_Click;
            // 
            // toolOpen
            // 
            toolOpen.Image = (Image)resources.GetObject("toolOpen.Image");
            toolOpen.Name = "toolOpen";
            toolOpen.Size = new Size(180, 22);
            toolOpen.Text = "Open";
            toolOpen.Click += toolOpen_Click;
            toolOpen.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            // 
            // fileseperate
            // 
            fileseperate.Name = "fileseperate";
            fileseperate.Size = new Size(177, 6);
            // 
            // toolSave
            // 
            toolSave.Image = (Image)resources.GetObject("toolSave.Image");
            toolSave.Name = "toolSave";
            toolSave.Size = new Size(180, 22);
            toolSave.Text = "Save";
            toolSave.Click += toolSave_Click;
            toolSave.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            // 
            // fileseperate2
            // 
            fileseperate2.Name = "fileseperate2";
            fileseperate2.Size = new Size(177, 6);
            // 
            // toolExit
            // 
            toolExit.Image = (Image)resources.GetObject("toolExit.Image");
            toolExit.Name = "toolExit";
            toolExit.Size = new Size(180, 22);
            toolExit.Text = "Exit";
            toolExit.Click += toolExit_Click;
            toolExit.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            // 
            // viewmenu
            // 
            viewmenu.DropDownItems.AddRange(new ToolStripItem[] { bigger, toolStripSeparator1, smaller, toolStripSeparator2, reset });
            viewmenu.Font = new Font("Georgia", 9.75F);
            viewmenu.ForeColor = Color.Black;
            viewmenu.Name = "viewmenu";
            viewmenu.Size = new Size(50, 20);
            viewmenu.Text = "View";
            // 
            // bigger
            // 
            bigger.Image = (Image)resources.GetObject("bigger.Image");
            bigger.Name = "bigger";
            bigger.Size = new Size(121, 22);
            bigger.Text = "Bigger";
            bigger.Click += bigger_Click;
            bigger.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(118, 6);
            // 
            // smaller
            // 
            smaller.Image = (Image)resources.GetObject("smaller.Image");
            smaller.Name = "smaller";
            smaller.Size = new Size(121, 22);
            smaller.Text = "Smaller";
            smaller.Click += smaller_Click;
            smaller.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(118, 6);
            // 
            // reset
            // 
            reset.Name = "reset";
            reset.Size = new Size(121, 22);
            reset.Text = "Reset";
            reset.Click += reset_Click;
            // 
            // aboutmenu
            // 
            aboutmenu.Alignment = ToolStripItemAlignment.Right;
            aboutmenu.Font = new Font("Georgia", 9.75F);
            aboutmenu.ForeColor = Color.Black;
            aboutmenu.Name = "aboutmenu";
            aboutmenu.Size = new Size(58, 20);
            aboutmenu.Text = "About";
            aboutmenu.Click += aboutmenu_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(141, 6);
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolsmenu });
            menuStrip1.Location = new Point(0, 590);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5);
            menuStrip1.Size = new Size(1000, 60);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "Dock";
            // 
            // toolsmenu
            // 
            toolsmenu.DropDownItems.AddRange(new ToolStripItem[] { drawpen, toolStripSeparator3, highlight });
            toolsmenu.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolsmenu.Name = "toolsmenu";
            toolsmenu.Padding = new Padding(0, 15, 0, 15);
            toolsmenu.Size = new Size(45, 50);
            toolsmenu.Text = "Tools";
            // 
            // drawpen
            // 
            drawpen.Image = (Image)resources.GetObject("drawpen.Image");
            drawpen.Name = "drawpen";
            drawpen.Size = new Size(144, 22);
            drawpen.Text = "Pen";
            drawpen.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            // 
            // highlight
            // 
            highlight.Image = (Image)resources.GetObject("highlight.Image");
            highlight.Name = "highlight";
            highlight.Size = new Size(144, 22);
            highlight.Text = "Highlighter";
            highlight.ImageScaling = ToolStripItemImageScaling.SizeToFit;
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
        
    }
}
