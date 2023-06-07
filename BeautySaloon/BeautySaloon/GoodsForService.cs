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
    public partial class GoodsForService : Form
    {
        private static GoodsForService Form;
        public static GoodsForService ServiceGoodsForm
        {
            get
            {
                if (Form == null || Form.IsDisposed)
                {
                    Form = new GoodsForService();
                }
                return Form;
            }
        }

        public GoodsForService()
        {
            InitializeComponent();
        }

        private void косметика_Для_УслугиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.косметика_Для_УслугиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beauty_SaloonDataSet);

        }

        private void GoodsForService_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beauty_SaloonDataSet.Косметика_Для_Услуги". При необходимости она может быть перемещена или удалена.
            this.косметика_Для_УслугиTableAdapter.Fill(this.beauty_SaloonDataSet.Косметика_Для_Услуги);

        }
    }
}
