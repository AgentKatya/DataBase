using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloon
{
    public partial class ClientsForm : Form
    {
        private static ClientsForm Form;
        public static ClientsForm ClientForm
        {
            get
            {
                if (Form == null || Form.IsDisposed)
                {
                    Form = new ClientsForm();
                }
                return Form;
            }
        }

        public ClientsForm()
        {
            InitializeComponent();
            
        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.клиентBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.beauty_SaloonDataSet);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void клиентBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.клиентBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.beauty_SaloonDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beauty_SaloonDataSet.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.beauty_SaloonDataSet.Персонал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beauty_SaloonDataSet.Записи". При необходимости она может быть перемещена или удалена.
            this.записиTableAdapter.Fill(this.beauty_SaloonDataSet.Записи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beauty_SaloonDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.beauty_SaloonDataSet.Клиент);

        }

        private void записиBindingNavigatorSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.записиBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.beauty_SaloonDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonWorker_Click(object sender, EventArgs e)
        {
            string id = "";
            if(((DataRowView)записиBindingSource.Current)["Серия_И_Номер_Паспорта"].ToString() != "")
            {
                id =
                    (string)((DataRowView)записиBindingSource.Current)["Серия_И_Номер_Паспорта"];
            }
            id = WorkersForm.WorkerForm.ShowSelectForm(id);
            if (id != "")
            {
                ((DataRowView)записиBindingSource.Current)["Серия_И_Номер_Паспорта"] = id;
                записиBindingSource.EndEdit();
            }
        }

        private void записиDataGridView_Click(object sender, EventArgs e)
        {
            if (записиDataGridView.CurrentCell.ColumnIndex == 4)
            {
                string id = "";
                id =
                    (string)((DataRowView)записиBindingSource.Current)["Серия_И_Номер_Паспорта"];
                WorkersForm.WorkerForm.ShowSelectForm(id);
            }
        }
    }
}
