namespace BeautySaloon
{
    partial class CosmeticGoods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CosmeticGoods));
            System.Windows.Forms.Label название_ТовараLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label составLabel;
            this.beauty_SaloonDataSet = new BeautySaloon.Beauty_SaloonDataSet();
            this.косметические_ТоварыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.косметические_ТоварыTableAdapter = new BeautySaloon.Beauty_SaloonDataSetTableAdapters.Косметические_ТоварыTableAdapter();
            this.tableAdapterManager = new BeautySaloon.Beauty_SaloonDataSetTableAdapters.TableAdapterManager();
            this.косметические_ТоварыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.косметические_ТоварыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.название_ТовараTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.составTextBox = new System.Windows.Forms.TextBox();
            название_ТовараLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            составLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_SaloonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.косметические_ТоварыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.косметические_ТоварыBindingNavigator)).BeginInit();
            this.косметические_ТоварыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // beauty_SaloonDataSet
            // 
            this.beauty_SaloonDataSet.DataSetName = "Beauty_SaloonDataSet";
            this.beauty_SaloonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // косметические_ТоварыBindingSource
            // 
            this.косметические_ТоварыBindingSource.DataMember = "Косметические Товары";
            this.косметические_ТоварыBindingSource.DataSource = this.beauty_SaloonDataSet;
            // 
            // косметические_ТоварыTableAdapter
            // 
            this.косметические_ТоварыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BeautySaloon.Beauty_SaloonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаписиTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.Косметика_Для_УслугиTableAdapter = null;
            this.tableAdapterManager.Косметические_ТоварыTableAdapter = this.косметические_ТоварыTableAdapter;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            this.tableAdapterManager.УслугаTableAdapter = null;
            // 
            // косметические_ТоварыBindingNavigator
            // 
            this.косметические_ТоварыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.косметические_ТоварыBindingNavigator.BindingSource = this.косметические_ТоварыBindingSource;
            this.косметические_ТоварыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.косметические_ТоварыBindingNavigator.CountItemFormat = "из {0}";
            this.косметические_ТоварыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.косметические_ТоварыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.косметические_ТоварыBindingNavigatorSaveItem});
            this.косметические_ТоварыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.косметические_ТоварыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.косметические_ТоварыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.косметические_ТоварыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.косметические_ТоварыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.косметические_ТоварыBindingNavigator.Name = "косметические_ТоварыBindingNavigator";
            this.косметические_ТоварыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.косметические_ТоварыBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.косметические_ТоварыBindingNavigator.TabIndex = 0;
            this.косметические_ТоварыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // косметические_ТоварыBindingNavigatorSaveItem
            // 
            this.косметические_ТоварыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.косметические_ТоварыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("косметические_ТоварыBindingNavigatorSaveItem.Image")));
            this.косметические_ТоварыBindingNavigatorSaveItem.Name = "косметические_ТоварыBindingNavigatorSaveItem";
            this.косметические_ТоварыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.косметические_ТоварыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.косметические_ТоварыBindingNavigatorSaveItem.Click += new System.EventHandler(this.косметические_ТоварыBindingNavigatorSaveItem_Click_2);
            // 
            // название_ТовараLabel
            // 
            название_ТовараLabel.AutoSize = true;
            название_ТовараLabel.Location = new System.Drawing.Point(12, 37);
            название_ТовараLabel.Name = "название_ТовараLabel";
            название_ТовараLabel.Size = new System.Drawing.Size(100, 13);
            название_ТовараLabel.TabIndex = 1;
            название_ТовараLabel.Text = "Название Товара:";
            // 
            // название_ТовараTextBox
            // 
            this.название_ТовараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.косметические_ТоварыBindingSource, "Название_Товара", true));
            this.название_ТовараTextBox.Location = new System.Drawing.Point(118, 34);
            this.название_ТовараTextBox.Name = "название_ТовараTextBox";
            this.название_ТовараTextBox.Size = new System.Drawing.Size(100, 20);
            this.название_ТовараTextBox.TabIndex = 2;
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(12, 63);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(36, 13);
            ценаLabel.TabIndex = 3;
            ценаLabel.Text = "Цена:";
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.косметические_ТоварыBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(118, 60);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(100, 20);
            this.ценаTextBox.TabIndex = 4;
            // 
            // составLabel
            // 
            составLabel.AutoSize = true;
            составLabel.Location = new System.Drawing.Point(12, 89);
            составLabel.Name = "составLabel";
            составLabel.Size = new System.Drawing.Size(46, 13);
            составLabel.TabIndex = 5;
            составLabel.Text = "Состав:";
            // 
            // составTextBox
            // 
            this.составTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.косметические_ТоварыBindingSource, "Состав", true));
            this.составTextBox.Location = new System.Drawing.Point(118, 86);
            this.составTextBox.Name = "составTextBox";
            this.составTextBox.Size = new System.Drawing.Size(100, 20);
            this.составTextBox.TabIndex = 6;
            // 
            // CosmeticGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(название_ТовараLabel);
            this.Controls.Add(this.название_ТовараTextBox);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(составLabel);
            this.Controls.Add(this.составTextBox);
            this.Controls.Add(this.косметические_ТоварыBindingNavigator);
            this.Name = "CosmeticGoods";
            this.Text = "CosmeticGoods";
            this.Load += new System.EventHandler(this.CosmeticGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beauty_SaloonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.косметические_ТоварыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.косметические_ТоварыBindingNavigator)).EndInit();
            this.косметические_ТоварыBindingNavigator.ResumeLayout(false);
            this.косметические_ТоварыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Beauty_SaloonDataSet beauty_SaloonDataSet;
        private System.Windows.Forms.BindingSource косметические_ТоварыBindingSource;
        private Beauty_SaloonDataSetTableAdapters.Косметические_ТоварыTableAdapter косметические_ТоварыTableAdapter;
        private Beauty_SaloonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator косметические_ТоварыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton косметические_ТоварыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox название_ТовараTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox составTextBox;
    }
}