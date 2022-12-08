namespace StrohmeyerFinalProject
{
    public partial class Form1 : Form
    {
        TaskList taskList = new TaskList();
        private int runningTaskID = 0;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        ////////////////////////////////CREATE TASK//////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            // set priority based on user input
            int Pri = 0;
            if (radioButtonHigh.Checked)
            {
                Pri = 3;} else if (radioButtonMedium.Checked)
            {
                Pri = 2;
            } else if (radioButtonLow.Checked)
            {
                Pri = 1;
            }

            // set title based on user input
            string title = titleTextbox.Text;

            // set date based on user input
            DateTime date = dateTimePicker1.Value;

            //create task using captured user data
            taskList.CreateTask("t1" + runningTaskID,Pri ,title,date );
            runningTaskID++;

            richTextBox1.Text = taskList.getTask("t10").TaskId + "\n"+
                                taskList.getTask("t10").Title + "\n"+
            taskList.getTask("t10").DateCreated + "\n"+
            taskList.getTask("t10").DueDate + "\n"+
            taskList.getTask("t10").Pri + "\n";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void titleTextbox_TextChanged(object sender, EventArgs e)
        {
            //titleTextbox.Text =
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

       

        private void pri_Click(object sender, EventArgs e)
        {

        }
    }
}