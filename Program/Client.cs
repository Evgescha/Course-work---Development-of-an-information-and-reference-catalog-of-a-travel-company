using System;
using System.Windows.Forms;

namespace Coursework.GSTU.Information_and_reference_directory_of_a_travel_company
{
    public partial class Client : Form
    { 
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.ShowForm();
        }

        private void loadData()
        {
            this.клиентTableAdapter.Fill(this.databaseDataSet.Клиент);
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
               "Продолжить сохранение?",
              "Подтвердите сохранение",
              MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    клиентTableAdapter.Update(databaseDataSet.Клиент);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
