namespace StrohmeyerFinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "CREATE NEW";
        }

        public void label1_Click(object sender, EventArgs e)
        {
            CreateTask();
            label1.Text = "hi";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}