using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloon
{
    public partial class SQLForm : Form
    {
        private static SQLForm Form;
        public static SQLForm QueryForm
        {
            get
            {
                if (Form == null || Form.IsDisposed)
                {
                    Form = new SQLForm();
                }
                return Form;
            }
        }

        public SQLForm()
        {
            InitializeComponent();
        }

        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект connection класса SqlConnection для соединения с БД
            //CafeConnectionString – строка описания соединения с источником данных
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.Beauty_SaloonConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
             DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        private void radioButtonWorkers_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Персонал"); 
        }

        private void radioButtonServices_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT Номер_Услуги, Название, Цена AS [Текущая цена], '20%' AS [Скидка], (1-0.2)*Цена AS [Итоговая цена] FROM Услуга");
        }

        private void radioButtonRecords_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT Записи.ID_Записи, Клиент.ФИО AS [ФИО Клиента], Персонал.ФИО+' '+Персонал.Должность AS [Сотрудник] FROM Записи, Клиент, Персонал WHERE Записи.Серия_И_Номер_Паспорта=Персонал.Серия_И_Номер_Паспорта AND Клиент.Номер_Телефона=Записи.Номер_Телефона");
        }
        private void buttonF_select_Click(object sender, EventArgs e)
        {
            string sqlSelect = "";
            if (String.IsNullOrEmpty(textBoxWorker.Text))
            {
                sqlSelect = "SELECT * FROM Персонал";
            }
            if(!String.IsNullOrEmpty(textBoxWorker.Text) && !checkBoxMore.Checked)
            {
                sqlSelect = $"SELECT p.ФИО, p.Должность, p.Номер_Услуги, s.Название, s.Цена FROM Персонал p, Услуга s WHERE p.Номер_Услуги=s.Номер_Услуги AND p.ФИО LIKE '{textBoxWorker.Text}%' GROUP BY p.ФИО, p.Должность, p.Номер_Услуги, s.Название, s.Цена";
            }
            if(!String.IsNullOrEmpty(textBoxWorker.Text) && checkBoxMore.Checked)
            {
                sqlSelect = $"SELECT p.ФИО, p.Должность, p.Номер_Услуги, s.Название, s.Цена FROM Персонал p, Услуга s WHERE p.Номер_Услуги=s.Номер_Услуги AND p.ФИО LIKE '{textBoxWorker.Text}%' GROUP BY p.ФИО, p.Должность, p.Номер_Услуги, s.Название, s.Цена HAVING s.Цена > {textBoxMore.Text} ORDER BY s.Цена";
            }
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Beauty_SaloonConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("Обязательно укажите номер необходимой услуги",
               "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = "";
            if (radioButtonCorrelated.Checked)
            {
                sqlSelect = $"SELECT Услуга.Номер_Услуги, Услуга.Цена, Услуга.Название, (SELECT DISTINCT ФИО+' '+Должность FROM Персонал, Услуга WHERE Персонал.Номер_Услуги={Int32.Parse(textBoxNumber.Text)}) AS [Сотрудник] FROM Услуга WHERE Услуга.Номер_Услуги={Int32.Parse(textBoxNumber.Text)}";
            }
            else
            if (radioButtonNoCorrelated.Checked)
            {
                sqlSelect = $"SELECT * FROM Услуга WHERE Услуга.Номер_Услуги={Int32.Parse(textBoxNumber.Text)}";
            }
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Beauty_SaloonConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;
        }

        void Insert()
        {
            string sqlInsert = $"INSERT INTO Услуга (Номер_Услуги, Цена, Название) VALUES ({Int32.Parse(textBoxServiceNumber.Text)}, {Decimal.Parse(textBoxServicePrice.Text)}, '{textBoxServiceName.Text}')";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Beauty_SaloonConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.ExecuteNonQuery();
            connection.Close();
            buttonSelectServices_Click(this, EventArgs.Empty);
        }

        void Update()
        {
            string sqlUpdate = $"UPDATE Услуга SET Цена={Decimal.Parse(textBoxServicePrice.Text)}, Название='{textBoxServiceName.Text}' WHERE Номер_Услуги={Int32.Parse(textBoxServiceNumber.Text)}";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Beauty_SaloonConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlUpdate;
            command.ExecuteNonQuery();
            connection.Close();
            buttonSelectServices_Click(this, EventArgs.Empty);
        }

        void Delete()
        {
            string sqlDelete = $"DELETE FROM Услуга WHERE Номер_Услуги={Int32.Parse(textBoxServiceNumber.Text)}";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Beauty_SaloonConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.ExecuteNonQuery();
            connection.Close();
            buttonSelectServices_Click(this, EventArgs.Empty);
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert.Checked)
                Insert();
            else
            if (radioButtonUpdate.Checked)
                Update();
            else
            if (radioButtonDelete.Checked)
                Delete();
            else
            {
                MessageBox.Show("Вы не выбрали действие", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSelectServices_Click(object sender, EventArgs e)
        {
            dataGridViewServices.DataSource = FillDataGridView("SELECT * FROM Услуга");
        }
    }
}
