using System;
using System.Drawing.Text;


namespace FlowViewer
{
    public partial class Form1 : Form
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Form1()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            InitializeComponent();
        }

        private RichTextBox windowformbox;
        private void aboutmenu_Click(object sender, EventArgs e)
        {
            
            windowformbox = new RichTextBox();
            Form aboutwindowform = new Form();

            aboutwindowform.Show();
            aboutwindowform.Text = "About Flow";
            aboutwindowform.Location = new Point(300, 200);
            aboutwindowform.Size = new Size(600, 350);

            aboutwindowform.Controls.Add(windowformbox);
            windowformbox.Text = "Flow Viewer. All Rights Reserved.\n" +
            "Flow Viewer is a quick, low-memory document reader. " +
            "Open documents, Save documents, all through the File Menu. And under the view tab you can change your view to fit your preferences.\n";
            windowformbox.ReadOnly = true;
            windowformbox.Height = 300;
            windowformbox.Width = 575;
            windowformbox.WordWrap = true;
            windowformbox.Show();
        }
           

        private void bigger_Click(object sender, EventArgs e)
        {


            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 800);

        }

        private void toolSave_Click(object sender, EventArgs e)
        {


        }


        private void smaller_Click(object sender, EventArgs e)
        {

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 300);

        }

        private void reset_Click(object sender, EventArgs e)
        {

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);

        }
        private void toolOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open File";
            openFileDialog.ShowDialog();



        }

        
    }
}
