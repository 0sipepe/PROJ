using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktika1
{
    public partial class Form1 : Form
    {
        struct City
        {
            public string name;
            public string country;
            public int population;
            public int hospitalCount;

            //public City() { }

            public City(string name, string country, int population, int hospitalCount)
            {
                this.name = name;
                this.country = country;
                this.population = population;
                this.hospitalCount = hospitalCount;
            }

        }

        List<City> cities = new List<City>((int)Math.Pow(10, 5));

        string nameFilt = "";
        string countryFilt = "";
        string populationFilt = "";
        string hospitalFilt = "";

        public Form1()
        {

            cities.Add(new City("Ульяновск", "Россия", 123456, 125));
            cities.Add(new City("Москва", "Россия", 12345678, 1257));
            cities.Add(new City("Дубна", "Россия", 12345, 12));
            cities.Add(new City("Нью-Йорк", "США", 12345678, 1252));


            InitializeComponent();

            DataTable data = new DataTable();
            data.Columns.Add("CityName", typeof(string));
            data.Columns.Add("Country", typeof(string));
            data.Columns.Add("Population", typeof(int));
            data.Columns.Add("HospitalCount", typeof(int));


            foreach(var i in cities)
            {
                data.Rows.Add(i.name, i.country, i.population, i.hospitalCount);
            }

            table.DataSource = data;
        }

        

        void UpdateFilter()
        {
            (table.DataSource as DataTable).DefaultView.RowFilter = "";
            foreach (var i in new List<string> { nameFilt, countryFilt, populationFilt, hospitalFilt })
            {
                if (i != "")
                {
                    if ((table.DataSource as DataTable).DefaultView.RowFilter == "") (table.DataSource as DataTable).DefaultView.RowFilter += i;
                    else (table.DataSource as DataTable).DefaultView.RowFilter += " AND " + i;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nameFilt = $"CityName LIKE '%{textBox1.Text}%'";
            UpdateFilter();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            countryFilt = $"Country LIKE '%{textBox2.Text}%'";
            UpdateFilter();
        }

        private void population_ValueChanged(object sender, EventArgs e)
        {
            populationFilt = $"Population > {populationMin.Value} AND Population < {populationMax.Value}";
            UpdateFilter();
        }

        private void Hosp_ValueChanged(object sender, EventArgs e)
        {
            populationFilt = $"HospitalCount > {HospMin.Value} AND HospitalCount < {HospMax.Value}";
            UpdateFilter();
        }
    }
}
