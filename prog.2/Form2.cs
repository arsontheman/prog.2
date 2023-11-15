using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog._2
{
    public partial class Form2 : Form
    {
        private TwoDimensionalArraySolver arraySolver;
        public Form2()
        {
            InitializeComponent();
            arraySolver = new TwoDimensionalArraySolver();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int sum = arraySolver.SumOfElementsWithOddIndices();
            labelSumResult.Text = $"Сума елементів з обидва непарними індексами: {sum}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
