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



            SuspendLayout();
            // 
            // Forward
            // 
            Forward.Location = new Point(818, 475);
            Forward.Name = "Forward";
            Forward.Size = new Size(120, 55);
            Forward.TabIndex = 0;
            // 
            // Backward
            // 
            Backward.Location = new Point(12, 475);
            Backward.Name = "Backward";
            Backward.Size = new Size(120, 55);
            Backward.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 550);
            Controls.Add(Forward);
            Controls.Add(Backward);
            Name = "Form1";
            Text = "Flow Viewer";
            ResumeLayout(false);
        }

        #endregion

        private Button Forward;
        private Button Backward;
    }
}
