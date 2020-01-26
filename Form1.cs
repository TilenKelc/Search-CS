using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iskanje
{
    public partial class Form1 : Form
    {
        Tab tab = new Tab();

        public Form1()
        {
            InitializeComponent();
            textBox.Text = tab.ToString();
        }

        private void vsebujeButton_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(searchText.Text);
            bool check = tab.Vsebuje(num);
            MessageBox.Show(check.ToString());
        }

        private void quickSortButton_Click(object sender, EventArgs e)
        {
            tab.quickSort();
            textBox.Text = tab.ToString();
        }

        private void vsotaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vsota: " + tab.Vsota().ToString());
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Min: " + tab.Min().ToString());
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Max: " + tab.Max().ToString());
        }

        private void povprecjeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Povprečje: " + tab.Povprecje().ToString());
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            tab.Dodaj(Convert.ToInt32(searchText.Text));
            textBox.Text = tab.ToString();

        }

        private void binarySearch_Click(object sender, EventArgs e)
        {
            bool check = tab.VsebujeBinarno(Convert.ToInt32(searchText.Text));
            MessageBox.Show(check.ToString());
        }

        private void bubbleSortButton_Click(object sender, EventArgs e)
        {
            tab.quickSort();
            textBox.Text = tab.ToString();
        }

        private void urediButton_Click(object sender, EventArgs e)
        {
            tab.Uredi();
            textBox.Text = tab.ToString();
        }

        private void insertionSortButton_Click(object sender, EventArgs e)
        {
            tab.DodajInUredi(Convert.ToInt32(searchText.Text));
            textBox.Text = tab.ToString();
        }
    }
}
