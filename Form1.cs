namespace FlowViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutmenu_Click(object sender, EventArgs e)
        {

            Form aboutwindowform = new Form();

            aboutwindowform.Show();
            aboutwindowform.Text = "About Flow";
            aboutwindowform.Location = new Point(300, 200);
            aboutwindowform.Size = new Size(600, 350);


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
