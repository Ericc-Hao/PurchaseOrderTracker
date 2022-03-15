namespace A3ChenruiHao
{
    partial class A3FileIO
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
            this.lblFileNameAndPath = new System.Windows.Forms.Label();
            this.grbFileOpenOpt = new System.Windows.Forms.GroupBox();
            this.rabOpen = new System.Windows.Forms.RadioButton();
            this.rabCreate = new System.Windows.Forms.RadioButton();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnCreateOrOpen = new System.Windows.Forms.Button();
            this.grbInset = new System.Windows.Forms.GroupBox();
            this.cbbUnits = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtOrdered = new System.Windows.Forms.TextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.txtShip = new System.Windows.Forms.TextBox();
            this.txtPurchsedFrom = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblOrdered = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblShipTo = new System.Windows.Forms.Label();
            this.lblPurchasedFrom = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.grbDeleteOrder = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDeleteNumber = new System.Windows.Forms.TextBox();
            this.lblDeleteNumber = new System.Windows.Forms.Label();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnEmptyFile = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.grbFileOpenOpt.SuspendLayout();
            this.grbInset.SuspendLayout();
            this.grbDeleteOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFileNameAndPath
            // 
            this.lblFileNameAndPath.AutoSize = true;
            this.lblFileNameAndPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileNameAndPath.Location = new System.Drawing.Point(24, 25);
            this.lblFileNameAndPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileNameAndPath.Name = "lblFileNameAndPath";
            this.lblFileNameAndPath.Size = new System.Drawing.Size(132, 17);
            this.lblFileNameAndPath.TabIndex = 0;
            this.lblFileNameAndPath.Text = "File Name and Path";
            // 
            // grbFileOpenOpt
            // 
            this.grbFileOpenOpt.Controls.Add(this.rabOpen);
            this.grbFileOpenOpt.Controls.Add(this.rabCreate);
            this.grbFileOpenOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFileOpenOpt.Location = new System.Drawing.Point(512, 25);
            this.grbFileOpenOpt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbFileOpenOpt.Name = "grbFileOpenOpt";
            this.grbFileOpenOpt.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbFileOpenOpt.Size = new System.Drawing.Size(241, 52);
            this.grbFileOpenOpt.TabIndex = 1;
            this.grbFileOpenOpt.TabStop = false;
            this.grbFileOpenOpt.Text = "File Open Option";
            // 
            // rabOpen
            // 
            this.rabOpen.AutoSize = true;
            this.rabOpen.Location = new System.Drawing.Point(105, 25);
            this.rabOpen.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rabOpen.Name = "rabOpen";
            this.rabOpen.Size = new System.Drawing.Size(113, 21);
            this.rabOpen.TabIndex = 1;
            this.rabOpen.TabStop = true;
            this.rabOpen.Text = "Open Existing";
            this.rabOpen.UseVisualStyleBackColor = true;
            // 
            // rabCreate
            // 
            this.rabCreate.AutoSize = true;
            this.rabCreate.Location = new System.Drawing.Point(3, 25);
            this.rabCreate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rabCreate.Name = "rabCreate";
            this.rabCreate.Size = new System.Drawing.Size(99, 21);
            this.rabCreate.TabIndex = 0;
            this.rabCreate.TabStop = true;
            this.rabCreate.Text = "Create New";
            this.rabCreate.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(22, 50);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(478, 23);
            this.txtPath.TabIndex = 2;
            // 
            // btnCreateOrOpen
            // 
            this.btnCreateOrOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrOpen.Location = new System.Drawing.Point(810, 43);
            this.btnCreateOrOpen.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCreateOrOpen.Name = "btnCreateOrOpen";
            this.btnCreateOrOpen.Size = new System.Drawing.Size(128, 27);
            this.btnCreateOrOpen.TabIndex = 3;
            this.btnCreateOrOpen.Text = "Create / Open File";
            this.btnCreateOrOpen.UseVisualStyleBackColor = true;
            this.btnCreateOrOpen.Click += new System.EventHandler(this.btnCreateOrOpen_Click);
            // 
            // grbInset
            // 
            this.grbInset.Controls.Add(this.cbbUnits);
            this.grbInset.Controls.Add(this.btnInsert);
            this.grbInset.Controls.Add(this.txtUnitPrice);
            this.grbInset.Controls.Add(this.txtOrdered);
            this.grbInset.Controls.Add(this.rtbDescription);
            this.grbInset.Controls.Add(this.txtShip);
            this.grbInset.Controls.Add(this.txtPurchsedFrom);
            this.grbInset.Controls.Add(this.dtpDate);
            this.grbInset.Controls.Add(this.txtNumber);
            this.grbInset.Controls.Add(this.lblDescription);
            this.grbInset.Controls.Add(this.lblOrdered);
            this.grbInset.Controls.Add(this.lblUnit);
            this.grbInset.Controls.Add(this.lblUnitPrice);
            this.grbInset.Controls.Add(this.lblShipTo);
            this.grbInset.Controls.Add(this.lblPurchasedFrom);
            this.grbInset.Controls.Add(this.lblDate);
            this.grbInset.Controls.Add(this.lblNumber);
            this.grbInset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInset.Location = new System.Drawing.Point(22, 84);
            this.grbInset.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbInset.Name = "grbInset";
            this.grbInset.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbInset.Size = new System.Drawing.Size(324, 392);
            this.grbInset.TabIndex = 2;
            this.grbInset.TabStop = false;
            this.grbInset.Text = "Insert Purchase Order";
            // 
            // cbbUnits
            // 
            this.cbbUnits.FormattingEnabled = true;
            this.cbbUnits.Location = new System.Drawing.Point(120, 281);
            this.cbbUnits.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbbUnits.Name = "cbbUnits";
            this.cbbUnits.Size = new System.Drawing.Size(196, 24);
            this.cbbUnits.TabIndex = 17;
            this.cbbUnits.Text = "Hours";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(120, 353);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(128, 27);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(120, 312);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(196, 23);
            this.txtUnitPrice.TabIndex = 16;
            // 
            // txtOrdered
            // 
            this.txtOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdered.Location = new System.Drawing.Point(120, 246);
            this.txtOrdered.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtOrdered.Name = "txtOrdered";
            this.txtOrdered.Size = new System.Drawing.Size(196, 23);
            this.txtOrdered.TabIndex = 15;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(120, 162);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(196, 72);
            this.rtbDescription.TabIndex = 15;
            this.rtbDescription.Text = "";
            // 
            // txtShip
            // 
            this.txtShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShip.Location = new System.Drawing.Point(120, 128);
            this.txtShip.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtShip.Name = "txtShip";
            this.txtShip.Size = new System.Drawing.Size(196, 23);
            this.txtShip.TabIndex = 14;
            // 
            // txtPurchsedFrom
            // 
            this.txtPurchsedFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchsedFrom.Location = new System.Drawing.Point(120, 95);
            this.txtPurchsedFrom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtPurchsedFrom.Name = "txtPurchsedFrom";
            this.txtPurchsedFrom.Size = new System.Drawing.Size(196, 23);
            this.txtPurchsedFrom.TabIndex = 13;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(120, 61);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(196, 23);
            this.dtpDate.TabIndex = 12;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(120, 27);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(196, 23);
            this.txtNumber.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(34, 162);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 17);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description: ";
            // 
            // lblOrdered
            // 
            this.lblOrdered.AutoSize = true;
            this.lblOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdered.Location = new System.Drawing.Point(53, 247);
            this.lblOrdered.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrdered.Name = "lblOrdered";
            this.lblOrdered.Size = new System.Drawing.Size(69, 17);
            this.lblOrdered.TabIndex = 10;
            this.lblOrdered.Text = "Ordered: ";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(78, 281);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(41, 17);
            this.lblUnit.TabIndex = 9;
            this.lblUnit.Text = "Unit: ";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(44, 313);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(77, 17);
            this.lblUnitPrice.TabIndex = 8;
            this.lblUnitPrice.Text = "Unit Price: ";
            // 
            // lblShipTo
            // 
            this.lblShipTo.AutoSize = true;
            this.lblShipTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipTo.Location = new System.Drawing.Point(60, 130);
            this.lblShipTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShipTo.Name = "lblShipTo";
            this.lblShipTo.Size = new System.Drawing.Size(61, 17);
            this.lblShipTo.TabIndex = 7;
            this.lblShipTo.Text = "Ship To:";
            // 
            // lblPurchasedFrom
            // 
            this.lblPurchasedFrom.AutoSize = true;
            this.lblPurchasedFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasedFrom.Location = new System.Drawing.Point(2, 96);
            this.lblPurchasedFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPurchasedFrom.Name = "lblPurchasedFrom";
            this.lblPurchasedFrom.Size = new System.Drawing.Size(120, 17);
            this.lblPurchasedFrom.TabIndex = 6;
            this.lblPurchasedFrom.Text = "Purchased From: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(74, 64);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 17);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date: ";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(53, 31);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(62, 17);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "Number:";
            // 
            // grbDeleteOrder
            // 
            this.grbDeleteOrder.Controls.Add(this.btnDelete);
            this.grbDeleteOrder.Controls.Add(this.txtDeleteNumber);
            this.grbDeleteOrder.Controls.Add(this.lblDeleteNumber);
            this.grbDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDeleteOrder.Location = new System.Drawing.Point(22, 512);
            this.grbDeleteOrder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbDeleteOrder.Name = "grbDeleteOrder";
            this.grbDeleteOrder.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbDeleteOrder.Size = new System.Drawing.Size(324, 128);
            this.grbDeleteOrder.TabIndex = 4;
            this.grbDeleteOrder.TabStop = false;
            this.grbDeleteOrder.Text = "Delete Purchase Order";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(70, 59);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 27);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDeleteNumber
            // 
            this.txtDeleteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteNumber.Location = new System.Drawing.Point(70, 26);
            this.txtDeleteNumber.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDeleteNumber.Name = "txtDeleteNumber";
            this.txtDeleteNumber.Size = new System.Drawing.Size(196, 23);
            this.txtDeleteNumber.TabIndex = 4;
            // 
            // lblDeleteNumber
            // 
            this.lblDeleteNumber.AutoSize = true;
            this.lblDeleteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteNumber.Location = new System.Drawing.Point(8, 27);
            this.lblDeleteNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeleteNumber.Name = "lblDeleteNumber";
            this.lblDeleteNumber.Size = new System.Drawing.Size(62, 17);
            this.lblDeleteNumber.TabIndex = 4;
            this.lblDeleteNumber.Text = "Number:";
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDisplay.Location = new System.Drawing.Point(356, 84);
            this.rtbDisplay.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.ReadOnly = true;
            this.rtbDisplay.Size = new System.Drawing.Size(818, 394);
            this.rtbDisplay.TabIndex = 18;
            this.rtbDisplay.Text = "";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(370, 561);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(128, 50);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "Display/Hide Purchase Orders";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.Location = new System.Drawing.Point(524, 561);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(128, 50);
            this.btnCloseForm.TabIndex = 19;
            this.btnCloseForm.Text = "Close Form";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnEmptyFile
            // 
            this.btnEmptyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmptyFile.Location = new System.Drawing.Point(674, 561);
            this.btnEmptyFile.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEmptyFile.Name = "btnEmptyFile";
            this.btnEmptyFile.Size = new System.Drawing.Size(128, 50);
            this.btnEmptyFile.TabIndex = 20;
            this.btnEmptyFile.Text = "Empty File";
            this.btnEmptyFile.UseVisualStyleBackColor = true;
            this.btnEmptyFile.Click += new System.EventHandler(this.btnEmptyFile_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessages.Location = new System.Drawing.Point(836, 538);
            this.rtbMessages.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(330, 95);
            this.rtbMessages.TabIndex = 18;
            this.rtbMessages.Text = "Exceptions/Comments Area";
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(356, 84);
            this.dgvDisplay.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ReadOnly = true;
            this.dgvDisplay.RowHeadersWidth = 82;
            this.dgvDisplay.RowTemplate.Height = 33;
            this.dgvDisplay.Size = new System.Drawing.Size(816, 443);
            this.dgvDisplay.TabIndex = 21;
            // 
            // A3FileIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 700);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnEmptyFile);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.grbDeleteOrder);
            this.Controls.Add(this.grbInset);
            this.Controls.Add(this.btnCreateOrOpen);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.grbFileOpenOpt);
            this.Controls.Add(this.lblFileNameAndPath);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "A3FileIO";
            this.Text = "Purchase Order Tracker";
            this.Load += new System.EventHandler(this.A3FileIO_Load);
            this.grbFileOpenOpt.ResumeLayout(false);
            this.grbFileOpenOpt.PerformLayout();
            this.grbInset.ResumeLayout(false);
            this.grbInset.PerformLayout();
            this.grbDeleteOrder.ResumeLayout(false);
            this.grbDeleteOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileNameAndPath;
        private System.Windows.Forms.GroupBox grbFileOpenOpt;
        private System.Windows.Forms.RadioButton rabCreate;
        private System.Windows.Forms.RadioButton rabOpen;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnCreateOrOpen;
        private System.Windows.Forms.GroupBox grbInset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblOrdered;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblShipTo;
        private System.Windows.Forms.Label lblPurchasedFrom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtOrdered;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox txtShip;
        private System.Windows.Forms.TextBox txtPurchsedFrom;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox grbDeleteOrder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteNumber;
        private System.Windows.Forms.Label lblDeleteNumber;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnEmptyFile;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.ComboBox cbbUnits;
    }
}