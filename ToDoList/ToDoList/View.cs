using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class View
    {
        private List<Person> _people;
        private List<Task> _doneTasks;
        private Person _loggedinPerson;
        
        
        public View()
        {
            _people =
                [
                    new Person("Bjarne",[new Task("Rydde kjøkken",new DateOnly(2024,12,11))]),
                    new Person("Kåre",[new Task("Vaske bad",new DateOnly(2024,12,11))]),
                    new Person("Lisa",[new Task("Gå ut med søppel",new DateOnly(2024,12,11))]),
                    new Person("Bernt",[new Task("Klippe plen",new DateOnly(2024,12,11))]),
                ];
            _doneTasks = [];
            Login();
        }
        private void Login()
        {
            while(true)
            {
                for(int i = 0; i < _people.Count; i++)
                {
                    Console.WriteLine($"{i}. {_people[i].GetName()}");
                }

                var input = Convert.ToInt32(Console.ReadLine());
                if(input < _people.Count)
                {
                    _loggedinPerson = _people[input];
                    Console.WriteLine($"Du valgte {_loggedinPerson.GetName()}");
                    break;
                }
                else
                {
                    Console.WriteLine("Feil input");
                }
            }
            Run();
        }

        private void Run()
        {
            bool exit = false;
            while(!exit)
            {
                Console.WriteLine("1. Se tasks");
                Console.WriteLine("2. Legg til ny task");
                Console.WriteLine("3. Se ferdig tasks");
                Console.WriteLine("4. Avslutt");
                var input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        _loggedinPerson.ShowTask(this);
                        break;
                    case 2:
                        AddTask();
                        break;
                    case 3:
                        ShowDoneTasks();
                        break;
                    case 4:
                        exit=true;
                        break;
                    default:
                        break;
                }
            }
        }
        public void MoveToDone(Task task)
        {
            _doneTasks.Add(task);
        }
        public void AddTask()
        {
            Console.WriteLine("Navn på oppgave");
            var name = Console.ReadLine();
            var defdeadLine = DateTime.Now.AddDays(7);
            var deadline = DateOnly.FromDateTime(defdeadLine);
            var newTask = new Task(name, deadline);
            _loggedinPerson.AddNewTask(newTask);
        }
        public void ShowDoneTasks()
        {
            if( _doneTasks.Count > 0 )
            {

            for (int i = 0; i < _doneTasks.Count; i++)
            {
                _doneTasks[i].GetDoneTaskInfo();
            }
            Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("Her var det ingenting");
            }
        }
    }
}
