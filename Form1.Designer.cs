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
            DocForward = new Button();
            DocBackward = new Button();
            DrawingPen = new Button();
            Highlighter = new Button();
            topmenu = new MenuStrip();
            filemenu = new ToolStripMenuItem();
            toolOpen = new ToolStripMenuItem();
            fileseperate = new ToolStripSeparator();
            toolSave = new ToolStripMenuItem();
            viewmenu = new ToolStripMenuItem();
            bigger = new ToolStripMenuItem();
            aboutmenu = new ToolStripMenuItem();
            topmenu.SuspendLayout();
            SuspendLayout();
            // 
            // DocForward
            // 
            DocForward.Location = new Point(905, 502);
            DocForward.Name = "DocForward";
            DocForward.Size = new Size(60, 45);
            DocForward.TabIndex = 0;
            DocForward.Text = ">";
            DocForward.UseVisualStyleBackColor = true;
            // 
            // DocBackward
            // 
            DocBackward.Location = new Point(12, 502);
            DocBackward.Name = "DocBackward";
            DocBackward.Size = new Size(60, 45);
            DocBackward.TabIndex = 0;
            DocBackward.Text = "<";
            DocBackward.UseVisualStyleBackColor = true;
            // 
            // DrawingPen
            // 
            DrawingPen.Location = new Point(78, 507);
            DrawingPen.Name = "DrawingPen";
            DrawingPen.Size = new Size(60, 35);
            DrawingPen.TabIndex = 1;
            DrawingPen.Text = "Pen";
            // 
            // Highlighter
            // 
            Highlighter.Location = new Point(824, 507);
            Highlighter.Name = "Highlighter";
            Highlighter.Size = new Size(75, 35);
            Highlighter.TabIndex = 2;
            Highlighter.Text = "Highlight";
            // 
            // topmenu
            // 
            topmenu.AllowDrop = true;
            topmenu.Items.AddRange(new ToolStripItem[] { filemenu, viewmenu, aboutmenu });
            topmenu.Location = new Point(0, 0);
            topmenu.Name = "topmenu";
            topmenu.Size = new Size(977, 24);
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
            toolOpen.Size = new Size(180, 22);
            toolOpen.Text = "Open";
            // 
            // fileseperate
            // 
            fileseperate.Name = "fileseperate";
            fileseperate.Size = new Size(177, 6);
            // 
            // toolSave
            // 
            toolSave.Name = "toolSave";
            toolSave.Size = new Size(180, 22);
            toolSave.Text = "Save";
            toolSave.Click += toolSave_Click;
            // 
            // viewmenu
            // 
            viewmenu.DropDownItems.AddRange(new ToolStripItem[] { bigger });
            viewmenu.Name = "viewmenu";
            viewmenu.Size = new Size(44, 20);
            viewmenu.Text = "View";
            // 
            // fullscreen
            // 
            bigger.Name = "Bigger";
            bigger.Size = new Size(180, 22);
            bigger.Text = "Big";
            bigger.Click += bigger_Click;
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
            ClientSize = new Size(977, 569);
            Controls.Add(DocForward);
            Controls.Add(DocBackward);
            Controls.Add(DrawingPen);
            Controls.Add(Highlighter);
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

        private Button DocForward;
        private Button DocBackward;
        private Button DrawingPen;
        private Button Highlighter;
        private MenuStrip topmenu;
        private ToolStripMenuItem filemenu;
        private ToolStripMenuItem viewmenu;
        private ToolStripMenuItem aboutmenu;
        private ToolStripMenuItem toolOpen;
        private ToolStripMenuItem toolSave;
        private ToolStripSeparator fileseperate;
        private ToolStripMenuItem bigger;
    }
}
