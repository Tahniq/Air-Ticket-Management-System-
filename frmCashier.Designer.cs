namespace AirTicketManagementSystem
{
    partial class CashierDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierDashboard));
            this.tabCashier = new System.Windows.Forms.TabControl();
            this.tabBookings = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPaymentStatusValue = new System.Windows.Forms.Label();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.lblTravelDateValue = new System.Windows.Forms.Label();
            this.lblSeatNoValue = new System.Windows.Forms.Label();
            this.lblFlightNoValue = new System.Windows.Forms.Label();
            this.lblPassengerNameValue = new System.Windows.Forms.Label();
            this.lblBookingIDValue = new System.Windows.Forms.Label();
            this.rbUnpaid = new System.Windows.Forms.RadioButton();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.BookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassengerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchBookingID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPayment = new System.Windows.Forms.TabPage();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnGenerateReceipt = new System.Windows.Forms.Button();
            this.rtbReceipt = new System.Windows.Forms.RichTextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCashierID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tabCashier.SuspendLayout();
            this.tabBookings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.tabPayment.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCashier
            // 
            this.tabCashier.Controls.Add(this.tabBookings);
            this.tabCashier.Controls.Add(this.tabPayment);
            this.tabCashier.Controls.Add(this.tabProfile);
            this.tabCashier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCashier.Location = new System.Drawing.Point(0, 0);
            this.tabCashier.Name = "tabCashier";
            this.tabCashier.SelectedIndex = 0;
            this.tabCashier.Size = new System.Drawing.Size(1132, 717);
            this.tabCashier.TabIndex = 0;
            // 
            // tabBookings
            // 
            this.tabBookings.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabBookings.Controls.Add(this.groupBox1);
            this.tabBookings.Controls.Add(this.rbUnpaid);
            this.tabBookings.Controls.Add(this.rbPaid);
            this.tabBookings.Controls.Add(this.rbAll);
            this.tabBookings.Controls.Add(this.btnRefresh);
            this.tabBookings.Controls.Add(this.lblTitle);
            this.tabBookings.Controls.Add(this.dgvBookings);
            this.tabBookings.Controls.Add(this.label2);
            this.tabBookings.Controls.Add(this.btnSearch);
            this.tabBookings.Controls.Add(this.txtSearchBookingID);
            this.tabBookings.Controls.Add(this.label1);
            this.tabBookings.Location = new System.Drawing.Point(4, 25);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookings.Size = new System.Drawing.Size(1124, 688);
            this.tabBookings.TabIndex = 0;
            this.tabBookings.Text = "Booking Management";
            this.tabBookings.Click += new System.EventHandler(this.tabBookings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.lblPaymentStatusValue);
            this.groupBox1.Controls.Add(this.lblTotalAmountValue);
            this.groupBox1.Controls.Add(this.lblTravelDateValue);
            this.groupBox1.Controls.Add(this.lblSeatNoValue);
            this.groupBox1.Controls.Add(this.lblFlightNoValue);
            this.groupBox1.Controls.Add(this.lblPassengerNameValue);
            this.groupBox1.Controls.Add(this.lblBookingIDValue);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 257);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblPaymentStatusValue
            // 
            this.lblPaymentStatusValue.AutoSize = true;
            this.lblPaymentStatusValue.Location = new System.Drawing.Point(7, 214);
            this.lblPaymentStatusValue.Name = "lblPaymentStatusValue";
            this.lblPaymentStatusValue.Size = new System.Drawing.Size(137, 20);
            this.lblPaymentStatusValue.TabIndex = 6;
            this.lblPaymentStatusValue.Text = "Payment Status: ";
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Location = new System.Drawing.Point(7, 183);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(118, 20);
            this.lblTotalAmountValue.TabIndex = 5;
            this.lblTotalAmountValue.Text = "Total Amount: ";
            // 
            // lblTravelDateValue
            // 
            this.lblTravelDateValue.AutoSize = true;
            this.lblTravelDateValue.Location = new System.Drawing.Point(7, 151);
            this.lblTravelDateValue.Name = "lblTravelDateValue";
            this.lblTravelDateValue.Size = new System.Drawing.Size(106, 20);
            this.lblTravelDateValue.TabIndex = 4;
            this.lblTravelDateValue.Text = "Travel Date: ";
            // 
            // lblSeatNoValue
            // 
            this.lblSeatNoValue.AutoSize = true;
            this.lblSeatNoValue.Location = new System.Drawing.Point(7, 119);
            this.lblSeatNoValue.Name = "lblSeatNoValue";
            this.lblSeatNoValue.Size = new System.Drawing.Size(79, 20);
            this.lblSeatNoValue.TabIndex = 3;
            this.lblSeatNoValue.Text = "Seat No: ";
            this.lblSeatNoValue.Click += new System.EventHandler(this.lblSeatNoValue_Click);
            // 
            // lblFlightNoValue
            // 
            this.lblFlightNoValue.AutoSize = true;
            this.lblFlightNoValue.Location = new System.Drawing.Point(7, 94);
            this.lblFlightNoValue.Name = "lblFlightNoValue";
            this.lblFlightNoValue.Size = new System.Drawing.Size(86, 20);
            this.lblFlightNoValue.TabIndex = 2;
            this.lblFlightNoValue.Text = "Flight No: ";
            // 
            // lblPassengerNameValue
            // 
            this.lblPassengerNameValue.AutoSize = true;
            this.lblPassengerNameValue.Location = new System.Drawing.Point(7, 66);
            this.lblPassengerNameValue.Name = "lblPassengerNameValue";
            this.lblPassengerNameValue.Size = new System.Drawing.Size(148, 20);
            this.lblPassengerNameValue.TabIndex = 1;
            this.lblPassengerNameValue.Text = "Passenger Name: ";
            // 
            // lblBookingIDValue
            // 
            this.lblBookingIDValue.AutoSize = true;
            this.lblBookingIDValue.Location = new System.Drawing.Point(7, 35);
            this.lblBookingIDValue.Name = "lblBookingIDValue";
            this.lblBookingIDValue.Size = new System.Drawing.Size(101, 20);
            this.lblBookingIDValue.TabIndex = 0;
            this.lblBookingIDValue.Text = "Booking ID: ";
            this.lblBookingIDValue.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // rbUnpaid
            // 
            this.rbUnpaid.AutoSize = true;
            this.rbUnpaid.Location = new System.Drawing.Point(379, 113);
            this.rbUnpaid.Name = "rbUnpaid";
            this.rbUnpaid.Size = new System.Drawing.Size(72, 20);
            this.rbUnpaid.TabIndex = 16;
            this.rbUnpaid.TabStop = true;
            this.rbUnpaid.Text = "Unpaid";
            this.rbUnpaid.UseVisualStyleBackColor = true;
            this.rbUnpaid.CheckedChanged += new System.EventHandler(this.rbUnpaid_CheckedChanged);
            // 
            // rbPaid
            // 
            this.rbPaid.AutoSize = true;
            this.rbPaid.Location = new System.Drawing.Point(249, 113);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(56, 20);
            this.rbPaid.TabIndex = 15;
            this.rbPaid.TabStop = true;
            this.rbPaid.Text = "Paid";
            this.rbPaid.UseVisualStyleBackColor = true;
            this.rbPaid.CheckedChanged += new System.EventHandler(this.rbPaid_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(121, 113);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(43, 20);
            this.rbAll.TabIndex = 14;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(605, 64);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(102, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AllowDrop = true;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(8, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(251, 32);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "CASHIER PANEL";
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingID,
            this.PassengerName,
            this.FlightNo,
            this.TravelDate,
            this.TotalAmount,
            this.PaymentStatus});
            this.dgvBookings.Location = new System.Drawing.Point(12, 179);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersWidth = 51;
            this.dgvBookings.RowTemplate.Height = 24;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(814, 477);
            this.dgvBookings.TabIndex = 4;
            this.dgvBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookings_CellClick);
            this.dgvBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BookingID
            // 
            this.BookingID.HeaderText = "Booking ID";
            this.BookingID.MinimumWidth = 6;
            this.BookingID.Name = "BookingID";
            this.BookingID.ReadOnly = true;
            // 
            // PassengerName
            // 
            this.PassengerName.HeaderText = "Passenger";
            this.PassengerName.MinimumWidth = 6;
            this.PassengerName.Name = "PassengerName";
            this.PassengerName.ReadOnly = true;
            // 
            // FlightNo
            // 
            this.FlightNo.HeaderText = "Flight";
            this.FlightNo.MinimumWidth = 6;
            this.FlightNo.Name = "FlightNo";
            this.FlightNo.ReadOnly = true;
            // 
            // TravelDate
            // 
            this.TravelDate.HeaderText = "Date";
            this.TravelDate.MinimumWidth = 6;
            this.TravelDate.Name = "TravelDate";
            this.TravelDate.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Amount";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.HeaderText = "Status";
            this.PaymentStatus.MinimumWidth = 6;
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "All bookings: ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(471, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchBookingID
            // 
            this.txtSearchBookingID.Location = new System.Drawing.Point(121, 65);
            this.txtSearchBookingID.Name = "txtSearchBookingID";
            this.txtSearchBookingID.Size = new System.Drawing.Size(330, 22);
            this.txtSearchBookingID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking ID: ";
            // 
            // tabPayment
            // 
            this.tabPayment.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPayment.Controls.Add(this.btnPrintReceipt);
            this.tabPayment.Controls.Add(this.btnGenerateReceipt);
            this.tabPayment.Controls.Add(this.rtbReceipt);
            this.tabPayment.Controls.Add(this.txtAmount);
            this.tabPayment.Controls.Add(this.txtPassengerName);
            this.tabPayment.Controls.Add(this.txtBookingID);
            this.tabPayment.Controls.Add(this.label5);
            this.tabPayment.Controls.Add(this.label4);
            this.tabPayment.Controls.Add(this.label3);
            this.tabPayment.Controls.Add(this.btnConfirmPayment);
            this.tabPayment.Controls.Add(this.cmbPaymentMethod);
            this.tabPayment.Controls.Add(this.label7);
            this.tabPayment.Controls.Add(this.label6);
            this.tabPayment.Location = new System.Drawing.Point(4, 25);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayment.Size = new System.Drawing.Size(1124, 688);
            this.tabPayment.TabIndex = 1;
            this.tabPayment.Text = "Payment Processing: ";
            this.tabPayment.Click += new System.EventHandler(this.tabPayment_Click);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(379, 630);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(127, 23);
            this.btnPrintReceipt.TabIndex = 15;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGenerateReceipt
            // 
            this.btnGenerateReceipt.Location = new System.Drawing.Point(37, 630);
            this.btnGenerateReceipt.Name = "btnGenerateReceipt";
            this.btnGenerateReceipt.Size = new System.Drawing.Size(127, 23);
            this.btnGenerateReceipt.TabIndex = 14;
            this.btnGenerateReceipt.Text = "Generate Receipt";
            this.btnGenerateReceipt.UseVisualStyleBackColor = true;
            this.btnGenerateReceipt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rtbReceipt
            // 
            this.rtbReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbReceipt.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbReceipt.Location = new System.Drawing.Point(34, 374);
            this.rtbReceipt.Name = "rtbReceipt";
            this.rtbReceipt.ReadOnly = true;
            this.rtbReceipt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbReceipt.Size = new System.Drawing.Size(500, 250);
            this.rtbReceipt.TabIndex = 13;
            this.rtbReceipt.Text = "";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(256, 181);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 12;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(256, 128);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.ReadOnly = true;
            this.txtPassengerName.Size = new System.Drawing.Size(100, 22);
            this.txtPassengerName.TabIndex = 11;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(256, 81);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.Size = new System.Drawing.Size(100, 22);
            this.txtBookingID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Amount: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Passenger Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Booking ID: ";
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Location = new System.Drawing.Point(34, 334);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(119, 23);
            this.btnConfirmPayment.TabIndex = 3;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = true;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Mobile Banking"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(34, 283);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(121, 24);
            this.cmbPaymentMethod.TabIndex = 2;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Payment Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Payment Processing";
            // 
            // tabProfile
            // 
            this.tabProfile.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabProfile.Controls.Add(this.btnUpdateProfile);
            this.tabProfile.Controls.Add(this.txtPhone);
            this.tabProfile.Controls.Add(this.txtEmail);
            this.tabProfile.Controls.Add(this.txtName);
            this.tabProfile.Controls.Add(this.txtCashierID);
            this.tabProfile.Controls.Add(this.label12);
            this.tabProfile.Controls.Add(this.label11);
            this.tabProfile.Controls.Add(this.label10);
            this.tabProfile.Controls.Add(this.label8);
            this.tabProfile.Controls.Add(this.label9);
            this.tabProfile.Location = new System.Drawing.Point(4, 25);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(1124, 688);
            this.tabProfile.TabIndex = 2;
            this.tabProfile.Text = "Update Profile";
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(86, 409);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(134, 23);
            this.btnUpdateProfile.TabIndex = 9;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(190, 311);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(190, 242);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(190, 173);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtCashierID
            // 
            this.txtCashierID.Location = new System.Drawing.Point(190, 112);
            this.txtCashierID.Name = "txtCashierID";
            this.txtCashierID.ReadOnly = true;
            this.txtCashierID.Size = new System.Drawing.Size(100, 22);
            this.txtCashierID.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Phone: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Email: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Name: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cashier ID: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cashier Profile";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CashierDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1132, 717);
            this.Controls.Add(this.tabCashier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CashierDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Air Ticket Management System - Cashier Panel";
            this.Load += new System.EventHandler(this.CashierDashboard_Load);
            this.tabCashier.ResumeLayout(false);
            this.tabBookings.ResumeLayout(false);
            this.tabBookings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.tabPayment.ResumeLayout(false);
            this.tabPayment.PerformLayout();
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCashier;
        private System.Windows.Forms.TabPage tabBookings;
        private System.Windows.Forms.TabPage tabPayment;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchBookingID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RadioButton rbUnpaid;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBookingIDValue;
        private System.Windows.Forms.Label lblPaymentStatusValue;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Label lblTravelDateValue;
        private System.Windows.Forms.Label lblSeatNoValue;
        private System.Windows.Forms.Label lblFlightNoValue;
        private System.Windows.Forms.Label lblPassengerNameValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassengerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatus;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.RichTextBox rtbReceipt;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnGenerateReceipt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCashierID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdateProfile;
    }
}

