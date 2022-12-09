using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrohmeyerFinalProject
{
    public partial class editForm : Form
    {
        private Form1 f1;

        public editForm(Form1 ParentForm)
        {
            InitializeComponent();
            f1 = ParentForm;
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            Task t = f1.taskList.getTask(id);
            t.Title = textBoxTitle.Text;
            if (radioButtonHigh.Text == "1")
            {
                t.Pri = 1;
            } else if (radioButtonHigh.Text == "2")
            {
                t.Pri = 2;
            }
            else if (radioButtonHigh.Text == "3")
            {
                t.Pri = 3;
            }
            else
            {
                t.Pri = 0;
            }

            t.DueDate = dateTimePickerDue.Value;
            

            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
