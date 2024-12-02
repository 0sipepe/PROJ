using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Kursovaya_2
{
    internal class Task
    {
        
        string name;
        float complexity;
        List<Person> persons;
        List<Task> previous;
        List<Task> next;
        public List<string> persStr;
        public List<string> prevStr;
        public Person actualPers;
        DateTime start;
        DateTime end;


        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }
        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }


        //public bool Visited
        //{
        //    get { return visited; }
        //    set { visited = value; }
        //}

        public Task(string name, float complex)
        {
            this.name = name;
            complexity = complex;
            persons = new List<Person>();
            previous = new List<Task>();
            next = new List<Task>();

        }
        [JsonConstructor]
        public Task(string name, float complexity, List<string> previous,  List<string> persons)
        {
            this.name = name;
            this.complexity = complexity;
            this.persons = new List<Person>();
            this.previous = new List<Task>();
            this.next = new List<Task>();
            persStr = persons;
            prevStr = previous;
            
            
           
        }
        public Task(Task t)
        {
            name = t.Name;
            complexity = t.Complexity;
            persons = new List<Person>();
            previous = new List<Task>();
            next = new List<Task>();
        }
        public static List<Task> CopyList(List<Task> list)
        {
            List<Task> l = new List<Task>();
            for(int i =  0; i < list.Count; i++)
            {
                l.Add(new Task(list[i]));
            }
            for(int i = 0; i < l.Count; i++)
            {
                for(int j = 0; j < list.Count; j++)
                {
                    if(j != i)
                    {
                        foreach(Task t in list[i].Previous)
                        {
                            if(t.Name == l[j].Name)
                            {
                                l[i].Previous.Add(l[j]);
                                l[j].Next.Add(l[i]);
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                for(int j = 0; j < list[i].Persons.Count; j++)
                {
                    l[i].Persons.Add(list[i].Persons[j]);
                }
               
            }
            foreach(Task tt in l)
            {
                Console.WriteLine("copy count= " + tt.Previous.Count);
            }
            return l;

        }
        public string Name
        {
            get { return name; }
            
        }
        public List<Task> Previous
        {
            get { return previous; }
            set { previous = value; }
        }
        public List<Task> Next
        {
            get { return next; }
            set { next = value; }
        }
        public List<Person> Persons
        {
            get { return persons; }
            set { persons = value; }
        }
        public override string ToString()
        {
            return this.Name;
        }
        public float Complexity
        {
            get { return complexity; }
            set { complexity = value; }
        }
        public void MakeDependencies(List<string> pers, List<string> prev, List<Task> t, List<Person> p)
        {
            foreach (string persName in pers)
            {
                // Находим задачу с совпадающим именем
                Person pp = p.FirstOrDefault(ppp => ppp.Name == persName);
                if (pp != null)
                {
                    // Выполняем действие, если задача найдена
                    this.Persons.Add(pp);
                }
            }

            foreach (string taskName in prev)
            {
                // Находим задачу с совпадающим именем
                Task tt = t.FirstOrDefault(ttt => ttt.Name == taskName);
                if (tt != null)
                {
                    // Выполняем действие, если задача найдена
                    this.Previous.Add(tt);
                    tt.Next.Add(this);
                }
            }
          
        }
        public DateTime GetTime(Task t, int days, DateTime start = default(DateTime), DateTime end = default(DateTime))
        {

            if (t.Previous.Count == 0)
            {
                if (start != default(DateTime))
                {
                    t.Start = start;
                    t.End = start.AddDays(Math.Round(t.Complexity * days, 0));
                }
                return start;
            }
            DateTime mx = start;
            foreach (Task tt in t.Previous)
            {
                if(tt.End > mx)
                {
                    mx = tt.End;
                }
                //mx = (int)(GetTime(tt, days) + tt.Complexity * days);
               
            }
            t.Start = mx;
            t.End = mx.AddDays(Math.Round(t.Complexity * days, 0));
            return mx;
        }


    }
}
