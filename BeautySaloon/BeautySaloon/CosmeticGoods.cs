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
    public partial class CosmeticGoods : Form
    {
        private static CosmeticGoods Form;
        public static CosmeticGoods GoodsForm
        {
            get
            {
                if (Form == null || Form.IsDisposed)
                {
                    Form = new CosmeticGoods();
                }
                return Form;
            }
        }

        public CosmeticGoods()
        {
            InitializeComponent();
        }

        private void косметические_ТоварыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.косметические_ТоварыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beauty_SaloonDataSet);

        }

        private void косметические_ТоварыBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.косметические_ТоварыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beauty_SaloonDataSet);

        }

        private void косметические_ТоварыBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.косметические_ТоварыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beauty_SaloonDataSet);

        }

        private void CosmeticGoods_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beauty_SaloonDataSet.Косметические_Товары". При необходимости она может быть перемещена или удалена.
            this.косметические_ТоварыTableAdapter.Fill(this.beauty_SaloonDataSet.Косметические_Товары);

        }
    }
}
