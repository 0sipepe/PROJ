using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TsvetovoyKod
{
    public partial class Form3 : Form
    { 
       
        public Form3()
        {
            InitializeComponent();
            gbWinners.ForeColor = Color.White;
            gbWinners.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void btnBackFromResults_Click(object sender, EventArgs e)
        {
            Form6 MainScreen = new Form6();
            this.Visible = false;
            MainScreen.Show();
        }

        private void Form3_Load(object sender, EventArgs e) => FillLables();
        
        
        private void FillLables()
        {
            for (int a = 0; a < User.users.Count - 1; a++)
            {          
                label1.Text += User.users[a].Name +  "\n";
                label2.Text += User.users[a].Score.ToString() + "\n";
            }
            label1.Text += User.users[User.users.Count - 1].Name;
            label2.Text += User.users[User.users.Count - 1].Score.ToString();

        }
    }
}
