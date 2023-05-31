namespace BeautySaloon
{
    partial class WorkersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkersForm));
            System.Windows.Forms.Label фотоLabel;
            this.персоналBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.персоналDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.персоналBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фотоPictureBox = new System.Windows.Forms.PictureBox();
            this.OpenPhotoButton = new System.Windows.Forms.Button();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.персоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beauty_SaloonDataSet = new BeautySaloon.Beauty_SaloonDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.персоналTableAdapter = new BeautySaloon.Beauty_SaloonDataSetTableAdapters.ПерсоналTableAdapter();
            this.tableAdapterManager = new BeautySaloon.Beauty_SaloonDataSetTableAdapters.TableAdapterManager();
            this.Дети = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            фотоLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingNavigator)).BeginInit();
            this.персоналBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.персоналDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фотоPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_SaloonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // персоналBindingNavigator
            // 
            this.персоналBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.персоналBindingNavigator.BindingSource = this.персоналBindingSource;
            this.персоналBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.персоналBindingNavigator.CountItemFormat = "из {0}";
            this.персоналBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.персоналBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.персоналBindingNavigatorSaveItem});
            this.персоналBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.персоналBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.персоналBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.персоналBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.персоналBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.персоналBindingNavigator.Name = "персоналBindingNavigator";
            this.персоналBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.персоналBindingNavigator.Size = new System.Drawing.Size(820, 25);
            this.персоналBindingNavigator.TabIndex = 0;
            this.персоналBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // персоналDataGridView
            // 
            this.персоналDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.персоналDataGridView.AutoGenerateColumns = false;
            this.персоналDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.персоналDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Дети});
            this.персоналDataGridView.DataSource = this.персоналBindingSource;
            this.персоналDataGridView.Location = new System.Drawing.Point(0, 28);
            this.персоналDataGridView.Name = "персоналDataGridView";
            this.персоналDataGridView.Size = new System.Drawing.Size(820, 220);
            this.персоналDataGridView.TabIndex = 1;
            this.персоналDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.персоналDataGridView_CellFormatting);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // персоналBindingNavigatorSaveItem
            // 
            this.персоналBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.персоналBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("персоналBindingNavigatorSaveItem.Image")));
            this.персоналBindingNavigatorSaveItem.Name = "персоналBindingNavigatorSaveItem";
            this.персоналBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.персоналBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.персоналBindingNavigatorSaveItem.Click += new System.EventHandler(this.персоналBindingNavigatorSaveItem_Click);
            // 
            // фотоLabel
            // 
            фотоLabel.AutoSize = true;
            фотоLabel.Location = new System.Drawing.Point(564, 254);
            фотоLabel.Name = "фотоLabel";
            фотоLabel.Size = new System.Drawing.Size(38, 13);
            фотоLabel.TabIndex = 2;
            фотоLabel.Text = "Фото:";
            // 
            // фотоPictureBox
            // 
            this.фотоPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.персоналBindingSource, "Фото", true));
            this.фотоPictureBox.Location = new System.Drawing.Point(608, 254);
            this.фотоPictureBox.Name = "фотоPictureBox";
            this.фотоPictureBox.Size = new System.Drawing.Size(200, 184);
            this.фотоPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.фотоPictureBox.TabIndex = 3;
            this.фотоPictureBox.TabStop = false;
            // 
            // OpenPhotoButton
            // 
            this.OpenPhotoButton.Location = new System.Drawing.Point(502, 270);
            this.OpenPhotoButton.Name = "OpenPhotoButton";
            this.OpenPhotoButton.Size = new System.Drawing.Size(100, 25);
            this.OpenPhotoButton.TabIndex = 4;
            this.OpenPhotoButton.Text = "Открыть фото";
            this.OpenPhotoButton.UseVisualStyleBackColor = true;
            this.OpenPhotoButton.Click += new System.EventHandler(this.OpenPhotoButton_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialogPhoto";
            // 
            // персоналBindingSource
            // 
            this.персоналBindingSource.DataMember = "Персонал";
            this.персоналBindingSource.DataSource = this.beauty_SaloonDataSet;
            // 
            // beauty_SaloonDataSet
            // 
            this.beauty_SaloonDataSet.DataSetName = "Beauty_SaloonDataSet";
            this.beauty_SaloonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Серия_И_Номер_Паспорта";
            this.dataGridViewTextBoxColumn1.HeaderText = "Серия_И_Номер_Паспорта";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn3.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn3.Items.AddRange(new object[] {
            "Менеджер",
            "Сотрудник"});
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Номер_Услуги";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер_Услуги";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // персоналTableAdapter
            // 
            this.персоналTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BeautySaloon.Beauty_SaloonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаписиTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.Косметика_Для_УслугиTableAdapter = null;
            this.tableAdapterManager.Косметические_ТоварыTableAdapter = null;
            this.tableAdapterManager.ПерсоналTableAdapter = this.персоналTableAdapter;
            this.tableAdapterManager.УслугаTableAdapter = null;
            // 
            // Дети
            // 
            this.Дети.DataPropertyName = "Дети";
            this.Дети.HeaderText = "Дети";
            this.Дети.Name = "Дети";
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.OpenPhotoButton);
            this.Controls.Add(фотоLabel);
            this.Controls.Add(this.фотоPictureBox);
            this.Controls.Add(this.персоналDataGridView);
            this.Controls.Add(this.персоналBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkersForm";
            this.Text = "WorkersForm";
            this.Load += new System.EventHandler(this.WorkersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingNavigator)).EndInit();
            this.персоналBindingNavigator.ResumeLayout(false);
            this.персоналBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.персоналDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фотоPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_SaloonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Beauty_SaloonDataSet beauty_SaloonDataSet;
        private System.Windows.Forms.BindingSource персоналBindingSource;
        private Beauty_SaloonDataSetTableAdapters.ПерсоналTableAdapter персоналTableAdapter;
        private Beauty_SaloonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator персоналBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton персоналBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView персоналDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.PictureBox фотоPictureBox;
        private System.Windows.Forms.Button OpenPhotoButton;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Дети;
    }
}