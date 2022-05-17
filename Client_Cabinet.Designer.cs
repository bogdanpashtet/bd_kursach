
namespace RZ
{
    partial class Client_Cabinet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_Cabinet));
            this.login_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rZ_dbDataSet = new RZ.RZ_dbDataSet();
            this.t_ctionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_ctionTableAdapter = new RZ.RZ_dbDataSetTableAdapters.t_ctionTableAdapter();
            this.tableAdapterManager = new RZ.RZ_dbDataSetTableAdapters.TableAdapterManager();
            this.t_ctionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.t_ctionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.product_view_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buy_button = new System.Windows.Forms.Button();
            this.buy_product_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rate_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rate_seller_button = new System.Windows.Forms.Button();
            this.rate_seller_id_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.complaint_id_textBox = new System.Windows.Forms.TextBox();
            this.complaint_button = new System.Windows.Forms.Button();
            this.complaint_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.on_main_page_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rZ_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ctionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ctionBindingNavigator)).BeginInit();
            this.t_ctionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(167, 11);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(64, 25);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.login_label);
            this.panel1.Location = new System.Drawing.Point(1092, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 49);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вы вошли как:";
            // 
            // rZ_dbDataSet
            // 
            this.rZ_dbDataSet.DataSetName = "RZ_dbDataSet";
            this.rZ_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_ctionBindingSource
            // 
            this.t_ctionBindingSource.DataMember = "t_ction";
            this.t_ctionBindingSource.DataSource = this.rZ_dbDataSet;
            // 
            // t_ctionTableAdapter
            // 
            this.t_ctionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._transactionTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.ComplaintTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.RatingTableAdapter = null;
            this.tableAdapterManager.SellerTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RZ.RZ_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_ctionBindingNavigator
            // 
            this.t_ctionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_ctionBindingNavigator.BindingSource = this.t_ctionBindingSource;
            this.t_ctionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_ctionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_ctionBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.t_ctionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_ctionBindingNavigatorSaveItem});
            this.t_ctionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_ctionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_ctionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_ctionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_ctionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_ctionBindingNavigator.Name = "t_ctionBindingNavigator";
            this.t_ctionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_ctionBindingNavigator.Size = new System.Drawing.Size(1478, 27);
            this.t_ctionBindingNavigator.TabIndex = 2;
            this.t_ctionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // t_ctionBindingNavigatorSaveItem
            // 
            this.t_ctionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_ctionBindingNavigatorSaveItem.Enabled = false;
            this.t_ctionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_ctionBindingNavigatorSaveItem.Image")));
            this.t_ctionBindingNavigatorSaveItem.Name = "t_ctionBindingNavigatorSaveItem";
            this.t_ctionBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.t_ctionBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(838, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(633, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(835, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ваши покупки:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 123);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(734, 150);
            this.dataGridView2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Каталог товаров:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Сортировать по ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.product_view_button);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(31, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 110);
            this.panel2.TabIndex = 8;
            // 
            // product_view_button
            // 
            this.product_view_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_view_button.Location = new System.Drawing.Point(119, 55);
            this.product_view_button.Name = "product_view_button";
            this.product_view_button.Size = new System.Drawing.Size(176, 45);
            this.product_view_button.TabIndex = 12;
            this.product_view_button.Text = "Применить";
            this.product_view_button.UseVisualStyleBackColor = true;
            this.product_view_button.Click += new System.EventHandler(this.product_view_button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "умолчанию",
            "продавцу",
            "категории",
            "популярности"});
            this.comboBox1.Location = new System.Drawing.Point(185, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 33);
            this.comboBox1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.buy_button);
            this.panel3.Controls.Add(this.buy_product_textBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(31, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 123);
            this.panel3.TabIndex = 9;
            // 
            // buy_button
            // 
            this.buy_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buy_button.Location = new System.Drawing.Point(119, 60);
            this.buy_button.Name = "buy_button";
            this.buy_button.Size = new System.Drawing.Size(176, 45);
            this.buy_button.TabIndex = 11;
            this.buy_button.Text = "Купить";
            this.buy_button.UseVisualStyleBackColor = true;
            this.buy_button.Click += new System.EventHandler(this.buy_button_Click);
            // 
            // buy_product_textBox
            // 
            this.buy_product_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buy_product_textBox.Location = new System.Drawing.Point(276, 21);
            this.buy_product_textBox.Multiline = true;
            this.buy_product_textBox.Name = "buy_product_textBox";
            this.buy_product_textBox.Size = new System.Drawing.Size(98, 33);
            this.buy_product_textBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Купить товар с ID: ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.rate_textBox);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.rate_seller_button);
            this.panel4.Controls.Add(this.rate_seller_id_textBox);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(31, 543);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(404, 152);
            this.panel4.TabIndex = 12;
            // 
            // rate_textBox
            // 
            this.rate_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rate_textBox.Location = new System.Drawing.Point(277, 67);
            this.rate_textBox.Multiline = true;
            this.rate_textBox.Name = "rate_textBox";
            this.rate_textBox.Size = new System.Drawing.Size(98, 33);
            this.rate_textBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(4, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Оценка";
            // 
            // rate_seller_button
            // 
            this.rate_seller_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rate_seller_button.Location = new System.Drawing.Point(119, 104);
            this.rate_seller_button.Name = "rate_seller_button";
            this.rate_seller_button.Size = new System.Drawing.Size(176, 45);
            this.rate_seller_button.TabIndex = 11;
            this.rate_seller_button.Text = "Оценить";
            this.rate_seller_button.UseVisualStyleBackColor = true;
            this.rate_seller_button.Click += new System.EventHandler(this.rate_seller_button_Click);
            // 
            // rate_seller_id_textBox
            // 
            this.rate_seller_id_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rate_seller_id_textBox.Location = new System.Drawing.Point(276, 21);
            this.rate_seller_id_textBox.Multiline = true;
            this.rate_seller_id_textBox.Name = "rate_seller_id_textBox";
            this.rate_seller_id_textBox.Size = new System.Drawing.Size(98, 33);
            this.rate_seller_id_textBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Оценить продавца с ID: ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.complaint_id_textBox);
            this.panel5.Controls.Add(this.complaint_button);
            this.panel5.Controls.Add(this.complaint_textBox);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(835, 404);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(631, 262);
            this.panel5.TabIndex = 13;
            // 
            // complaint_id_textBox
            // 
            this.complaint_id_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.complaint_id_textBox.Location = new System.Drawing.Point(376, 21);
            this.complaint_id_textBox.Multiline = true;
            this.complaint_id_textBox.Name = "complaint_id_textBox";
            this.complaint_id_textBox.Size = new System.Drawing.Size(98, 33);
            this.complaint_id_textBox.TabIndex = 12;
            // 
            // complaint_button
            // 
            this.complaint_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.complaint_button.Location = new System.Drawing.Point(228, 199);
            this.complaint_button.Name = "complaint_button";
            this.complaint_button.Size = new System.Drawing.Size(176, 45);
            this.complaint_button.TabIndex = 11;
            this.complaint_button.Text = "Отправить";
            this.complaint_button.UseVisualStyleBackColor = true;
            this.complaint_button.Click += new System.EventHandler(this.complaint_button_Click);
            // 
            // complaint_textBox
            // 
            this.complaint_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.complaint_textBox.Location = new System.Drawing.Point(8, 67);
            this.complaint_textBox.Multiline = true;
            this.complaint_textBox.Name = "complaint_textBox";
            this.complaint_textBox.Size = new System.Drawing.Size(610, 126);
            this.complaint_textBox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(342, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Написать жалобу на продавца с ID: ";
            // 
            // on_main_page_button
            // 
            this.on_main_page_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.on_main_page_button.Location = new System.Drawing.Point(556, 621);
            this.on_main_page_button.Name = "on_main_page_button";
            this.on_main_page_button.Size = new System.Drawing.Size(176, 45);
            this.on_main_page_button.TabIndex = 13;
            this.on_main_page_button.Text = "На главную";
            this.on_main_page_button.UseVisualStyleBackColor = true;
            this.on_main_page_button.Click += new System.EventHandler(this.on_main_page_button_Click);
            // 
            // Client_Cabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 707);
            this.Controls.Add(this.on_main_page_button);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.t_ctionBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "Client_Cabinet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет клиента";
            this.Load += new System.EventHandler(this.Enter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rZ_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ctionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ctionBindingNavigator)).EndInit();
            this.t_ctionBindingNavigator.ResumeLayout(false);
            this.t_ctionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private RZ_dbDataSet rZ_dbDataSet;
        private System.Windows.Forms.BindingSource t_ctionBindingSource;
        private RZ_dbDataSetTableAdapters.t_ctionTableAdapter t_ctionTableAdapter;
        private RZ_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_ctionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_ctionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buy_button;
        private System.Windows.Forms.TextBox buy_product_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button rate_seller_button;
        private System.Windows.Forms.TextBox rate_seller_id_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button complaint_button;
        private System.Windows.Forms.TextBox complaint_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button product_view_button;
        private System.Windows.Forms.TextBox complaint_id_textBox;
        private System.Windows.Forms.Button on_main_page_button;
        private System.Windows.Forms.TextBox rate_textBox;
        private System.Windows.Forms.Label label9;
    }
}