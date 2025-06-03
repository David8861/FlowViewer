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
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolOpen = new ToolStripMenuItem();
            fileseperate = new ToolStripSeparator();
            toolSave = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            About = new ToolStripMenuItem();
            topmenu.SuspendLayout();
            SuspendLayout();
            // 
            // DocForward
            // 
            DocForward.Location = new Point(845, 502);
            DocForward.Name = "DocForward";
            DocForward.Size = new Size(125, 55);
            DocForward.TabIndex = 0;
            DocForward.Text = "Forward";
            DocForward.UseVisualStyleBackColor = true;
            // 
            // DocBackward
            // 
            DocBackward.Location = new Point(12, 502);
            DocBackward.Name = "DocBackward";
            DocBackward.Size = new Size(125, 55);
            DocBackward.TabIndex = 0;
            DocBackward.Text = "Backward";
            DocBackward.UseVisualStyleBackColor = true;
            // 
            // DrawingPen
            // 
            DrawingPen.Location = new Point(143, 512);
            DrawingPen.Name = "DrawingPen";
            DrawingPen.Size = new Size(60, 35);
            DrawingPen.TabIndex = 1;
            DrawingPen.Text = "Pen";
            // 
            // Highlighter
            // 
            Highlighter.Location = new Point(764, 512);
            Highlighter.Name = "Highlighter";
            Highlighter.Size = new Size(75, 35);
            Highlighter.TabIndex = 2;
            Highlighter.Text = "Highlight";
            // 
            // topmenu
            // 
            topmenu.AllowDrop = true;
            topmenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, About });
            topmenu.Location = new Point(0, 0);
            topmenu.Name = "menuStrip1";
            topmenu.Size = new Size(977, 24);
            topmenu.TabIndex = 3;
            topmenu.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolOpen, fileseperate, toolSave });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            // 
            // toolOpen
            // 
            toolOpen.Name = "toolOpen";
            toolOpen.Size = new Size(103, 22);
            toolOpen.Text = "Open";
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
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3 });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(44, 20);
            toolStripMenuItem2.Text = "View";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(127, 22);
            toolStripMenuItem3.Text = "Fullscreen";
            // 
            // About
            // 
            About.Name = "About";
            About.Size = new Size(52, 20);
            About.Text = "About";
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
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem About;
        private ToolStripMenuItem toolOpen;
        private ToolStripMenuItem toolSave;
        private ToolStripSeparator fileseperate;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}
