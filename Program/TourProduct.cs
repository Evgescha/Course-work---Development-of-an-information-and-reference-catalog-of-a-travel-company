using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework.GSTU.Information_and_reference_directory_of_a_travel_company
{
    public partial class TourProduct : Form
    {
        public TourProduct()
        {
            InitializeComponent();
        }

        private void TourProduct_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e){}

        private void loadData()
        {
            this.отельTableAdapter.Fill(this.databaseDataSet.Отель);
            this.турпродуктTableAdapter.Fill(this.databaseDataSet.Турпродукт);
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
               "Продолжить сохранение?",
               "Подтвердите сохранение",
              MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    турпродуктTableAdapter.Update(databaseDataSet.Турпродукт);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void TourProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.ShowForm();
        }
    }
}
