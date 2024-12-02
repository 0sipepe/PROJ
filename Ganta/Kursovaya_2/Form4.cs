using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Globalization;
using System.IO;



namespace Kursovaya_2
{
    public partial class Form4 : Form
    {
        List<Task> tasks = new List<Task>();
        List<Person> persons = new List<Person>();
        internal static Plan plan;

        public Form4()
        {
            InitializeComponent();
        }

        private void btnToCreate_Click(object sender, EventArgs e)
        {
            fTasks f = new fTasks();
            f.Show();
            this.Visible = false;
        }

        private void btnFromFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            string filePath = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog1.FileName);
                filePath = openFileDialog1.FileName;
            }
            else
            {
                return;
            }
            var jsonPlan = File.ReadAllText(filePath);
            plan = JsonConvert.DeserializeObject<Plan>(jsonPlan);

            form2 f2 = new form2();
            plan.rectangles = plan.GetGanta(plan.Sorted, f2.pnGanta);
            Form3 fTree = new Form3();
            this.Visible = false;
            fTree.Show();
        }
         
    }
}
