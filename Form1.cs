using FlowViewer.Properties;
using System;
using System.Drawing.Design;
using System.Drawing.Text;
using System.IO;
using System.Resources;
using System.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FlowViewer
{
    public partial class Form1 : Form
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Form1()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            InitializeComponent();

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));


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
            aboutwindowform.ShowIcon = true;
            aboutwindowform.Icon = Icon;

            aboutwindowform.Controls.Add(windowformbox);
            windowformbox.Text = "Flow Viewer\n" +
            "\nFlow Viewer is a quick, low-memory document reader. " +
            "Open and save documents, all through the file menu. And under the view tab you can change your view to fit your preferences.\n" +
            "\nFollow me on Github: github.com/David8861.\n";
            windowformbox.ReadOnly = true;
            windowformbox.Name = "About Flow";
            windowformbox.Location = new Point(5, 5);
            windowformbox.Height = 325;
            windowformbox.Width = 570;
            windowformbox.WordWrap = true;
            windowformbox.BackColor = SystemColors.Menu;
            windowformbox.Show();
        }

        private void drawpen_Click(object sender, EventArgs e)
        {
            drawpen.Select();
            
            
        }

        private void highlight_Click(object sender, EventArgs e)
        {



        }


        private void bigger_Click(object sender, EventArgs e)
        {


            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 800);

        }

        private void toolSave_Click(object sender, EventArgs e)
        {



        }
        private void toolExit_Click(object sender, EventArgs e)
        {

            Application.Exit();

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


            openFileDialog.Title = "Open Doc";
            openFileDialog.Multiselect = false;
            openFileDialog.DefaultExt = ".pdf";
            openFileDialog.ShowDialog();

            ScrollBars = new ScrollBars();
            ScrollBars = ScrollBars.Vertical;

            try
            {

                var sr = new StreamReader(openFileDialog.FileName);
                var data = sr.ReadToEnd();
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }

        OpenFileDialog openFileDialog = new OpenFileDialog();

        public ScrollBars ScrollBars { get; private set; }
    }
}
