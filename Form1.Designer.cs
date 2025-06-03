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
            Forward = new Button();
            Backward = new Button();
            DrawingPen = new Button();
            Highlighter = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolOpen = new ToolStripMenuItem();
            toolSave = new ToolStripMenuItem();
            seperate = new ToolStripSeparator();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            About = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Forward
            // 
            Forward.Location = new Point(845, 502);
            Forward.Name = "Forward";
            Forward.Size = new Size(125, 55);
            Forward.TabIndex = 0;
            Forward.Text = "Forward";
            Forward.UseVisualStyleBackColor = true;
            // 
            // Backward
            // 
            Backward.Location = new Point(12, 502);
            Backward.Name = "Backward";
            Backward.Size = new Size(125, 55);
            Backward.TabIndex = 0;
            Backward.Text = "Backward";
            Backward.UseVisualStyleBackColor = true;
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
            // menuStrip1
            // 
            menuStrip1.AllowDrop = true;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, About });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(977, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolOpen, seperate, toolSave });
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
            // toolSave
            // 
            toolSave.Name = "toolSave";
            toolSave.Size = new Size(103, 22);
            toolSave.Text = "Save";
            // 
            // seperate
            // 
            seperate.Name = "seperate";
            seperate.Size = new Size(100, 6);
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
            toolStripMenuItem3.Size = new Size(180, 22);
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
            Controls.Add(Forward);
            Controls.Add(Backward);
            Controls.Add(DrawingPen);
            Controls.Add(Highlighter);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Flow Viewer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Forward;
        private Button Backward;
        private Button DrawingPen;
        private Button Highlighter;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem About;
        private ToolStripMenuItem toolOpen;
        private ToolStripMenuItem toolSave;
        private ToolStripSeparator seperate;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}
