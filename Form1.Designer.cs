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
            About = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripTextBox3 = new ToolStripTextBox();
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
            // About Menu Item
            //
            About.Name = "About Menu Item";
            About.Size = new Size(35, 20);
            About.Text = "About";
            
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
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripTextBox2 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            toolStripTextBox1.Text = "Open";
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 23);
            toolStripTextBox2.Text = "Save";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox3});
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(44, 20);
            toolStripMenuItem2.Text = "View";

            toolStripTextBox3.Name = "viewbox1";
            toolStripTextBox3.Size = new Size(100, 23);
            toolStripTextBox3.Text = "Fullscreen";
            
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
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripTextBox toolStripTextBox3;
    }
}
