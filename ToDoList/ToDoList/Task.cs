using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Task
    {
        private string _nameOfTask;
        private DateOnly _deadline;
        private DateOnly _doneDate;

        public Task(string nameOfTask, DateOnly deadline)
        {
            _nameOfTask = nameOfTask;
            _deadline = deadline;
            _doneDate = default;
        }
        public void GetTaskInfo()
        {
            Console.WriteLine($"Oppgave: {_nameOfTask}  Deadline: {_deadline}");
        }
        public void GetDoneTaskInfo()
        {
            Console.WriteLine($"Oppgave: {_nameOfTask}  Deadline: {_deadline} Ferdig: {_doneDate.ToString("yyyy-MM-dd")}");
        }
        public void SetDone()
        {
            _doneDate = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
