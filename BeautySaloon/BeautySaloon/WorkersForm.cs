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
            toolStripButtonOK.Visible = false;
            персоналBindingSource.Position = 0;
        }

        private void персоналBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.персоналBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.beauty_SaloonDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beauty_SaloonDataSet.Записи". При необходимости она может быть перемещена или удалена.
            this.записиTableAdapter.Fill(this.beauty_SaloonDataSet.Записи);
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

        string GetSelectedFieldName()
        {
            return 
                персоналDataGridView.Columns[персоналDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos = персоналBindingSource.Find(
                    GetSelectedFieldName(), toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
            {
                персоналBindingSource.Position = indexPos;
            }
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                персоналBindingSource.Position = 0;
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                {
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        персоналBindingSource.Filter =
                            GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" + err.Message);
                    }
                }
            }
            else
            {
                персоналBindingSource.Filter = "";
            }
            if (персоналBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                персоналBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }

        }

        string idCurrent = "";

        public string ShowSelectForm(string id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
            {
                return (string)((DataRowView)персоналBindingSource.Current)["Серия_И_Номер_Паспорта"];
            }
            else
            {
                return "";
            }
        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void WorkersForm_Shown(object sender, EventArgs e)
        {
            персоналBindingSource.Position =
                персоналBindingSource.Find("Серия_И_Номер_Паспорта", idCurrent);
        }

        private void персоналDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < записиDataGridView.Rows.Count; i++)
            {
                записиDataGridView.Rows[i].Selected = false;
            }
            if (персоналDataGridView.CurrentCell.ColumnIndex == 0)
            {
                for (int i = 0; i < записиDataGridView.Rows.Count; i++)
                {
                    if (string.Equals(записиDataGridView.Rows[i].Cells[3].Value, персоналDataGridView.CurrentRow.Cells[0].Value))
                    {
                        записиDataGridView.Rows[i].Selected = true;
                    }
                }
            }
        }
    }
}
