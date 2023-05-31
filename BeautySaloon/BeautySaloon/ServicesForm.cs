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
    public partial class ServicesForm : Form
    {
        private static ServicesForm Form;
        public static ServicesForm ServiceForm
        {
            get
            {
                if(Form == null || Form.IsDisposed)
                {
                    Form = new ServicesForm();
                }
                return Form;
            }
        }

        public ServicesForm()
        {
            InitializeComponent();
        }

        private void услугаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.услугаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.beauty_SaloonDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void услугаBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.услугаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.beauty_SaloonDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beauty_SaloonDataSet.Услуга". При необходимости она может быть перемещена или удалена.
            this.услугаTableAdapter.Fill(this.beauty_SaloonDataSet.Услуга);

        }
    }
}
