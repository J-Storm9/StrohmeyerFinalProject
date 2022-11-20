using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrohmeyerFinalProject
{
    internal class Task
    {

        /*
         *This digital task organizer will use a Priority queue to store the task objects.
         * Users will be able to create, edit, set priorities, and due dates to tasks.
         * This program will also have functionality for sorting the tasks by priority, due date, and more using a Linked list.
         *ddd
         */

        private string taskId;// may not need this
        private int pri;
        private DateTime dueDate;
        private string title;
        //private string description;
        private DateTime dateCreated;

        // getters and setters 
        public string TaskId
        {
            get => taskId;
            set => taskId = value;
        }

        public int Pri
        {
            get => pri;
            set => pri = value;
        }

        public DateTime DueDate
        {
            get => dueDate;
            set => dueDate = value;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public DateTime DateCreated
        {
            get => dateCreated;
            set => dateCreated = value;
        }

        //default constructor
        public Task()
        {

        }
    }
}
