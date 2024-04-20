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
    public partial class Transport : Form
    {
        public Transport()
        {
            InitializeComponent();
        }

        private void Transport_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            this.транспортTableAdapter.Fill(this.databaseDataSet.Транспорт);
        }


        private void Transport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.ShowForm();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
             "Продолжить сохранение?",
             "Подтвердите сохранение",
            MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    транспортTableAdapter.Update(databaseDataSet.Транспорт);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
