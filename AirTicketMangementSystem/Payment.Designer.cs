namespace AirTicketMangementSystem
{
    partial class Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPassengerPaymentId = new System.Windows.Forms.Label();
            this.lblPassengerPaymentManage = new System.Windows.Forms.Label();
            this.lblPassengerPaymentInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPassengerPaymentManage = new System.Windows.Forms.Panel();
            this.txtPA = new System.Windows.Forms.TextBox();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.txtPAId = new System.Windows.Forms.TextBox();
            this.lblPassengerPaymentPassengerId = new System.Windows.Forms.Label();
            this.rdbCancelled = new System.Windows.Forms.RadioButton();
            this.rdbPending = new System.Windows.Forms.RadioButton();
            this.rdbPaid = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPassengerPaymentPay = new System.Windows.Forms.Button();
            this.lblPassengerPaymentDate = new System.Windows.Forms.Label();
            this.dtpPassengerPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblPassengerPaymentStatus = new System.Windows.Forms.Label();
            this.lblPassengerPaymentAmount = new System.Windows.Forms.Label();
            this.dgvPassengerPayment = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlPassengerPaymentManage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassengerPaymentId
            // 
            this.lblPassengerPaymentId.AutoSize = true;
            this.lblPassengerPaymentId.Location = new System.Drawing.Point(114, 46);
            this.lblPassengerPaymentId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerPaymentId.Name = "lblPassengerPaymentId";
            this.lblPassengerPaymentId.Size = new System.Drawing.Size(209, 37);
            this.lblPassengerPaymentId.TabIndex = 0;
            this.lblPassengerPaymentId.Text = "Payment ID : ";
            this.lblPassengerPaymentId.Click += new System.EventHandler(this.lblPId_Click);
            // 
            // lblPassengerPaymentManage
            // 
            this.lblPassengerPaymentManage.AutoSize = true;
            this.lblPassengerPaymentManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassengerPaymentManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerPaymentManage.Location = new System.Drawing.Point(297, 18);
            this.lblPassengerPaymentManage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerPaymentManage.Name = "lblPassengerPaymentManage";
            this.lblPassengerPaymentManage.Size = new System.Drawing.Size(820, 171);
            this.lblPassengerPaymentManage.TabIndex = 1;
            this.lblPassengerPaymentManage.Text = "Manage Payments";
            this.lblPassengerPaymentManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassengerPaymentInfo
            // 
            this.lblPassengerPaymentInfo.AutoSize = true;
            this.lblPassengerPaymentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassengerPaymentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerPaymentInfo.Location = new System.Drawing.Point(7, 18);
            this.lblPassengerPaymentInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerPaymentInfo.Name = "lblPassengerPaymentInfo";
            this.lblPassengerPaymentInfo.Size = new System.Drawing.Size(277, 171);
            this.lblPassengerPaymentInfo.TabIndex = 0;
            this.lblPassengerPaymentInfo.Text = "Payment Info";
            this.lblPassengerPaymentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 832F));
            this.tableLayoutPanel1.Controls.Add(this.pnlPassengerPaymentManage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPassengerPaymentManage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPassengerPaymentInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvPassengerPayment, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1124, 909);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pnlPassengerPaymentManage
            // 
            this.pnlPassengerPaymentManage.Controls.Add(this.txtPA);
            this.pnlPassengerPaymentManage.Controls.Add(this.txtPId);
            this.pnlPassengerPaymentManage.Controls.Add(this.txtPAId);
            this.pnlPassengerPaymentManage.Controls.Add(this.lblPassengerPaymentPassengerId);
            this.pnlPassengerPaymentManage.Controls.Add(this.rdbCancelled);
            this.pnlPassengerPaymentManage.Controls.Add(this.rdbPending);
            this.pnlPassengerPaymentManage.Controls.Add(this.rdbPaid);
            this.pnlPassengerPaymentManage.Controls.Add(this.tableLayoutPanel2);
            this.pnlPassengerPaymentManage.Controls.Add(this.lblPassengerPaymentDate);
            this.pnlPassengerPaymentManage.Controls.Add(this.dtpPassengerPaymentDate);
            this.pnlPassengerPaymentManage.Controls.Add(this.lblPassengerPaymentStatus);
            this.pnlPassengerPaymentManage.Controls.Add(this.lblPassengerPaymentAmount);
            this.pnlPassengerPaymentManage.Controls.Add(this.lblPassengerPaymentId);
            this.pnlPassengerPaymentManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPassengerPaymentManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPassengerPaymentManage.Location = new System.Drawing.Point(297, 196);
            this.pnlPassengerPaymentManage.Margin = new System.Windows.Forms.Padding(6);
            this.pnlPassengerPaymentManage.Name = "pnlPassengerPaymentManage";
            this.pnlPassengerPaymentManage.Size = new System.Drawing.Size(820, 706);
            this.pnlPassengerPaymentManage.TabIndex = 3;
            this.pnlPassengerPaymentManage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPassengerPaymentManage_Paint);
            // 
            // txtPA
            // 
            this.txtPA.Location = new System.Drawing.Point(319, 171);
            this.txtPA.Name = "txtPA";
            this.txtPA.Size = new System.Drawing.Size(449, 44);
            this.txtPA.TabIndex = 37;
            this.txtPA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPAKeyPress);
            // 
            // txtPId
            // 
            this.txtPId.Location = new System.Drawing.Point(319, 111);
            this.txtPId.Name = "txtPId";
            this.txtPId.Size = new System.Drawing.Size(449, 44);
            this.txtPId.TabIndex = 36;
            this.txtPId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPIdKeyPress);
            // 
            // txtPAId
            // 
            this.txtPAId.Location = new System.Drawing.Point(319, 46);
            this.txtPAId.Name = "txtPAId";
            this.txtPAId.Size = new System.Drawing.Size(449, 44);
            this.txtPAId.TabIndex = 35;
            this.txtPAId.TextChanged += new System.EventHandler(this.txtPAId_TextChanged);
            this.txtPAId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPAIdKeyPress);
            // 
            // lblPassengerPaymentPassengerId
            // 
            this.lblPassengerPaymentPassengerId.AutoSize = true;
            this.lblPassengerPaymentPassengerId.Location = new System.Drawing.Point(87, 111);
            this.lblPassengerPaymentPassengerId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerPaymentPassengerId.Name = "lblPassengerPaymentPassengerId";
            this.lblPassengerPaymentPassengerId.Size = new System.Drawing.Size(236, 37);
            this.lblPassengerPaymentPassengerId.TabIndex = 34;
            this.lblPassengerPaymentPassengerId.Text = "Passenger ID : ";
            // 
            // rdbCancelled
            // 
            this.rdbCancelled.AutoSize = true;
            this.rdbCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCancelled.Location = new System.Drawing.Point(602, 310);
            this.rdbCancelled.Margin = new System.Windows.Forms.Padding(6);
            this.rdbCancelled.Name = "rdbCancelled";
            this.rdbCancelled.Size = new System.Drawing.Size(166, 35);
            this.rdbCancelled.TabIndex = 19;
            this.rdbCancelled.TabStop = true;
            this.rdbCancelled.Text = "Cancelled";
            this.rdbCancelled.UseVisualStyleBackColor = true;
            // 
            // rdbPending
            // 
            this.rdbPending.AutoSize = true;
            this.rdbPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPending.Location = new System.Drawing.Point(439, 310);
            this.rdbPending.Margin = new System.Windows.Forms.Padding(6);
            this.rdbPending.Name = "rdbPending";
            this.rdbPending.Size = new System.Drawing.Size(144, 35);
            this.rdbPending.TabIndex = 18;
            this.rdbPending.TabStop = true;
            this.rdbPending.Text = "Pending";
            this.rdbPending.UseVisualStyleBackColor = true;
            // 
            // rdbPaid
            // 
            this.rdbPaid.AutoSize = true;
            this.rdbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPaid.Location = new System.Drawing.Point(328, 310);
            this.rdbPaid.Margin = new System.Windows.Forms.Padding(6);
            this.rdbPaid.Name = "rdbPaid";
            this.rdbPaid.Size = new System.Drawing.Size(99, 35);
            this.rdbPaid.TabIndex = 17;
            this.rdbPaid.TabStop = true;
            this.rdbPaid.Text = "Paid";
            this.rdbPaid.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Controls.Add(this.btnPassengerPaymentPay, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(45, 378);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(742, 77);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // btnPassengerPaymentPay
            // 
            this.btnPassengerPaymentPay.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPassengerPaymentPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassengerPaymentPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerPaymentPay.Location = new System.Drawing.Point(6, 6);
            this.btnPassengerPaymentPay.Margin = new System.Windows.Forms.Padding(6);
            this.btnPassengerPaymentPay.Name = "btnPassengerPaymentPay";
            this.btnPassengerPaymentPay.Size = new System.Drawing.Size(730, 65);
            this.btnPassengerPaymentPay.TabIndex = 3;
            this.btnPassengerPaymentPay.Text = "Pay";
            this.btnPassengerPaymentPay.UseVisualStyleBackColor = false;
            this.btnPassengerPaymentPay.Click += new System.EventHandler(this.btnPassengerPaymentPay_Click);
            // 
            // lblPassengerPaymentDate
            // 
            this.lblPassengerPaymentDate.AutoSize = true;
            this.lblPassengerPaymentDate.Location = new System.Drawing.Point(87, 240);
            this.lblPassengerPaymentDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerPaymentDate.Name = "lblPassengerPaymentDate";
            this.lblPassengerPaymentDate.Size = new System.Drawing.Size(245, 37);
            this.lblPassengerPaymentDate.TabIndex = 14;
            this.lblPassengerPaymentDate.Text = "Payment Date : ";
            // 
            // dtpPassengerPaymentDate
            // 
            this.dtpPassengerPaymentDate.CustomFormat = "yyyy-MM-dd";
            this.dtpPassengerPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPassengerPaymentDate.Location = new System.Drawing.Point(328, 240);
            this.dtpPassengerPaymentDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpPassengerPaymentDate.Name = "dtpPassengerPaymentDate";
            this.dtpPassengerPaymentDate.Size = new System.Drawing.Size(440, 44);
            this.dtpPassengerPaymentDate.TabIndex = 12;
            // 
            // lblPassengerPaymentStatus
            // 
            this.lblPassengerPaymentStatus.AutoSize = true;
            this.lblPassengerPaymentStatus.Location = new System.Drawing.Point(63, 308);
            this.lblPassengerPaymentStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerPaymentStatus.Name = "lblPassengerPaymentStatus";
            this.lblPassengerPaymentStatus.Size = new System.Drawing.Size(269, 37);
            this.lblPassengerPaymentStatus.TabIndex = 10;
            this.lblPassengerPaymentStatus.Text = "Payment Status : ";
            // 
            // lblPassengerPaymentAmount
            // 
            this.lblPassengerPaymentAmount.AutoSize = true;
            this.lblPassengerPaymentAmount.Location = new System.Drawing.Point(38, 174);
            this.lblPassengerPaymentAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerPaymentAmount.Name = "lblPassengerPaymentAmount";
            this.lblPassengerPaymentAmount.Size = new System.Drawing.Size(299, 37);
            this.lblPassengerPaymentAmount.TabIndex = 2;
            this.lblPassengerPaymentAmount.Text = "Payment Amount :  ";
            // 
            // dgvPassengerPayment
            // 
            this.dgvPassengerPayment.AllowUserToAddRows = false;
            this.dgvPassengerPayment.AllowUserToDeleteRows = false;
            this.dgvPassengerPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPassengerPayment.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPassengerPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPassengerPayment.Location = new System.Drawing.Point(7, 196);
            this.dgvPassengerPayment.Margin = new System.Windows.Forms.Padding(6);
            this.dgvPassengerPayment.Name = "dgvPassengerPayment";
            this.dgvPassengerPayment.ReadOnly = true;
            this.dgvPassengerPayment.RowHeadersWidth = 82;
            this.dgvPassengerPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassengerPayment.Size = new System.Drawing.Size(277, 706);
            this.dgvPassengerPayment.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 909);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlPassengerPaymentManage.ResumeLayout(false);
            this.pnlPassengerPaymentManage.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPassengerPaymentId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPassengerPaymentManage;
        private System.Windows.Forms.Label lblPassengerPaymentInfo;
        private System.Windows.Forms.Panel pnlPassengerPaymentManage;
        private System.Windows.Forms.Label lblPassengerPaymentPassengerId;
        private System.Windows.Forms.RadioButton rdbCancelled;
        private System.Windows.Forms.RadioButton rdbPending;
        private System.Windows.Forms.RadioButton rdbPaid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnPassengerPaymentPay;
        private System.Windows.Forms.Label lblPassengerPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPassengerPaymentDate;
        private System.Windows.Forms.Label lblPassengerPaymentStatus;
        private System.Windows.Forms.Label lblPassengerPaymentAmount;
        private System.Windows.Forms.DataGridView dgvPassengerPayment;
        private System.Windows.Forms.TextBox txtPA;
        private System.Windows.Forms.TextBox txtPId;
        private System.Windows.Forms.TextBox txtPAId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}