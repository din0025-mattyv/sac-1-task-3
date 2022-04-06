using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SofDev_SAC_task_THREE
{
    public partial class Form1 : Form
    {
        //create list where every item is an object in Search
        List<Search> table = new List<Search>();

        BindingSource bindSource = new BindingSource();
        
        //initialise filter variable
        string filter;
        public Form1()
        {
            InitializeComponent();
            loadCSV();
            
            //set data source for the dataGridView
            bindSource.DataSource = table;
            grdvwData.DataSource = bindSource;
            bindSource.ResetBindings(false);

            

        }

        private void cbbxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set filter variable
            filter = cbbxDisplay.Text;
        }

        public void loadCSV()
        {
            //load file and create list
            string filePath = "C:/#DataSources/Task3_Shop_Data.csv";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach(string line in lines)
            {
                List<string> items = line.Split(',').ToList();

                //empty object in Search class
                Search n = new Search();
                //create new objects with the splits from items list
                n.Title = items[0];
                n.Subject = items[1];
                n.Seller = items[2];
                n.Buyer = items[3];
                n.buyPrice = float.Parse(items[4]);
                n.salePrice = items[5];
                n.Rating = items[6];

                table.Add(n);
            }
        }

        public List<Search> FindSearch(string target, string filter)
        {
            List<Search> results = new List<Search>();
            foreach (Search n in table)
            {
                //check filter result first
                if (filter == "Subject")
                {
                    //makes sure search is for incomplete/inexact also
                    if (n.Subject.ToLower().Contains(target.ToLower()))
                    {
                        results.Add(n);
                    }
                }
                if(filter == "Textbook")
                {
                    //makes sure search is for incomplete/inexact also
                    if (n.Title.ToLower().Contains(target.ToLower()))
                    {
                        results.Add(n);
                    }
                }
                //sort rating, not search by rating
                //couldn't get to work :(
                if (filter == "Rating")
                {
                    List<Search> copyRate = table;
                    foreach (Search e in copyRate)
                    {
                        if (e.Rating == "none")
                        {
                            e.Rating = 0.ToString();
                        }
                    }

                    int min = 0;

                    for (int i = 0; i < copyRate.Count() - 1; i++)
                    {
                        min = i; //minimum value changes every runthrough,
                                 //doesn't alter the already sorted values
                        for (int j = i + 1; j < copyRate.Count(); j++)
                        {
                            if (copyRate[j] < copyRate[min])
                            {
                                min = j;
                            }

                        }
                        int pret = copyRate[min]; //double of min's value
                        copyRate[min] = copyRate[i];
                        copyRate[i] = pret;


                    }

                    

                }
            }
            return results;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //sets target parameter as text box text
            List<Search> r = FindSearch(txtSearch.Text, filter);

            //change binding source's data source so output alters
            bindSource.DataSource = r;
            grdvwData.DataSource = bindSource;
            bindSource.ResetBindings(false);
        }
    }
}
