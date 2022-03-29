//John Fade IV 2307363
//I worked alone on this assignment
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //validates the changes, ends the editing and updates the dataset
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDBDataSet);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'populationDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.populationDBDataSet.City);


        }

        private void cityAscendingButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByAscCity(this.populationDBDataSet.City);
        }

        private void cityDecendingButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByDescCity(this.populationDBDataSet.City);
        }

        private void popAscendingButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByAscPop(this.populationDBDataSet.City);
        }

        private void popDecendingButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByDescPop(this.populationDBDataSet.City);
        }

        //outputs the total, average highest and lowest
        private void cityStatButton_Click(object sender, EventArgs e)
        {
           double total;
            double average;
            string highest;
            string lowest;

            total =(double)this.cityTableAdapter.TotalPopulation();
            average = (double)this.cityTableAdapter.AvgPopulation();
            highest = (string)this.cityTableAdapter.MaxPopulation();
            lowest = (string)this.cityTableAdapter.MinPopulation();

            MessageBox.Show(" TOTAL POPULATION: " + total.ToString() + "/ AVERAGE POPULATION: " + average.ToString() + "/ HIGHEST POPULATION: " + highest.ToString() + "/ LOWEST POPULATION: " + lowest.ToString());
           
        }

        //************Ignore below ***********
      
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void sortCityButton_Click(object sender, EventArgs e)
        {

        }

        private void dataAddButton_Click(object sender, EventArgs e)
        {
            addData(cityAddTextBox.Text, popAddTextBox.Text);
        }
        private void addData(string city, string population)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
