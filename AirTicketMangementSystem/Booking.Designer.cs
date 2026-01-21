namespace AirTicketMangementSystem
{
    partial class Booking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPassengerBooking = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPassengerBookingFlightDestination = new System.Windows.Forms.Label();
            this.pnlPassengerBookingManage = new System.Windows.Forms.Panel();
            this.comboSeat = new System.Windows.Forms.ComboBox();
            this.txtDst = new System.Windows.Forms.TextBox();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.txtBId = new System.Windows.Forms.TextBox();
            this.lblPassengerBookingFlightSeat = new System.Windows.Forms.Label();
            this.rdbCancelled = new System.Windows.Forms.RadioButton();
            this.rdbPending = new System.Windows.Forms.RadioButton();
            this.rdbConfirmed = new System.Windows.Forms.RadioButton();
            this.lblPassengerBookingPassengerId = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpBDate = new System.Windows.Forms.DateTimePicker();
            this.lblPassengerBookingId = new System.Windows.Forms.Label();
            this.lblPassengerBookingDate = new System.Windows.Forms.Label();
            this.lblPassengerBookingStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPassengerBookingManage = new System.Windows.Forms.Label();
            this.lblPassengerBookingInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerBooking)).BeginInit();
            this.pnlPassengerBookingManage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPassengerBooking
            // 
            this.dgvPassengerBooking.AllowUserToAddRows = false;
            this.dgvPassengerBooking.AllowUserToDeleteRows = false;
            this.dgvPassengerBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPassengerBooking.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPassengerBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPassengerBooking.Location = new System.Drawing.Point(7, 80);
            this.dgvPassengerBooking.Margin = new System.Windows.Forms.Padding(6);
            this.dgvPassengerBooking.Name = "dgvPassengerBooking";
            this.dgvPassengerBooking.ReadOnly = true;
            this.dgvPassengerBooking.RowHeadersWidth = 82;
            this.dgvPassengerBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassengerBooking.Size = new System.Drawing.Size(295, 1038);
            this.dgvPassengerBooking.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(383, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 65);
            this.panel2.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(6, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(365, 88);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnPassengerBookingAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Salmon;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(403, 6);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(366, 88);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnPassengerBookingDelete_Click);
            // 
            // lblPassengerBookingFlightDestination
            // 
            this.lblPassengerBookingFlightDestination.AutoSize = true;
            this.lblPassengerBookingFlightDestination.Location = new System.Drawing.Point(71, 272);
            this.lblPassengerBookingFlightDestination.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerBookingFlightDestination.Name = "lblPassengerBookingFlightDestination";
            this.lblPassengerBookingFlightDestination.Size = new System.Drawing.Size(204, 37);
            this.lblPassengerBookingFlightDestination.TabIndex = 29;
            this.lblPassengerBookingFlightDestination.Text = "Destination : ";
            // 
            // pnlPassengerBookingManage
            // 
            this.pnlPassengerBookingManage.Controls.Add(this.comboSeat);
            this.pnlPassengerBookingManage.Controls.Add(this.txtDst);
            this.pnlPassengerBookingManage.Controls.Add(this.txtPId);
            this.pnlPassengerBookingManage.Controls.Add(this.txtBId);
            this.pnlPassengerBookingManage.Controls.Add(this.lblPassengerBookingFlightDestination);
            this.pnlPassengerBookingManage.Controls.Add(this.lblPassengerBookingFlightSeat);
            this.pnlPassengerBookingManage.Controls.Add(this.rdbCancelled);
            this.pnlPassengerBookingManage.Controls.Add(this.rdbPending);
            this.pnlPassengerBookingManage.Controls.Add(this.rdbConfirmed);
            this.pnlPassengerBookingManage.Controls.Add(this.lblPassengerBookingPassengerId);
            this.pnlPassengerBookingManage.Controls.Add(this.tableLayoutPanel2);
            this.pnlPassengerBookingManage.Controls.Add(this.dtpBDate);
            this.pnlPassengerBookingManage.Controls.Add(this.lblPassengerBookingId);
            this.pnlPassengerBookingManage.Controls.Add(this.lblPassengerBookingDate);
            this.pnlPassengerBookingManage.Controls.Add(this.lblPassengerBookingStatus);
            this.pnlPassengerBookingManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPassengerBookingManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPassengerBookingManage.Location = new System.Drawing.Point(315, 80);
            this.pnlPassengerBookingManage.Margin = new System.Windows.Forms.Padding(6);
            this.pnlPassengerBookingManage.Name = "pnlPassengerBookingManage";
            this.pnlPassengerBookingManage.Size = new System.Drawing.Size(816, 1038);
            this.pnlPassengerBookingManage.TabIndex = 3;
            this.pnlPassengerBookingManage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPassengerBookingManage_Paint);
            // 
            // comboSeat
            // 
            this.comboSeat.FormattingEnabled = true;
            this.comboSeat.Items.AddRange(new object[] {
            "business class",
            "economy class",
            "suite class"});
            this.comboSeat.Location = new System.Drawing.Point(295, 356);
            this.comboSeat.Name = "comboSeat";
            this.comboSeat.Size = new System.Drawing.Size(445, 45);
            this.comboSeat.TabIndex = 40;
            // 
            // txtDst
            // 
            this.txtDst.Location = new System.Drawing.Point(295, 265);
            this.txtDst.Name = "txtDst";
            this.txtDst.Size = new System.Drawing.Size(445, 44);
            this.txtDst.TabIndex = 39;
            this.txtDst.TextChanged += new System.EventHandler(this.txtDst_TextChanged);
            this.txtDst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDstKeyPress);
            // 
            // txtPId
            // 
            this.txtPId.Location = new System.Drawing.Point(298, 191);
            this.txtPId.Name = "txtPId";
            this.txtPId.Size = new System.Drawing.Size(445, 44);
            this.txtPId.TabIndex = 38;
            this.txtPId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPIdKeyPress);
            // 
            // txtBId
            // 
            this.txtBId.Location = new System.Drawing.Point(307, 52);
            this.txtBId.Name = "txtBId";
            this.txtBId.Size = new System.Drawing.Size(445, 44);
            this.txtBId.TabIndex = 37;
            this.txtBId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBIdKeyPress);
            // 
            // lblPassengerBookingFlightSeat
            // 
            this.lblPassengerBookingFlightSeat.AutoSize = true;
            this.lblPassengerBookingFlightSeat.Location = new System.Drawing.Point(166, 364);
            this.lblPassengerBookingFlightSeat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerBookingFlightSeat.Name = "lblPassengerBookingFlightSeat";
            this.lblPassengerBookingFlightSeat.Size = new System.Drawing.Size(109, 37);
            this.lblPassengerBookingFlightSeat.TabIndex = 25;
            this.lblPassengerBookingFlightSeat.Text = "Seat : ";
            // 
            // rdbCancelled
            // 
            this.rdbCancelled.AutoSize = true;
            this.rdbCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCancelled.Location = new System.Drawing.Point(642, 441);
            this.rdbCancelled.Margin = new System.Windows.Forms.Padding(6);
            this.rdbCancelled.Name = "rdbCancelled";
            this.rdbCancelled.Size = new System.Drawing.Size(166, 35);
            this.rdbCancelled.TabIndex = 24;
            this.rdbCancelled.TabStop = true;
            this.rdbCancelled.Text = "Cancelled";
            this.rdbCancelled.UseVisualStyleBackColor = true;
            // 
            // rdbPending
            // 
            this.rdbPending.AutoSize = true;
            this.rdbPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPending.Location = new System.Drawing.Point(454, 439);
            this.rdbPending.Margin = new System.Windows.Forms.Padding(6);
            this.rdbPending.Name = "rdbPending";
            this.rdbPending.Size = new System.Drawing.Size(144, 35);
            this.rdbPending.TabIndex = 23;
            this.rdbPending.TabStop = true;
            this.rdbPending.Text = "Pending";
            this.rdbPending.UseVisualStyleBackColor = true;
            // 
            // rdbConfirmed
            // 
            this.rdbConfirmed.AutoSize = true;
            this.rdbConfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbConfirmed.Location = new System.Drawing.Point(272, 441);
            this.rdbConfirmed.Margin = new System.Windows.Forms.Padding(6);
            this.rdbConfirmed.Name = "rdbConfirmed";
            this.rdbConfirmed.Size = new System.Drawing.Size(170, 35);
            this.rdbConfirmed.TabIndex = 21;
            this.rdbConfirmed.TabStop = true;
            this.rdbConfirmed.Text = "Confirmed";
            this.rdbConfirmed.UseVisualStyleBackColor = true;
            // 
            // lblPassengerBookingPassengerId
            // 
            this.lblPassengerBookingPassengerId.AutoSize = true;
            this.lblPassengerBookingPassengerId.Location = new System.Drawing.Point(60, 198);
            this.lblPassengerBookingPassengerId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerBookingPassengerId.Name = "lblPassengerBookingPassengerId";
            this.lblPassengerBookingPassengerId.Size = new System.Drawing.Size(236, 37);
            this.lblPassengerBookingPassengerId.TabIndex = 19;
            this.lblPassengerBookingPassengerId.Text = "Passenger ID : ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBack, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(33, 528);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(775, 100);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // dtpBDate
            // 
            this.dtpBDate.CustomFormat = "yyyy-MM-dd";
            this.dtpBDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBDate.Location = new System.Drawing.Point(298, 119);
            this.dtpBDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpBDate.Name = "dtpBDate";
            this.dtpBDate.Size = new System.Drawing.Size(472, 44);
            this.dtpBDate.TabIndex = 12;
            // 
            // lblPassengerBookingId
            // 
            this.lblPassengerBookingId.AutoSize = true;
            this.lblPassengerBookingId.Location = new System.Drawing.Point(98, 52);
            this.lblPassengerBookingId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerBookingId.Name = "lblPassengerBookingId";
            this.lblPassengerBookingId.Size = new System.Drawing.Size(200, 37);
            this.lblPassengerBookingId.TabIndex = 0;
            this.lblPassengerBookingId.Text = "Booking ID : ";
            // 
            // lblPassengerBookingDate
            // 
            this.lblPassengerBookingDate.AutoSize = true;
            this.lblPassengerBookingDate.Location = new System.Drawing.Point(62, 125);
            this.lblPassengerBookingDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerBookingDate.Name = "lblPassengerBookingDate";
            this.lblPassengerBookingDate.Size = new System.Drawing.Size(236, 37);
            this.lblPassengerBookingDate.TabIndex = 14;
            this.lblPassengerBookingDate.Text = "Booking Date : ";
            // 
            // lblPassengerBookingStatus
            // 
            this.lblPassengerBookingStatus.AutoSize = true;
            this.lblPassengerBookingStatus.Location = new System.Drawing.Point(15, 439);
            this.lblPassengerBookingStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerBookingStatus.Name = "lblPassengerBookingStatus";
            this.lblPassengerBookingStatus.Size = new System.Drawing.Size(260, 37);
            this.lblPassengerBookingStatus.TabIndex = 22;
            this.lblPassengerBookingStatus.Text = "Booking Status : ";
            this.lblPassengerBookingStatus.Click += new System.EventHandler(this.lblPassengerBookingStatus_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 828F));
            this.tableLayoutPanel1.Controls.Add(this.lblPassengerBookingManage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPassengerBookingInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlPassengerBookingManage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvPassengerBooking, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1138, 1125);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblPassengerBookingManage
            // 
            this.lblPassengerBookingManage.AutoSize = true;
            this.lblPassengerBookingManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassengerBookingManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerBookingManage.Location = new System.Drawing.Point(315, 10);
            this.lblPassengerBookingManage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerBookingManage.Name = "lblPassengerBookingManage";
            this.lblPassengerBookingManage.Size = new System.Drawing.Size(816, 63);
            this.lblPassengerBookingManage.TabIndex = 1;
            this.lblPassengerBookingManage.Text = "Manage Bookings";
            this.lblPassengerBookingManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassengerBookingInfo
            // 
            this.lblPassengerBookingInfo.AutoSize = true;
            this.lblPassengerBookingInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassengerBookingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerBookingInfo.Location = new System.Drawing.Point(7, 10);
            this.lblPassengerBookingInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerBookingInfo.Name = "lblPassengerBookingInfo";
            this.lblPassengerBookingInfo.Size = new System.Drawing.Size(295, 63);
            this.lblPassengerBookingInfo.TabIndex = 0;
            this.lblPassengerBookingInfo.Text = "Bookings";
            this.lblPassengerBookingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPassengerBookingInfo.Click += new System.EventHandler(this.lblPassengerBookingInfo_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 1125);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Booking";
            this.Text = "Booking";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerBooking)).EndInit();
            this.pnlPassengerBookingManage.ResumeLayout(false);
            this.pnlPassengerBookingManage.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPassengerBooking;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPassengerBookingFlightDestination;
        private System.Windows.Forms.Panel pnlPassengerBookingManage;
        private System.Windows.Forms.Label lblPassengerBookingFlightSeat;
        private System.Windows.Forms.RadioButton rdbCancelled;
        private System.Windows.Forms.RadioButton rdbPending;
        private System.Windows.Forms.RadioButton rdbConfirmed;
        private System.Windows.Forms.Label lblPassengerBookingPassengerId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dtpBDate;
        private System.Windows.Forms.Label lblPassengerBookingId;
        private System.Windows.Forms.Label lblPassengerBookingDate;
        private System.Windows.Forms.Label lblPassengerBookingStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPassengerBookingManage;
        private System.Windows.Forms.Label lblPassengerBookingInfo;
        private System.Windows.Forms.TextBox txtPId;
        private System.Windows.Forms.TextBox txtBId;
        private System.Windows.Forms.ComboBox comboSeat;
        private System.Windows.Forms.TextBox txtDst;
    }
}