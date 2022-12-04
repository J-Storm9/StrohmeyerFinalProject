using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrohmeyerFinalProject
{
    public class TaskList
    {
        /*
         
         
         * This program will also have functionality for sorting the tasks by priority, due date, and more using a Linked list.
         */

        //todo: Linked list to store tasks
        private LinkedList<Task> tl;
        //todo: method create
        public void CreateTask()
        {
            Task task = new Task();
            tl.AddLast(task);
        }

        //method edit due date
        public void editDueDate(string id, DateTime date) { 
            var task = tl.Where(task => task.TaskId == id).First();
            task.DueDate = date;
        }

        //method set priority
        public void setPri(string id, int pri)
        {
            var task = tl.Where(task => task.TaskId == id).First();
            task.Pri = pri;

        }

        //method set priority
        public void editTitle(string id, string title)
        {
            var task = tl.Where(task => task.TaskId == id).First();
            task.Title = title;

        }

        //todo: sort by pri


        //todo: sort by due date

        //todo: sort by created
    }
}
