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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            // Enables the use of resources
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            
            // Create a toolbar menu
            topmenu = new MenuStrip();

            // Assign new toolstrip functions for the toolbar
            filemenu = new ToolStripMenuItem(); toolOpen = new ToolStripMenuItem(); toolSave = new ToolStripMenuItem();
            toolExit = new ToolStripMenuItem(); viewmenu = new ToolStripMenuItem(); bigger = new ToolStripMenuItem();
            smaller = new ToolStripMenuItem(); reset = new ToolStripMenuItem(); aboutmenu = new ToolStripMenuItem();
            toolsmenu = new ToolStripMenuItem();

            // Seperates toolstrip functions from eachother
            fileseperate = new ToolStripSeparator(); fileseperate2 = new ToolStripSeparator(); toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator(); toolStripSeparator3 = new ToolStripSeparator();
            

            // Create menu for Tools
            menuStrip1 = new MenuStrip();

            // Create tool functions and suspend layout for program use
            drawpen = new ToolStripMenuItem();
            highlight = new ToolStripMenuItem();
            topmenu.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            

            // Define menu attributes
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
           
            // Assign file drop down menu attributes for file functions
            filemenu.BackColor = Color.Transparent;
            filemenu.DropDownItems.AddRange(new ToolStripItem[] { toolOpen, fileseperate, toolSave, fileseperate2, toolExit });
            filemenu.Font = new Font("Georgia", 9.75F);
            filemenu.ForeColor = Color.Black;
            filemenu.ImageTransparentColor = SystemColors.ActiveBorder;
            filemenu.Name = "filemenu";
            filemenu.Size = new Size(42, 20);
            filemenu.Text = "File";
            filemenu.Click += filemenu_Click;
            
            // Define Open function attributes and mouse click reference
            toolOpen.Image = (Image)resources.GetObject("toolOpen.Image");
            toolOpen.Name = "toolOpen";
            toolOpen.Size = new Size(180, 22);
            toolOpen.Text = "Open";
            toolOpen.Click += toolOpen_Click;
            
            // Seperate menu items
            fileseperate.Name = "fileseperate";
            fileseperate.Size = new Size(177, 6);
            
            // Define Save function attributes and mouse click reference
            toolSave.Image = (Image)resources.GetObject("toolSave.Image");
            toolSave.Name = "toolSave";
            toolSave.Size = new Size(180, 22);
            toolSave.Text = "Save";
            toolSave.Click += toolSave_Click;
            
            // Seperate menu items
            fileseperate2.Name = "fileseperate2";
            fileseperate2.Size = new Size(177, 6);
            
            // Define program exit item and exit on click
            toolExit.Image = (Image)resources.GetObject("toolExit.Image");
            toolExit.Name = "toolExit";
            toolExit.Size = new Size(180, 22);
            toolExit.Text = "Exit";
            toolExit.Click += toolExit_Click;
           
            // Define View menu attributes
            viewmenu.BackColor = Color.White;
            viewmenu.DropDownItems.AddRange(new ToolStripItem[] { bigger, toolStripSeparator1, smaller, toolStripSeparator2, reset });
            viewmenu.Font = new Font("Georgia", 9.75F);
            viewmenu.Name = "viewmenu";
            viewmenu.Size = new Size(50, 20);
            viewmenu.Text = "View";
            
            // Define enlarge menu 
            bigger.Image = (Image)resources.GetObject("bigger.Image");
            bigger.Name = "bigger";
            bigger.Size = new Size(180, 22);
            bigger.Text = "Bigger";
            bigger.Click += bigger_Click;
            
            // Seperate menu items
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            
            // Define shrink menu 
            smaller.Image = (Image)resources.GetObject("smaller.Image");
            smaller.Name = "smaller";
            smaller.Size = new Size(180, 22);
            smaller.Text = "Smaller";
            smaller.Click += smaller_Click;
            
            // Seperate menu items
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            
            // Defines reset back to original window size
            reset.Name = "reset";
            reset.Size = new Size(180, 22);
            reset.Text = "Reset";
            reset.Click += reset_Click;
            
            // Define about menu attributes
            aboutmenu.Alignment = ToolStripItemAlignment.Right;
            aboutmenu.Font = new Font("Georgia", 9.75F);
            aboutmenu.ForeColor = Color.Black;
            aboutmenu.Name = "aboutmenu";
            aboutmenu.Size = new Size(58, 20);
            aboutmenu.Text = "About";
            aboutmenu.Click += aboutmenu_Click;
            
            // Seperate menu items
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(141, 6);
            
            // Creates and defines toolbar dock
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolsmenu });
            menuStrip1.Location = new Point(0, 590);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5);
            menuStrip1.Size = new Size(1000, 60);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "Dock";
            
            // Create and assign tools menu attributes
            toolsmenu.DropDownItems.AddRange(new ToolStripItem[] { drawpen, toolStripSeparator3, highlight });
            toolsmenu.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolsmenu.Name = "toolsmenu";
            toolsmenu.Padding = new Padding(0, 15, 0, 15);
            toolsmenu.Size = new Size(45, 50);
            toolsmenu.Text = "Tools";
            
            // Assign pen tool attributes
            drawpen.Image = (Image)resources.GetObject("drawpen.Image");
            drawpen.Name = "drawpen";
            drawpen.Size = new Size(144, 22);
            drawpen.Text = "Pen";
            drawpen.Click += drawpen_Click;
            
            // Assign highlighter tool attributes
            highlight.Image = (Image)resources.GetObject("highlight.Image");
            highlight.Name = "highlight";
            highlight.Size = new Size(144, 22);
            highlight.Text = "Highlighter";
            highlight.Click += highlight_Click;
            
            // Assign attributes to Flow Viewer and set the tool and menu bars visible 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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

        // Create menu, item and seperator classes for Flow Viewer
        private MenuStrip topmenu, menuStrip1;

        private ToolStripMenuItem filemenu, viewmenu, aboutmenu, toolOpen, toolSave, toolExit, bigger, smaller, reset, toolsmenu, drawpen, highlight;
        
        private ToolStripSeparator fileseperate, fileseperate2, toolStripSeparator1, toolStripSeparator2, toolStripSeparator3;
      
    }
}
