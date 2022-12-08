using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrohmeyerFinalProject
{
    public class TaskList
    {
        //Linked list to store tasks
        private LinkedList<Task> tl;
        public TaskList() {
            Tl = new LinkedList<Task>();
        
        }

        public LinkedList<Task> Tl
        {
            get => tl;
            set => tl = value;
        }

        //method create
        public void CreateTask(string id, int pri, string title, DateTime due)
        {
            Task task = new Task(pri, title, due);
            task.TaskId = id;
            Tl.AddLast(task);
        }

        //method set due date
        public void editDueDate(string id, DateTime date) { 
            var task = Tl.Where(task => task.TaskId == id).First();
            task.DueDate = date;
        }

        //method set priority
        public void setPri(string id, int pri)
        {
            var task = Tl.Where(task => task.TaskId == id).First();
            task.Pri = pri;

        }

        //method set priority
        public void editTitle(string id, string title)
        {
            var task = Tl.Where(task => task.TaskId == id).First();
            task.Title = title;

        }
        //get task by id
        public Task getTask(string id)
        {
            return Tl.Where(task => task.TaskId == id).First();
        }
        //delete task by id
        public void deleteTask(string id)
        {
            Tl.Remove(Tl.Where(task => task.TaskId == id).First());
        }

        //todo: sort by pri////////////////////////////////////
        public PriorityQueue<Task, int> SortByPri(LinkedList<Task> tl)
        {
            PriorityQueue<Task, int> pq = new PriorityQueue<Task, int>();
            foreach (Task t in tl)
            {
                pq.Enqueue(t, -t.Pri);
            }
            return pq;
        }

        //todo: sort by due date
        public PriorityQueue<Task, DateTime> SortByDue(LinkedList<Task> tl)
        {
            PriorityQueue<Task, DateTime> pq = new PriorityQueue<Task, DateTime>();
            foreach (Task t in tl)
            {
                pq.Enqueue(t, t.DueDate);
            }
            return pq;
        }

        //todo: sort by created
        public PriorityQueue<Task, DateTime> SortByCreated(LinkedList<Task> tl)
        {
            PriorityQueue<Task, DateTime> pq = new PriorityQueue<Task, DateTime>();
            foreach (Task t in tl)
            {
                pq.Enqueue(t, t.DateCreated);
            }
            return pq;
        }
    }
}
