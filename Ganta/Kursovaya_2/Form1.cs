using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursovaya_2
{
    public partial class fTasks : Form
    {

        List<Task> tasks = new List<Task>();
        List<Person> persons = new List<Person>();
        int flag = 0;
        Task taskbuffer;
        Person personbuffer;
        

        public fTasks()
        {
            InitializeComponent();
            gbPerson.Visible = false;
            btnBack.Visible = false;
            nudComplexity.DecimalPlaces = 0;
            nudComplexity.Increment = 1;
            tbTaskName.Click += new EventHandler(tb_Click);
            pnSettings.AutoScroll = true;
            gbDependentTask.Visible = false;
            gbPeriod.Visible = false;

        }
        private void tb_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tb = sender as System.Windows.Forms.TextBox;
            tb.Text = "";
        }

        private void gb_DoubleClick(object sender, EventArgs e)
        {
            GroupBox gb = sender as GroupBox;
            DialogResult dialogResult = MessageBox.Show("", "Удалить задачу?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Task tasktoremove = null;
                foreach (Task t in tasks)
                {
                    if (t == gb.Tag as Task)
                    {
                        tasktoremove = t;
                        //tasks.Remove(t);
                        //return;
                    }
                }
                pnSettings.Controls.Clear();
                tasks.Remove(tasktoremove);
                
               
                foreach(Task t in tasks)
                {
                    CreateGB(t);
                }
            }
            return;


        }
        private void lb_DoubleClick(object sender, EventArgs e)
        {

            //MessageBox.Show("i was clicked");
            
            ListBox lb = sender as ListBox;
            if (personbuffer != null)
            {
                Task task = lb.Tag as Task;
                foreach (var v in lb.Items)
                {
                    if (v.ToString() == personbuffer.Name)
                    {
                        DialogResult dialogResult = MessageBox.Show("", "Удалить пользователя?", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            lb.Items.Remove(v);
                            personbuffer.Tasks.Remove(lb.Tag as Task);
                            task.Persons.Remove(personbuffer);

                            if(personbuffer.Tasks.Count() == 0)
                            {
                                persons.Remove(personbuffer);
                                
                            }

                            return;
                        }
                        return;
                    }
                }
                lb.Items.Add(personbuffer.ToString());
                personbuffer.Tasks.Add(lb.Tag as Task);
                task.Persons.Add(personbuffer);
            }
            else if (taskbuffer != null)
            {
               
                Task task = lb.Tag as Task;
                if (taskbuffer.Name == task.Name) return;
                foreach (var v in lb.Items)
                {
                    if (v.ToString() == taskbuffer.Name)
                    {
                        DialogResult dialogResult = MessageBox.Show("", "Удалить зависимость?", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            lb.Items.Remove(v);
                            task.Previous.Remove(taskbuffer);
                            taskbuffer.Next.Remove(task);
                            return;
                        }
                        return;
                    }
                }
                
                lb.Items.Add(taskbuffer.ToString());
                task.Previous.Add(taskbuffer);
                taskbuffer.Next.Add(task);

            }
           
        }

        private void bt_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button bt = sender as System.Windows.Forms.Button;
            
            taskbuffer = bt.Tag as Task;
            btnCurrentTask.Text = taskbuffer.Name;
            

        }
        private void btnSwitchGB_Click(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 0:
                    //btnForward.Text = "";
                    gbTask.Visible = false;
                    btnBack.Visible = true;
                    gbPerson.Location = gbTask.Location;
                    gbPerson.Visible = true;
                    flag = 1;
                    foreach (GroupBox gb in pnSettings.Controls)
                    {
                        gb.Controls[2].Enabled = false;
                        gb.Controls[1].Enabled = true;
                    }
                    this.Text = "Установление возможных исполнителей";
                    break;

                case 1:
                    Console.WriteLine(tasks + " " + persons);
                    flag = 2;
                    //btnForward.Text = "b";
                    gbTask.Visible = false;
                    gbPerson.Visible = false;
                    
                    gbDependentTask.Location = gbTask.Location;
                    gbDependentTask.Visible = true;
                    personbuffer = null;
                    //btnCurrentPerson.Visible = false;
                    this.Text = "Установление связи между задачами";
                    foreach (GroupBox gb in pnSettings.Controls)
                    {
                        gb.Controls[1].Enabled = false;
                        gb.Controls[2].Enabled = true;

                    }
                    break;
                case 2:
                    flag = 3;
                    btnForward.Visible = false;
                    gbDependentTask.Visible = false;
                    gbPeriod.Location = gbTask.Location;
                    gbPeriod.Visible = true;
                    break;

            }

        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            if (tbTaskName.Text == "" || nudComplexity.Value == 0)
            {
                MessageBox.Show("Введите настройки задачи");
            }
            else
            {

                foreach (Task t in tasks)
                {
                    if (t.Name == tbTaskName.Text && t.Complexity == (float)nudComplexity.Value)
                    {
                        MessageBox.Show("Такая задача уже есть.");
                        return;
                    }
                    else if (t.Name == tbTaskName.Text && t.Complexity != (float)nudComplexity.Value)
                    {
                        t.Complexity = (float)nudComplexity.Value;
                        return;
                    }
                }
                Task task = new Task(tbTaskName.Text, (float)nudComplexity.Value);
                
                tasks.Add(task);
                CreateGB(task);
            }
        }
        private void CreateGB(Task t)
        {
            GroupBox gb = new GroupBox();
            pnSettings.Controls.Add(gb);


            gb.Text = "Задача " + pnSettings.Controls.Count;
            gb.Size = new Size((pnSettings.Size.Width - 30) / 5, (pnSettings.Size.Height - 20) / 3);

            if (pnSettings.Controls.Count % 5 == 0) { gb.Location = new Point(5 * 5 + (pnSettings.Controls.Count - 1) % 5 * ((pnSettings.Size.Width - 30) / 5), 5 * pnSettings.Controls.Count / 5 + ((pnSettings.Controls.Count - 1) / 5 * ((pnSettings.Size.Height - 20) / 3))); }
            else { gb.Location = new Point(5 * (pnSettings.Controls.Count % 5) + (pnSettings.Controls.Count - 1) % 5 * ((pnSettings.Size.Width - 30) / 5), 5 * (pnSettings.Controls.Count / 5) + 5 + ((pnSettings.Controls.Count - 1) / 5 * ((pnSettings.Size.Height - 20) / 3))); }
            gb.Name = "gb" + pnSettings.Controls.Count;
            gb.Tag = t;
            gb.DoubleClick += new EventHandler(gb_DoubleClick);


            System.Windows.Forms.Button bt = new System.Windows.Forms.Button();
            bt.Size = new Size(gb.Width - 10, gb.Height / 4);
            gb.Controls.Add(bt);
            bt.Location = new Point(5, 13);
            bt.Text = t.Name;
            bt.Name = "btTask" + pnSettings.Controls.Count;
            bt.Tag = t;
            bt.Click += new EventHandler(bt_Click);

            ListBox lb = new ListBox();
            lb.Size = new Size(gb.Width - 10, gb.Height / 3);
            gb.Controls.Add(lb);
            lb.Location = new Point(5, 13 + 5 + gb.Height / 4);
            lb.Name = "lbPerson" + pnSettings.Controls.Count;
            lb.DoubleClick += new EventHandler(lb_DoubleClick);
            lb.Enabled = false;
            lb.Tag = t;

            ListBox lb1 = new ListBox();
            lb1.Size = new Size(gb.Width - 10, gb.Height / 3);
            gb.Controls.Add(lb1);
            lb1.Location = new Point(5, 12 + 5 + gb.Height / 3 + gb.Height / 4);
            lb1.Name = "lbTask" + pnSettings.Controls.Count;
            lb1.DoubleClick += new EventHandler(lb_DoubleClick);
            lb.Enabled = false;
            lb1.Tag = t;
        }

        private void RemoveGB(GroupBox gb)
        {
            foreach(Control c in gb.Controls)
            {
                c.Dispose();
            }
            pnSettings.Controls.Remove(gb);
            gb.Dispose();
        }
       
        private void btnCreatePerson_Click(object sender, EventArgs e)
        {
            if(tbPersonName.Text == "")
            {
                MessageBox.Show("Введите настройки исполнителя");
            }
            else
            {
                foreach (Person p in persons)
                {
                    if(p.Name == tbPersonName.Text)
                    {
                        personbuffer = p;
                        return;
                    }
                }
                personbuffer = new Person(tbPersonName.Text);
                
                persons.Add(personbuffer);
                btnCurrentPerson.Text = personbuffer.Name;
                btnCurrentPerson.Visible = true;
            }
                  
            
        }

        private void btnToPlan_Click(object sender, EventArgs e)
        {
            if(Form4.plan == null)
            {

                MessageBox.Show("Не все характеристики указаны");
                return;
            }
           
            form2 fPlan = new form2();
            Form4.plan.rectangles = Form4.plan.GetGanta(Form4.plan.Sorted, fPlan.pnGanta);
            this.Visible = false;
            fPlan.Show();

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 1:
                    
                    flag = 0;
                    gbPerson.Visible = false;
                    gbTask.Visible = true;
                    btnForward.Visible = true;
                    personbuffer = null;
                    btnCurrentPerson.Text = "";
                    //btnCurrentPerson.Visible = false;
                    this.Text = "Создание задач";
                    foreach (GroupBox gb in pnSettings.Controls)
                    {
                        gb.Controls[2].Enabled = false;
                        gb.Controls[1].Enabled = false;
                    }
                    break;
                    
                case 2:
                   
                    flag = 1;
                    gbPerson.Visible = true;
                    btnForward.Visible = true;
                    taskbuffer = null;
                    btnCurrentPerson.Text = "";
                    btnCurrentTask.Text = "";
                    gbDependentTask.Visible = false;
                    this.Text = "Установление возможных исполнителей";
                    foreach (GroupBox gb in pnSettings.Controls)
                    {
                        gb.Controls[2].Enabled = false;
                        gb.Controls[1].Enabled = true;
                    }
                    break;
                case 3:
                    btnBack.Visible = false;
                    flag = 2;
                    gbPeriod.Visible = false;
                    gbDependentTask.Visible = true;
                    break;


            }
        }

        private void btnSetPeriod_Click(object sender, EventArgs e)
        {

            if(dtpEnd.Value < dtpStart.Value)
            {
                MessageBox.Show("Ошибка с периодом");
            }
            try
            {
                Form4.plan = new Plan(dtpStart.Value, dtpEnd.Value, tasks, persons, true);
                
                
            }
            catch
            {
                MessageBox.Show("Сортировка невозможна. Проверьте исходные данные");
            }
            
           
            //plan.Kana(tasks);
            foreach(List<Task> p in Form4.plan.Sorted)
            {
                foreach(Task t in p)
                {
                    Console.WriteLine("form1 count = " + t.Previous.Count);
                }
               
            }
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            if (Form4.plan == null)
            {
                MessageBox.Show("Не все характеристики указаны");
                return;
            }
            Form3 fTree = new Form3();
            
            this.Visible = false;
            fTree.Show();
        }
    }
}
