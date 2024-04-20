using System;
using System.Windows.Forms;

namespace Coursework.GSTU.Information_and_reference_directory_of_a_travel_company
{
    public partial class Main : Form
    {
        private static Main main;
        public Main()
        {
            InitializeComponent();
            main = this;
        }
        public static void ShowForm() {
            main.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Client().Show();
            Hide();
        }

        private void отелиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Hotel().Show();
            Hide();
        }

        private void турпродуктыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TourProduct().Show();
            Hide();
        }

        private void транспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Transport().Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
            "Продолжить сохранение?",
            "Подтвердите сохранение",
           MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    записьTableAdapter.Update(databaseDataSet.Запись);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void loadData()
        {
            this.записьTableAdapter.Fill(this.databaseDataSet.Запись);
            this.турпродукт1TableAdapter.Fill(this.databaseDataSet2.Турпродукт1);
            this.транспорт1TableAdapter.Fill(this.databaseDataSet1.Транспорт1);
            this.клиентTableAdapter.Fill(this.databaseDataSet1.Клиент);
            this.записьTableAdapter.Fill(this.databaseDataSet.Запись);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    this.записьTableAdapter.FindByClientFIO(this.databaseDataSet.Запись, $"%{textBox1.Text}%");
                }
                else if (radioButton2.Checked)
                {
                    this.записьTableAdapter.FindByHotelName(this.databaseDataSet.Запись, $"%{textBox1.Text}%");
                }
                else if (radioButton3.Checked)
                {
                    this.записьTableAdapter.FindByTourOperator(this.databaseDataSet.Запись, $"%{textBox1.Text}%");
                }
                else if (radioButton4.Checked)
                {
                    this.записьTableAdapter.FindByDateIn(this.databaseDataSet.Запись, dateTimePicker1.Value);
                }
                else if (radioButton5.Checked)
                {
                    this.записьTableAdapter.FindByDateOut(this.databaseDataSet.Запись, dateTimePicker1.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
