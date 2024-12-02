using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TsvetovoyKod
{
    internal class User
    {
        int score;
        string name;
        internal static List<User> users = new List<User>();

        public string Name
        {
            get { return name; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }       
        public User(string nname, int sscore) 
        {
            name = nname;
            Score = sscore;          
        }
        public static int IsNew(string userName)
        {
            int mem = 0;
            for (int i = 0; i < users.Count; i++) { if (userName == "") mem = 3; }
          
            if (mem == 0) { for (int i = 0; i < users.Count; i++) { if (users[i].Name == userName) mem = 1; } }
          
            if (mem == 0) { for (int i = 0; i < users.Count; i++) { if (users[i].Name != userName) mem = 2; } }
                
            return mem;
        }
        internal static void SortUsers()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = users.Count - 1; j > 0; j--)
                {
                    if (users[j].Score > users[j - 1].Score)
                    {
                        User boob = users[j];
                        users[j] = users[j - 1];
                        users[j - 1] = boob;
                    }
                }
            }
        }
    }


}
