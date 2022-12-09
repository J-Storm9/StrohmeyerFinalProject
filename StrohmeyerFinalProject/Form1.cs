using System.Xml;

namespace StrohmeyerFinalProject
{
    public partial class Form1 : Form
    {
        // properties
        public TaskList taskList = new TaskList();
        private int runningTaskID = 0;
        public Form1()
        {
            InitializeComponent();
            
           
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        ////////////////////////////////CREATE TASK///////////////////////////
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

            //create task using captured user data, adding it to the TaskList
            taskList.CreateTask("t1" + runningTaskID,Pri ,title,date );
            
            //add task to display
            ListViewItem item = new ListViewItem("t1" + runningTaskID);
            item.SubItems.Add(title.ToString());
            item.SubItems.Add(Pri.ToString());
            item.SubItems.Add(date.ToString());
            item.SubItems.Add(taskList.getTask("t1"+runningTaskID).DateCreated.ToString());
            
            listView1.Items.Add(item);
            
            //iterate task id
            runningTaskID++;

        }

        // auto generated methods
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void titleTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void pri_Click(object sender, EventArgs e)
        {

        }
        
        // complete/remove task
        private void removeTaskBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //show task id of completed task
                MessageBox.Show(listView1.SelectedItems[0].Text + " Completed!" );
                //remove task from linked list
                taskList.deleteTask(listView1.SelectedItems[0].Text);
                //remove task from listView
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No task selected");
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
            if (e.Column.ToString() == "2")
            {//sort by priority
                listView1.Items.Clear();
                PriorityQueue<Task,int> prilist = taskList.SortByPri(taskList.Tl);
                while (prilist.Count > 0)
                {
                    Task x = prilist.Dequeue();
                    addTaskToListView(x);
                }

            }else if (e.Column.ToString() == "3")
            {//sort by due date
                listView1.Items.Clear();
                PriorityQueue<Task, DateTime> prilist = taskList.SortByDue(taskList.Tl);
                while (prilist.Count > 0)
                {
                    Task x = prilist.Dequeue();
                    addTaskToListView(x);
                }
            }
            else if (e.Column.ToString() == "4")
            {// sort by created
                listView1.Items.Clear();
                PriorityQueue<Task, DateTime> prilist = taskList.SortByCreated(taskList.Tl);
                while (prilist.Count > 0)
                {
                    Task x = prilist.Dequeue();
                    addTaskToListView(x);
                }
            }
        }

        public void addTaskToListView(Task task)
        {
            ListViewItem item = new ListViewItem(task.TaskId.ToString());
            item.SubItems.Add(task.Title.ToString());
            item.SubItems.Add(task.Pri.ToString());
            item.SubItems.Add(task.DueDate.ToShortDateString());
            item.SubItems.Add(task.DateCreated.ToShortDateString());

            listView1.Items.Add(item);
        }

        
        private void editButton_Click(object sender, EventArgs e)
        {
            
                //find the task selected
                try
                {
                    Task t = taskList.getTask(listView1.SelectedItems[0].Text.ToString());

                    // create new instance of editForm class
                    editForm editForm = new editForm(this);

                    // pass task info from form1 to editForm
                    editForm.textBoxTitle.Text = t.Title.ToString();
                    if (t.Pri == 1)
                    {
                        editForm.radioButtonLowEdit.Checked = true;
                    }
                    else if (t.Pri == 2)
                    {
                        editForm.radioButtonMedEdit.Checked = true;
                    }
                    else if (t.Pri == 3)
                    {
                        editForm.radioButtonHighEdit.Checked = true;
                    }

                    editForm.dateTimePickerDue.Value = t.DueDate;

                    editForm.id = t.TaskId;


                    editForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No task selected");
                }
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}