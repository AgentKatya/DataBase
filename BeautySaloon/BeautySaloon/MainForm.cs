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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("You want to close program?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(С) ТУСУР, КСУП, Круглов Илья Владимирович, группа 571-1, 2023", "About Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicesForm.ServiceForm.Show();
        }

        private void workersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkersForm.WorkerForm.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientsForm.ClientForm.Show();
        }

        private void косметикаДляУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsForService.ServiceGoodsForm.Show();
        }

        private void косметическиеТоварыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CosmeticGoods.GoodsForm.Show();
        }
    }
}
