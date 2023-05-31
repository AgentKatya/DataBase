namespace BeautySaloon
{
    partial class ClientsForm
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
            System.Windows.Forms.Label номер_ТелефонаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.клиентBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beauty_SaloonDataSet = new BeautySaloon.Beauty_SaloonDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.клиентBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.номер_ТелефонаTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.записиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.записиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.записиBindingNavigatorSaveButton = new System.Windows.Forms.ToolStripButton();
            this.записиDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonWorker = new System.Windows.Forms.Button();
            this.клиентTableAdapter = new BeautySaloon.Beauty_SaloonDataSetTableAdapters.КлиентTableAdapter();
            this.tableAdapterManager = new BeautySaloon.Beauty_SaloonDataSetTableAdapters.TableAdapterManager();
            this.записиTableAdapter = new BeautySaloon.Beauty_SaloonDataSetTableAdapters.ЗаписиTableAdapter();
            this.персоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.персоналTableAdapter = new BeautySaloon.Beauty_SaloonDataSetTableAdapters.ПерсоналTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Серия_И_Номер_Паспорта = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.О_Сотруднике = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            номер_ТелефонаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingNavigator)).BeginInit();
            this.клиентBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_SaloonDataSet)).BeginInit();
            this.AppointmentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.записиBindingNavigator)).BeginInit();
            this.записиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.записиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.записиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_ТелефонаLabel
            // 
            номер_ТелефонаLabel.AutoSize = true;
            номер_ТелефонаLabel.Location = new System.Drawing.Point(12, 37);
            номер_ТелефонаLabel.Name = "номер_ТелефонаLabel";
            номер_ТелефонаLabel.Size = new System.Drawing.Size(98, 13);
            номер_ТелефонаLabel.TabIndex = 1;
            номер_ТелефонаLabel.Text = "Номер Телефона:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(12, 63);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // клиентBindingNavigator
            // 
            this.клиентBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.клиентBindingNavigator.BindingSource = this.клиентBindingSource;
            this.клиентBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.клиентBindingNavigator.CountItemFormat = "из {0}";
            this.клиентBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.клиентBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.клиентBindingNavigatorSaveItem});
            this.клиентBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.клиентBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.клиентBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.клиентBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.клиентBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.клиентBindingNavigator.Name = "клиентBindingNavigator";
            this.клиентBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.клиентBindingNavigator.Size = new System.Drawing.Size(808, 25);
            this.клиентBindingNavigator.TabIndex = 0;
            this.клиентBindingNavigator.Text = "bindingNavigator1";
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
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.beauty_SaloonDataSet;
            // 
            // beauty_SaloonDataSet
            // 
            this.beauty_SaloonDataSet.DataSetName = "Beauty_SaloonDataSet";
            this.beauty_SaloonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // клиентBindingNavigatorSaveItem
            // 
            this.клиентBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.клиентBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("клиентBindingNavigatorSaveItem.Image")));
            this.клиентBindingNavigatorSaveItem.Name = "клиентBindingNavigatorSaveItem";
            this.клиентBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.клиентBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.клиентBindingNavigatorSaveItem.Click += new System.EventHandler(this.клиентBindingNavigatorSaveItem_Click_1);
            // 
            // номер_ТелефонаTextBox
            // 
            this.номер_ТелефонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Номер_Телефона", true));
            this.номер_ТелефонаTextBox.Location = new System.Drawing.Point(116, 34);
            this.номер_ТелефонаTextBox.Name = "номер_ТелефонаTextBox";
            this.номер_ТелефонаTextBox.Size = new System.Drawing.Size(100, 20);
            this.номер_ТелефонаTextBox.TabIndex = 2;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(116, 60);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(100, 20);
            this.фИОTextBox.TabIndex = 4;
            // 
            // AppointmentsGroupBox
            // 
            this.AppointmentsGroupBox.Controls.Add(this.записиBindingNavigator);
            this.AppointmentsGroupBox.Controls.Add(this.записиDataGridView);
            this.AppointmentsGroupBox.Location = new System.Drawing.Point(13, 80);
            this.AppointmentsGroupBox.Name = "AppointmentsGroupBox";
            this.AppointmentsGroupBox.Size = new System.Drawing.Size(775, 358);
            this.AppointmentsGroupBox.TabIndex = 5;
            this.AppointmentsGroupBox.TabStop = false;
            this.AppointmentsGroupBox.Text = "Записи";
            // 
            // записиBindingNavigator
            // 
            this.записиBindingNavigator.AddNewItem = this.toolStripButton1;
            this.записиBindingNavigator.BindingSource = this.записиBindingSource;
            this.записиBindingNavigator.CountItem = this.toolStripLabel1;
            this.записиBindingNavigator.CountItemFormat = "из {0}";
            this.записиBindingNavigator.DeleteItem = this.toolStripButton2;
            this.записиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.записиBindingNavigatorSaveButton});
            this.записиBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.записиBindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.записиBindingNavigator.MoveLastItem = this.toolStripButton6;
            this.записиBindingNavigator.MoveNextItem = this.toolStripButton5;
            this.записиBindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.записиBindingNavigator.Name = "записиBindingNavigator";
            this.записиBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.записиBindingNavigator.Size = new System.Drawing.Size(769, 25);
            this.записиBindingNavigator.TabIndex = 1;
            this.записиBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Добавить";
            // 
            // записиBindingSource
            // 
            this.записиBindingSource.DataMember = "FK_Записи_Клиент";
            this.записиBindingSource.DataSource = this.клиентBindingSource;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel1.Text = "из {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // записиBindingNavigatorSaveButton
            // 
            this.записиBindingNavigatorSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.записиBindingNavigatorSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("записиBindingNavigatorSaveButton.Image")));
            this.записиBindingNavigatorSaveButton.Name = "записиBindingNavigatorSaveButton";
            this.записиBindingNavigatorSaveButton.Size = new System.Drawing.Size(23, 22);
            this.записиBindingNavigatorSaveButton.Text = "Сохранить данные";
            this.записиBindingNavigatorSaveButton.Click += new System.EventHandler(this.записиBindingNavigatorSaveButton_Click);
            // 
            // записиDataGridView
            // 
            this.записиDataGridView.AutoGenerateColumns = false;
            this.записиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.записиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Серия_И_Номер_Паспорта,
            this.О_Сотруднике,
            this.dataGridViewTextBoxColumn5});
            this.записиDataGridView.DataSource = this.записиBindingSource;
            this.записиDataGridView.Location = new System.Drawing.Point(6, 44);
            this.записиDataGridView.Name = "записиDataGridView";
            this.записиDataGridView.Size = new System.Drawing.Size(763, 308);
            this.записиDataGridView.TabIndex = 0;
            this.записиDataGridView.Click += new System.EventHandler(this.записиDataGridView_Click);
            // 
            // buttonWorker
            // 
            this.buttonWorker.Image = global::BeautySaloon.Properties.Resources.Worker_32x32;
            this.buttonWorker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWorker.Location = new System.Drawing.Point(362, 49);
            this.buttonWorker.Name = "buttonWorker";
            this.buttonWorker.Size = new System.Drawing.Size(125, 30);
            this.buttonWorker.TabIndex = 6;
            this.buttonWorker.Text = "Сотрудник";
            this.buttonWorker.UseVisualStyleBackColor = true;
            this.buttonWorker.Click += new System.EventHandler(this.buttonWorker_Click);
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BeautySaloon.Beauty_SaloonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаписиTableAdapter = this.записиTableAdapter;
            this.tableAdapterManager.КлиентTableAdapter = this.клиентTableAdapter;
            this.tableAdapterManager.Косметика_Для_УслугиTableAdapter = null;
            this.tableAdapterManager.Косметические_ТоварыTableAdapter = null;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            this.tableAdapterManager.УслугаTableAdapter = null;
            // 
            // записиTableAdapter
            // 
            this.записиTableAdapter.ClearBeforeFill = true;
            // 
            // персоналBindingSource
            // 
            this.персоналBindingSource.DataMember = "Персонал";
            this.персоналBindingSource.DataSource = this.beauty_SaloonDataSet;
            // 
            // персоналTableAdapter
            // 
            this.персоналTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Записи";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Записи";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Время";
            this.dataGridViewTextBoxColumn3.HeaderText = "Время";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Серия_И_Номер_Паспорта
            // 
            this.Серия_И_Номер_Паспорта.DataPropertyName = "Серия_И_Номер_Паспорта";
            this.Серия_И_Номер_Паспорта.HeaderText = "Серия_И_Номер_Паспорта";
            this.Серия_И_Номер_Паспорта.Name = "Серия_И_Номер_Паспорта";
            this.Серия_И_Номер_Паспорта.Width = 150;
            // 
            // О_Сотруднике
            // 
            this.О_Сотруднике.DataPropertyName = "О_Сотруднике";
            this.О_Сотруднике.HeaderText = "О_Сотруднике";
            this.О_Сотруднике.Name = "О_Сотруднике";
            this.О_Сотруднике.ReadOnly = true;
            this.О_Сотруднике.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.О_Сотруднике.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.О_Сотруднике.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Номер_Телефона";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер_Телефона";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.buttonWorker);
            this.Controls.Add(this.AppointmentsGroupBox);
            this.Controls.Add(номер_ТелефонаLabel);
            this.Controls.Add(this.номер_ТелефонаTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(this.клиентBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientsForm";
            this.Text = "ClientsForm";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingNavigator)).EndInit();
            this.клиентBindingNavigator.ResumeLayout(false);
            this.клиентBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_SaloonDataSet)).EndInit();
            this.AppointmentsGroupBox.ResumeLayout(false);
            this.AppointmentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.записиBindingNavigator)).EndInit();
            this.записиBindingNavigator.ResumeLayout(false);
            this.записиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.записиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.записиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Beauty_SaloonDataSet beauty_SaloonDataSet;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private Beauty_SaloonDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private Beauty_SaloonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator клиентBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton клиентBindingNavigatorSaveItem;
        private Beauty_SaloonDataSetTableAdapters.ЗаписиTableAdapter записиTableAdapter;
        private System.Windows.Forms.TextBox номер_ТелефонаTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.GroupBox AppointmentsGroupBox;
        private System.Windows.Forms.BindingSource записиBindingSource;
        private System.Windows.Forms.DataGridView записиDataGridView;
        private System.Windows.Forms.BindingNavigator записиBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton записиBindingNavigatorSaveButton;
        private System.Windows.Forms.Button buttonWorker;
        private System.Windows.Forms.BindingSource персоналBindingSource;
        private Beauty_SaloonDataSetTableAdapters.ПерсоналTableAdapter персоналTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Серия_И_Номер_Паспорта;
        private System.Windows.Forms.DataGridViewButtonColumn О_Сотруднике;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}