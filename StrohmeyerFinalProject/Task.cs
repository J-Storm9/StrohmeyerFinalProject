using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrohmeyerFinalProject
{
    public class Task
    {
        //properties
        private string taskId;// may not need this
        private int pri;// 0, 1, 2, 3// may not need this either???
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
            this.Pri = 0;
            this.DateCreated = DateTime.Now;
            this.DueDate = DateTime.Now.AddDays(7);
            this.Title = "";
        }

    }
}
