using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Kursovaya_2
{
    internal class Plan
    {
        DateTime start;
        DateTime end;
        List<Person> persons;
        List<Task> tasks;
        int days;
        List<List<Task>> sorted;
        public float MaxComplexity;
        public List<Task> criticalPath;
        public List<Rectangle> rectangles;

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
        internal List<List<Task>> Sorted
        {
            get { return sorted; }
            set { sorted = value; }
        }
        [JsonConstructor]
        public Plan(DateTime start, DateTime end, List<Task> tasks, List<Person> persons = null, bool notJson = false)
        {
            this.start = start;
            this.end = end;
            if(!notJson)
            {
                foreach (Person p in persons)
                {
                    p.MakeDependencies(p.taskStr, tasks);
                }
                foreach (Task t in tasks)
                {
                    t.MakeDependencies(t.persStr, t.prevStr, tasks, persons);
                }
            }
           
            this.persons = persons;
            this.tasks = tasks;
            days  = (end - start).Days;
            float sum = 0;
            foreach (Task t in tasks)
            {
                sum += t.Complexity;
            }
            GetPercentage(sum);
           
            sorted = this.Kana(tasks);
            foreach (Person p in persons)
            {
                for (int i = 0; i < sorted.Count; i++)
                {
                    p.Currents.Add(new List<Task>());
                }
            }
            sorted = this.Genetich(sorted);
            criticalPath = FindMaxComplexitySequence();
           
            GetTime(sorted);

            
            

        }

       
      
        public List<Task> Tasks
        {
            get { return tasks; }
            set { tasks = value; }
        }
        public List<Person> Persons
        {
            get { return persons; }
            set { persons = value; }
        }

        public void GetPercentage(float max)
        {
            foreach (Task t in tasks)
            {
                t.Complexity = 100 * t.Complexity / max / 100;
                Console.WriteLine(t.Complexity);
            }
            
        }

        public List<List<Task>> Kana(List<Task> ta)
        {
            foreach (Task t in this.Tasks)
            {
                Console.WriteLine(t.Previous.Count);
            }

            List<Task> tasks1 = Task.CopyList(ta);
            List<List<Task>> sorted = new List<List<Task>>();
            
            int level = 0;
           
            bool foundzero = false ;

            while(tasks1.Count != 0)
            {
                List<Task> toremove = new List<Task>();
                sorted.Add(new List<Task>());
                foundzero = false;
                for(int i = 0; i < tasks1.Count; i++)
                {
                    //Console.WriteLine("Kana count = " + t.Previous.Count);
                    if (tasks1[i].Previous.Count == 0)
                    {

                        foundzero = true;

                        var itemToAdd = ta.FirstOrDefault(t => t.Name == tasks1[i].Name);
                        if (itemToAdd != null)
                        {
                            sorted[level].Add(itemToAdd);
                        }

                        toremove.Add(tasks1[i]);
                        
                    }
                }
                foreach(Task t in toremove)
                {
                    foreach (Task tnext 
                       
                        in t.Next)
                    {
                        tnext.Previous.Remove(t);
                    }
                    tasks1.Remove(t);
                }
                level++;
               
                if (!foundzero)
                {

                    throw new Exception("сортировка невозможна");
                }
            }
            foreach(List<Task> l in sorted)
            {
                foreach(Task t in l)
                {
                    Console.WriteLine("sorted in kana count = " + t.Previous.Count);
                }
            }
           
            return sorted;
         
            
        }
        public List<List<Task>> Genetich(List<List<Task>> list)
        {
            Dictionary<int, int> toRemove = new Dictionary<int, int>();
            for (int i = 0; i <  list.Count; i++)
            {
                for(int j = 0; j < list[i].Count; j++)
                {
                   
                    var availablePersons = list[i][j].Persons.Where(p => p.Currents[i].Count < 2).ToList();
                    Person selectedPerson = null;

                    // Выбираем человека с наименьшим количеством текущих задач
                    int minTasks = availablePersons.Min(p => p.Currents[i].Count);
                    selectedPerson = availablePersons.FirstOrDefault(p => p.Currents[i].Count == minTasks);

                    if (selectedPerson != null)
                    {
                        selectedPerson.Currents[i].Add(list[i][j]);
                        list[i][j].actualPers = selectedPerson;
                        // Обновляем список задач, которые человек может выполнить
                        selectedPerson.Tasks.Remove(list[i][j]);

                        // Обновляем зависимые задачи
                    }
                    else
                    {
                        toRemove.Add(i, j);
                        if (i == list.Count - 1)
                        {
                            throw new Exception("distribution is unavailable");
                        }
                    }
                    
                }
            }
            foreach(var rem in toRemove)
            {
                list[rem.Key + 1].Add(list[rem.Key][rem.Value]);
                list[rem.Key].Remove(list[rem.Key][rem.Value]);
                
            }
            return list;

        }
        public List<Rectangle> GetGanta(List<List<Task>> sorted, Panel pn)
        {

            GetPercentage(this.MaxComplexity);
           
            Random rnd = new Random();

            int x = 5;
            int y = 5;
            List<Rectangle> rect = new List<Rectangle>();
            rect.Add(new Rectangle(x, y, pn.Width - 10 - x, 3, Color.Black));
            rect.Add(new Rectangle(x, y, 3, pn.Height - y, Color.Black));

            for (int level = 0; level < sorted.Count; level++)
            {
                for (int task = 0; task < sorted[level].Count; task++)
                {
                    for (int k = 0; k < this.tasks.Count; k++)
                    {
                        if (sorted[level][task].Name == tasks[k].Name)
                        {
                            x = GetScale(tasks[k], pn, x) + 8; //почему комплексити - 100
                            int currY = y + 3 + pn.Height / tasks.Count * k;
                            float currWidth = ((pn.Width - 2 * 18) * tasks[k].Complexity);
                            int currHeight = pn.Height / tasks.Count;
                            rect.Add(new Rectangle(x, currY, currWidth, currHeight, Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))));
                            break;
                        }
                    }
                } 
            }
            return rect;
        }
        private int GetScale(Task t, Panel pn,int x)
        {
            if (t.Previous.Count == 0) return 0;
            
            int mx = 0;
            foreach (Task tt in t.Previous)
            {   if ((int)(GetScale(tt, pn, x) + tt.Complexity * (pn.Width - 2 * 18)) > mx)
                {
                    mx = (int)(GetScale(tt, pn, x) + tt.Complexity * (pn.Width - 2 * 18));
                } 
            }
            return mx;
            

        }
        public List<Task> FindMaxComplexitySequence()
        {
            float maxComplexity = 0;
            List<Task> maxComplexitySequence = new List<Task>();

            foreach (var list in Sorted)
            {
                foreach (var task in list)
                {
                    var complexitySequence = GetComplexitySequence(task, new List<Task>());
                    float currentComplexity = complexitySequence.Sum(t => t.Complexity);
                    if (currentComplexity > maxComplexity)
                    {
                        maxComplexity = currentComplexity;
                        maxComplexitySequence = complexitySequence;
                    }
                }
            }

            MaxComplexity = maxComplexity;
            return maxComplexitySequence;
        }

        private List<Task> GetComplexitySequence(Task task, List<Task> visited)
        {
            visited.Add(task);
            List<Task> maxSequence = new List<Task>(visited);
            float maxComplexity = visited.Sum(t => t.Complexity);

            foreach (var nextTask in task.Next.Where(t => !visited.Contains(t)))
            {
                var sequence = GetComplexitySequence(nextTask, new List<Task>(visited));
                float currentComplexity = sequence.Sum(t => t.Complexity);
                if (currentComplexity > maxComplexity)
                {
                    maxComplexity = currentComplexity;
                    maxSequence = sequence;
                }
            }

            return maxSequence;
        }
        public void GetTime(List<List<Task>> sorted)
        {

            foreach(List<Task> list in sorted)
            {
               
                foreach(Task t in list)
                {
                    t.GetTime(t, days, Start, End);
                    Console.WriteLine("STart: " + t.Start.ToString("dd/MM/yyyy") + " End: " + t.End.ToString("dd/MM/yyyy"));
                   
                }
            }        

        }  
    }




}

