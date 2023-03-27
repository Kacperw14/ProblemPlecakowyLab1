using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemPlecakowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int N = int.Parse(textBox1.Text);
                int seed = int.Parse(textBox2.Text);
                int C = int.Parse(textBox3.Text);
                //string info = "Liczba przedmiotow: " + N.ToString() 
                //            + "\nWybrany seed: " + seed.ToString() 
                //            + "\nDostepna pojemnosc: " + C.ToString();
                Plecak plecak = new Plecak(N, seed, C);
                string info = "\nPlecak przed spakowaniem\n" + plecak.ToString();
                plecak.PackBackpack();
                info += "\nPlecak po spakowaniu:\n" + plecak.ToString();
                MessageBox.Show(info, "Informacje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Nieprawidlowy format danych!", "Informacje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
