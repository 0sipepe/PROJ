using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_2
{
    internal class Person
    {

        string name;
        List<Task> tasks;
        List<List<Task>> currents;
        public List<string> taskStr;


        public List<List<Task>>  Currents
        {

            get { return currents; }
            set { currents = value; }
        }
        public Person(string name)
        {
            this.name = name;
            tasks = new List<Task>();
            currents = new List<List<Task>>();
        }
        [JsonConstructor]
        public Person(string name, List<string> tasks, List<string> currents)
        {
            this.name = name;
            this.tasks = new List<Task>();
            this.currents = new List<List<Task>>();
            taskStr = tasks;
           
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            return this.Name;
        }
        public List<Task> Tasks
        {
            get { return tasks; }
            set { tasks = value; }
        }
        public void MakeDependencies(List<string> tasks, List<Task> t)
        {
            foreach (string taskName in tasks)
            {
                // Находим задачу с совпадающим именем
                Task tt = t.FirstOrDefault(ttt => ttt.Name == taskName);
                if (tt != null)
                {
                    // Выполняем действие, если задача найдена
                    this.Tasks.Add(tt);
                }
            }
        }

    }
    
}
