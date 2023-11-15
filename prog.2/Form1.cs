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
    public partial class Form1 : Form
    {
        private SurnamesArray arrays;
        public Form1()
        {
            InitializeComponent();


            string[] customSurnames = new string[] { "Ващенко", "Максименко", "Скрипніков", "Базаров", "Ампілогов" };

            arrays = new SurnamesArray(customSurnames);

            dataGridView1.Columns.Add("SurnameColumn", "Прізвище");

            for (int i = 0; i < customSurnames.Length; i++)
            {
                dataGridView1.Rows.Add(arrays[i]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchLetterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            char searchLetter = char.Parse(SearchLetterTextBox.Text);

            string result = arrays.GetSurnamesStartingWith(searchLetter);
            ResultLabel.Text = result;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = arrays[row.Index].StartsWith(searchLetter.ToString(), StringComparison.OrdinalIgnoreCase);
            }
        }

        private void двовимірніМасивиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
