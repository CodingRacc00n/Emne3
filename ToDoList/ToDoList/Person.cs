using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Person
    {
        private string _name;
        private List<Task> _tasks;
        private Task _selectedTask;

        public Person(string name, List<Task> tasks)
        {
            _name = name;
            _tasks = tasks;
        }

        public string GetName()
        { 
            return _name; 
        }
        public void ShowTask(View view)
        {
            if(_tasks.Count > 0)
            {
                for (int i = 0; i < _tasks.Count; i++)
                {
                    Console.Write($"{i}. ");
                    _tasks[i].GetTaskInfo();
                }
                var input = Convert.ToInt32(Console.ReadLine());
                if(input < _tasks.Count)
                {
                    _selectedTask = _tasks[input];
                    view.MoveToDone(_selectedTask);
                    _tasks.Remove(_selectedTask);
                    _selectedTask.SetDone();
                }
            }
            else
            {
                Console.WriteLine("Her var det ingenting");
            }
        }
        public void AddNewTask(Task newTask)
        {
            _tasks.Add(newTask);
        }
    }

}
