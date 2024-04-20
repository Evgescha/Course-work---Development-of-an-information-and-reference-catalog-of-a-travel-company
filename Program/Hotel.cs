using System;
using System.Windows.Forms;

namespace Coursework.GSTU.Information_and_reference_directory_of_a_travel_company
{
    public partial class Hotel : Form
    {
        public Hotel()
        {
            InitializeComponent();
        }

        private void Hotel_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void Hotel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.ShowForm();
        }

        private void loadData()
        {
            this.отельTableAdapter.Fill(this.databaseDataSet.Отель);
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
               "Продолжить сохранение?",
               "Подтвердите сохранение",
              MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    отельTableAdapter.Update(databaseDataSet.Отель);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
