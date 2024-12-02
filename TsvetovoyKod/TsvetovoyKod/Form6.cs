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
    public partial class Form6 : Form
    {
        internal static  User currentUser = null;
        bool showForm;
        public Form6()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                if (this.Controls[i] is Label lb) { lb.BackColor = Color.FromArgb(0, 0, 0, 0); }
                if (this.Controls[i] is Button bt) { bt.BackColor = Color.Plum; }
            }
            btnStartLevels.BackColor = Color.Plum;
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            Form4 Instruction = new Form4();
            Instruction.Show();
        }

        private void btnToResultsScreen_Click(object sender, EventArgs e)
        {
            User.SortUsers();
            Form3 ResultsScreen = new Form3();
            this.Visible = false;
            ResultsScreen.Show();
        }

        private void Form6_Load(object sender, EventArgs e) => FileHandler.Start();

        private void btnStartLevels_Click(object sender, EventArgs e)
        {
            switch (User.IsNew(tbUser.Text))
            {
                case 1:
                    DialogResult dr = MessageBox.Show("Вы уже играли в эту игру?", "Вопрос", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        foreach (User usir in User.users)
                        {
                            if (usir.Name == tbUser.Text)
                            {
                                currentUser = usir;
                                break;
                            }
                        }
                        showForm = true;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Такое имя пользователя уже существует", "Ошибка");
                        showForm = false;
                        break;
                    }
                case 2:
                    User user = new User(tbUser.Text, 0);
                    currentUser = user;
                    User.users.Add(user);
                    showForm = true;
                    break;
                case 3:
                    User user1 = new User("user", 0);
                    currentUser = user1;
                    showForm = true;
                    break;
            }
            if (showForm)
            {
                Form1 DrawScreen = new Form1();
                this.Visible = false;
                DrawScreen.Show();
            }
        }
    }
}
