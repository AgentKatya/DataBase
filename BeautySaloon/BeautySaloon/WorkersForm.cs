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
    public partial class WorkersForm : Form
    {
        private static WorkersForm Form;
        public static WorkersForm WorkerForm
        {
            get
            {
                if(Form == null || Form.IsDisposed)
                {
                    Form = new WorkersForm();
                }
                return Form;
            }
        }

        public WorkersForm()
        {
            InitializeComponent();
        }

        private void персоналBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.персоналBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beauty_SaloonDataSet);

        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beauty_SaloonDataSet.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.beauty_SaloonDataSet.Персонал);

        }

        private void OpenPhotoButton_Click(object sender, EventArgs e)
        {
            string fileImage = "";
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                try
                {
                    фотоPictureBox.Image = new
                   Bitmap(openFileDialogPhoto.FileName);
                }
                catch
                {
                    MessageBox.Show("Выбран не тот формат файла", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                fileImage = "";
            }
        }

        private void персоналDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((персоналDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value == null) || 
                (персоналDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value.ToString() == ""))
            {
                e.CellStyle.BackColor = Color.LightPink;
            }
            else
            {
                if
               (персоналDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value.ToString() == "Менеджер")
                {
                    e.CellStyle.BackColor = Color.SkyBlue;
                }
                else
                {
                    e.CellStyle.BackColor = Color.AliceBlue;
                }
            }

        }
    }
}
