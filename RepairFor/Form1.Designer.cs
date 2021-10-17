
namespace RepairFor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerUniqueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeiNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.txtcustomertelefon = new System.Windows.Forms.TextBox();
            this.txtimei = new System.Windows.Forms.TextBox();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.txtfault = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.chcdelivery = new System.Windows.Forms.CheckBox();
            this.chcnotdelivery = new System.Windows.Forms.CheckBox();
            this.btnproductcode = new System.Windows.Forms.Button();
            this.btnnumber = new System.Windows.Forms.Button();
            this.btnlastnm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerUniqueId,
            this.CustomerFirstName,
            this.CustomerLastName,
            this.TelefonNumber,
            this.Description,
            this.StartingDate,
            this.FinishDate,
            this.Fault,
            this.Brand,
            this.ImeiNumber,
            this.Price});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(454, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 10);
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(678, 580);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.AllowUserToDeleteRowsChanged += new System.EventHandler(this.dataGridView1_AllowUserToDeleteRowsChanged);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // CustomerUniqueId
            // 
            this.CustomerUniqueId.DataPropertyName = "CustomerUniqueId";
            this.CustomerUniqueId.HeaderText = "Ürün Kodu";
            this.CustomerUniqueId.MinimumWidth = 6;
            this.CustomerUniqueId.Name = "CustomerUniqueId";
            this.CustomerUniqueId.Width = 125;
            // 
            // CustomerFirstName
            // 
            this.CustomerFirstName.DataPropertyName = "FirstName";
            this.CustomerFirstName.HeaderText = "İsim";
            this.CustomerFirstName.MinimumWidth = 6;
            this.CustomerFirstName.Name = "CustomerFirstName";
            this.CustomerFirstName.Width = 125;
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.DataPropertyName = "LastName";
            this.CustomerLastName.HeaderText = "Soyad";
            this.CustomerLastName.MinimumWidth = 6;
            this.CustomerLastName.Name = "CustomerLastName";
            this.CustomerLastName.Width = 125;
            // 
            // TelefonNumber
            // 
            this.TelefonNumber.DataPropertyName = "TelefonNumber";
            this.TelefonNumber.HeaderText = "Telefon Numarası";
            this.TelefonNumber.MinimumWidth = 6;
            this.TelefonNumber.Name = "TelefonNumber";
            this.TelefonNumber.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Açıklama";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // StartingDate
            // 
            this.StartingDate.DataPropertyName = "StartingDate";
            this.StartingDate.HeaderText = "Teslim al. Tarih";
            this.StartingDate.MinimumWidth = 6;
            this.StartingDate.Name = "StartingDate";
            this.StartingDate.Width = 125;
            // 
            // FinishDate
            // 
            this.FinishDate.DataPropertyName = "FinishDate";
            this.FinishDate.HeaderText = "Teslim Edilen Tar.";
            this.FinishDate.MinimumWidth = 6;
            this.FinishDate.Name = "FinishDate";
            this.FinishDate.Width = 125;
            // 
            // Fault
            // 
            this.Fault.DataPropertyName = "Fault";
            this.Fault.HeaderText = "Arıza";
            this.Fault.MinimumWidth = 6;
            this.Fault.Name = "Fault";
            this.Fault.Width = 125;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Marka";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.Width = 125;
            // 
            // ImeiNumber
            // 
            this.ImeiNumber.DataPropertyName = "ImeiNumber";
            this.ImeiNumber.HeaderText = "IMEI numarası";
            this.ImeiNumber.MinimumWidth = 6;
            this.ImeiNumber.Name = "ImeiNumber";
            this.ImeiNumber.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Ücret";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // btnsave
            // 
            this.btnsave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsave.Location = new System.Drawing.Point(228, 578);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(222, 60);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "Kaydet";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCustomerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerFirstName.Location = new System.Drawing.Point(228, 9);
            this.txtCustomerFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerFirstName.Multiline = true;
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(222, 57);
            this.txtCustomerFirstName.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(2, 460);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 39);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ücret";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(2, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 39);
            this.label7.TabIndex = 7;
            this.label7.Text = "Açıklama";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(2, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 39);
            this.label6.TabIndex = 6;
            this.label6.Text = "Arıza";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(2, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 39);
            this.label5.TabIndex = 5;
            this.label5.Text = "Model";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(2, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 78);
            this.label4.TabIndex = 4;
            this.label4.Text = "IMEI numarası";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(2, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefon Numarası";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Soyad";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(2, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri İsim";
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCustomerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerLastName.Location = new System.Drawing.Point(228, 82);
            this.txtCustomerLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerLastName.Multiline = true;
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(222, 38);
            this.txtCustomerLastName.TabIndex = 11;
            // 
            // txtcustomertelefon
            // 
            this.txtcustomertelefon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcustomertelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcustomertelefon.Location = new System.Drawing.Point(228, 129);
            this.txtcustomertelefon.Margin = new System.Windows.Forms.Padding(2);
            this.txtcustomertelefon.Multiline = true;
            this.txtcustomertelefon.Name = "txtcustomertelefon";
            this.txtcustomertelefon.Size = new System.Drawing.Size(222, 31);
            this.txtcustomertelefon.TabIndex = 12;
            // 
            // txtimei
            // 
            this.txtimei.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtimei.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtimei.Location = new System.Drawing.Point(228, 180);
            this.txtimei.Margin = new System.Windows.Forms.Padding(2);
            this.txtimei.Multiline = true;
            this.txtimei.Name = "txtimei";
            this.txtimei.Size = new System.Drawing.Size(222, 57);
            this.txtimei.TabIndex = 13;
            // 
            // txtbrand
            // 
            this.txtbrand.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbrand.Location = new System.Drawing.Point(228, 259);
            this.txtbrand.Margin = new System.Windows.Forms.Padding(2);
            this.txtbrand.Multiline = true;
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(222, 57);
            this.txtbrand.TabIndex = 14;
            // 
            // txtfault
            // 
            this.txtfault.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtfault.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfault.Location = new System.Drawing.Point(228, 323);
            this.txtfault.Margin = new System.Windows.Forms.Padding(2);
            this.txtfault.Multiline = true;
            this.txtfault.Name = "txtfault";
            this.txtfault.Size = new System.Drawing.Size(222, 57);
            this.txtfault.TabIndex = 15;
            // 
            // txtdescription
            // 
            this.txtdescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdescription.Location = new System.Drawing.Point(228, 387);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(222, 57);
            this.txtdescription.TabIndex = 16;
            // 
            // txtprice
            // 
            this.txtprice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtprice.Location = new System.Drawing.Point(228, 451);
            this.txtprice.Margin = new System.Windows.Forms.Padding(2);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(222, 57);
            this.txtprice.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.txtprice, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtdescription, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtfault, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtbrand, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtimei, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtcustomertelefon, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomerLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomerFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnsave, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.87683F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.064516F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.58598F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.67689F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1134, 660);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.60088F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.39912F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanel2.Controls.Add(this.dtpicker, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtsearch, -1, 1);
            this.tableLayoutPanel2.Controls.Add(this.chcdelivery, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.chcnotdelivery, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnproductcode, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnnumber, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnlastnm, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(455, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.45802F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.71756F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.82443F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(676, 70);
            this.tableLayoutPanel2.TabIndex = 21;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // dtpicker
            // 
            this.dtpicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpicker.Location = new System.Drawing.Point(210, 31);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(103, 20);
            this.dtpicker.TabIndex = 25;
            this.dtpicker.ValueChanged += new System.EventHandler(this.dtpicker_ValueChanged);
            // 
            // txtsearch
            // 
            this.txtsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsearch.Location = new System.Drawing.Point(2, 2);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.tableLayoutPanel2.SetRowSpan(this.txtsearch, 2);
            this.txtsearch.Size = new System.Drawing.Size(203, 49);
            this.txtsearch.TabIndex = 20;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // chcdelivery
            // 
            this.chcdelivery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chcdelivery.AutoSize = true;
            this.chcdelivery.Cursor = System.Windows.Forms.Cursors.Default;
            this.chcdelivery.Location = new System.Drawing.Point(476, 31);
            this.chcdelivery.Margin = new System.Windows.Forms.Padding(2);
            this.chcdelivery.Name = "chcdelivery";
            this.chcdelivery.Size = new System.Drawing.Size(118, 19);
            this.chcdelivery.TabIndex = 26;
            this.chcdelivery.Text = "Teslim Edilenler";
            this.chcdelivery.UseVisualStyleBackColor = true;
            this.chcdelivery.CheckedChanged += new System.EventHandler(this.chcdelivery_CheckedChanged);
            // 
            // chcnotdelivery
            // 
            this.chcnotdelivery.AutoSize = true;
            this.chcnotdelivery.Location = new System.Drawing.Point(476, 2);
            this.chcnotdelivery.Margin = new System.Windows.Forms.Padding(2);
            this.chcnotdelivery.Name = "chcnotdelivery";
            this.chcnotdelivery.Size = new System.Drawing.Size(141, 19);
            this.chcnotdelivery.TabIndex = 28;
            this.chcnotdelivery.Text = "Teslim Edilmeyenler";
            this.chcnotdelivery.UseVisualStyleBackColor = true;
            this.chcnotdelivery.CheckedChanged += new System.EventHandler(this.chcnotdelivery_CheckedChanged_1);
            // 
            // btnproductcode
            // 
            this.btnproductcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnproductcode.Location = new System.Drawing.Point(318, 2);
            this.btnproductcode.Margin = new System.Windows.Forms.Padding(2);
            this.btnproductcode.Name = "btnproductcode";
            this.btnproductcode.Size = new System.Drawing.Size(154, 24);
            this.btnproductcode.TabIndex = 29;
            this.btnproductcode.Text = "Ürün Kodu";
            this.btnproductcode.UseVisualStyleBackColor = true;
            this.btnproductcode.Click += new System.EventHandler(this.btnproductcode_Click);
            // 
            // btnnumber
            // 
            this.btnnumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnnumber.Location = new System.Drawing.Point(318, 30);
            this.btnnumber.Margin = new System.Windows.Forms.Padding(2);
            this.btnnumber.Name = "btnnumber";
            this.btnnumber.Size = new System.Drawing.Size(154, 21);
            this.btnnumber.TabIndex = 30;
            this.btnnumber.Text = "Telefon numarası";
            this.btnnumber.UseVisualStyleBackColor = true;
            this.btnnumber.Click += new System.EventHandler(this.btnnumber_Click);
            // 
            // btnlastnm
            // 
            this.btnlastnm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnlastnm.Location = new System.Drawing.Point(209, 2);
            this.btnlastnm.Margin = new System.Windows.Forms.Padding(2);
            this.btnlastnm.MaximumSize = new System.Drawing.Size(200, 0);
            this.btnlastnm.Name = "btnlastnm";
            this.btnlastnm.Size = new System.Drawing.Size(105, 24);
            this.btnlastnm.TabIndex = 31;
            this.btnlastnm.Text = "Soyad";
            this.btnlastnm.UseVisualStyleBackColor = true;
            this.btnlastnm.Click += new System.EventHandler(this.btnlastnm_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 515);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(220, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1134, 660);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Yalçın İletişim";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerUniqueId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fault;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeiNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtfault;
        private System.Windows.Forms.TextBox txtbrand;
        private System.Windows.Forms.TextBox txtimei;
        private System.Windows.Forms.TextBox txtcustomertelefon;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.CheckBox chcdelivery;
        private System.Windows.Forms.CheckBox chcnotdelivery;
        private System.Windows.Forms.Button btnproductcode;
        private System.Windows.Forms.Button btnnumber;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Button btnlastnm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}