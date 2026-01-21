namespace AirTicketMangementSystem
{
    partial class Refund
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPassengerRefundManage = new System.Windows.Forms.Label();
            this.lblPassengerRefundInfo = new System.Windows.Forms.Label();
            this.pnlPassengerRefundManage = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtRId = new System.Windows.Forms.TextBox();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.lblPassengerRefundPaymentId = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPassengerRefundPay = new System.Windows.Forms.Button();
            this.lblPassengerRefundDate = new System.Windows.Forms.Label();
            this.dtpRD = new System.Windows.Forms.DateTimePicker();
            this.lblPassengerRefundAmount = new System.Windows.Forms.Label();
            this.lblPassengerRefundId = new System.Windows.Forms.Label();
            this.dgvPassengerRefund = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlPassengerRefundManage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerRefund)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 834F));
            this.tableLayoutPanel1.Controls.Add(this.lblPassengerRefundManage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPassengerRefundInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlPassengerRefundManage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvPassengerRefund, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1130, 936);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblPassengerRefundManage
            // 
            this.lblPassengerRefundManage.AutoSize = true;
            this.lblPassengerRefundManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassengerRefundManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerRefundManage.Location = new System.Drawing.Point(301, 10);
            this.lblPassengerRefundManage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerRefundManage.Name = "lblPassengerRefundManage";
            this.lblPassengerRefundManage.Size = new System.Drawing.Size(822, 121);
            this.lblPassengerRefundManage.TabIndex = 1;
            this.lblPassengerRefundManage.Text = "Manage Refund";
            this.lblPassengerRefundManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassengerRefundInfo
            // 
            this.lblPassengerRefundInfo.AutoSize = true;
            this.lblPassengerRefundInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassengerRefundInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerRefundInfo.Location = new System.Drawing.Point(7, 10);
            this.lblPassengerRefundInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerRefundInfo.Name = "lblPassengerRefundInfo";
            this.lblPassengerRefundInfo.Size = new System.Drawing.Size(281, 121);
            this.lblPassengerRefundInfo.TabIndex = 0;
            this.lblPassengerRefundInfo.Text = "Refund Info";
            this.lblPassengerRefundInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPassengerRefundManage
            // 
            this.pnlPassengerRefundManage.Controls.Add(this.button1);
            this.pnlPassengerRefundManage.Controls.Add(this.txtRA);
            this.pnlPassengerRefundManage.Controls.Add(this.txtRId);
            this.pnlPassengerRefundManage.Controls.Add(this.txtPId);
            this.pnlPassengerRefundManage.Controls.Add(this.lblPassengerRefundPaymentId);
            this.pnlPassengerRefundManage.Controls.Add(this.tableLayoutPanel2);
            this.pnlPassengerRefundManage.Controls.Add(this.lblPassengerRefundDate);
            this.pnlPassengerRefundManage.Controls.Add(this.dtpRD);
            this.pnlPassengerRefundManage.Controls.Add(this.lblPassengerRefundAmount);
            this.pnlPassengerRefundManage.Controls.Add(this.lblPassengerRefundId);
            this.pnlPassengerRefundManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPassengerRefundManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPassengerRefundManage.Location = new System.Drawing.Point(301, 138);
            this.pnlPassengerRefundManage.Margin = new System.Windows.Forms.Padding(6);
            this.pnlPassengerRefundManage.Name = "pnlPassengerRefundManage";
            this.pnlPassengerRefundManage.Size = new System.Drawing.Size(822, 791);
            this.pnlPassengerRefundManage.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(227, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 57);
            this.button1.TabIndex = 41;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(324, 242);
            this.txtRA.Margin = new System.Windows.Forms.Padding(6);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(440, 44);
            this.txtRA.TabIndex = 40;
            this.txtRA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRAKeyPress);
            // 
            // txtRId
            // 
            this.txtRId.Location = new System.Drawing.Point(324, 142);
            this.txtRId.Margin = new System.Windows.Forms.Padding(6);
            this.txtRId.Name = "txtRId";
            this.txtRId.Size = new System.Drawing.Size(440, 44);
            this.txtRId.TabIndex = 39;
            this.txtRId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRIdKeyPress);
            // 
            // txtPId
            // 
            this.txtPId.Location = new System.Drawing.Point(324, 55);
            this.txtPId.Margin = new System.Windows.Forms.Padding(6);
            this.txtPId.Name = "txtPId";
            this.txtPId.Size = new System.Drawing.Size(440, 44);
            this.txtPId.TabIndex = 38;
            this.txtPId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPIdKeyPress);
            // 
            // lblPassengerRefundPaymentId
            // 
            this.lblPassengerRefundPaymentId.AutoSize = true;
            this.lblPassengerRefundPaymentId.Location = new System.Drawing.Point(113, 55);
            this.lblPassengerRefundPaymentId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerRefundPaymentId.Name = "lblPassengerRefundPaymentId";
            this.lblPassengerRefundPaymentId.Size = new System.Drawing.Size(209, 37);
            this.lblPassengerRefundPaymentId.TabIndex = 36;
            this.lblPassengerRefundPaymentId.Text = "Payment ID : ";
            this.lblPassengerRefundPaymentId.Click += new System.EventHandler(this.lblPIdClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Controls.Add(this.btnPassengerRefundPay, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(39, 406);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(742, 77);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // btnPassengerRefundPay
            // 
            this.btnPassengerRefundPay.BackColor = System.Drawing.Color.LightBlue;
            this.btnPassengerRefundPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassengerRefundPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerRefundPay.Location = new System.Drawing.Point(6, 6);
            this.btnPassengerRefundPay.Margin = new System.Windows.Forms.Padding(6);
            this.btnPassengerRefundPay.Name = "btnPassengerRefundPay";
            this.btnPassengerRefundPay.Size = new System.Drawing.Size(730, 65);
            this.btnPassengerRefundPay.TabIndex = 4;
            this.btnPassengerRefundPay.Text = "Request for a Refund";
            this.btnPassengerRefundPay.UseVisualStyleBackColor = false;
            this.btnPassengerRefundPay.Click += new System.EventHandler(this.btnPassengerRefundPay_Click);
            // 
            // lblPassengerRefundDate
            // 
            this.lblPassengerRefundDate.AutoSize = true;
            this.lblPassengerRefundDate.Location = new System.Drawing.Point(90, 329);
            this.lblPassengerRefundDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerRefundDate.Name = "lblPassengerRefundDate";
            this.lblPassengerRefundDate.Size = new System.Drawing.Size(222, 37);
            this.lblPassengerRefundDate.TabIndex = 14;
            this.lblPassengerRefundDate.Text = "Refund Date : ";
            // 
            // dtpRD
            // 
            this.dtpRD.CustomFormat = "yyyy-MM-dd";
            this.dtpRD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRD.Location = new System.Drawing.Point(324, 327);
            this.dtpRD.Margin = new System.Windows.Forms.Padding(6);
            this.dtpRD.Name = "dtpRD";
            this.dtpRD.Size = new System.Drawing.Size(440, 44);
            this.dtpRD.TabIndex = 12;
            // 
            // lblPassengerRefundAmount
            // 
            this.lblPassengerRefundAmount.AutoSize = true;
            this.lblPassengerRefundAmount.Location = new System.Drawing.Point(46, 242);
            this.lblPassengerRefundAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerRefundAmount.Name = "lblPassengerRefundAmount";
            this.lblPassengerRefundAmount.Size = new System.Drawing.Size(276, 37);
            this.lblPassengerRefundAmount.TabIndex = 2;
            this.lblPassengerRefundAmount.Text = "Refund Amount :  ";
            // 
            // lblPassengerRefundId
            // 
            this.lblPassengerRefundId.AutoSize = true;
            this.lblPassengerRefundId.Location = new System.Drawing.Point(126, 142);
            this.lblPassengerRefundId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassengerRefundId.Name = "lblPassengerRefundId";
            this.lblPassengerRefundId.Size = new System.Drawing.Size(186, 37);
            this.lblPassengerRefundId.TabIndex = 0;
            this.lblPassengerRefundId.Text = "Refund ID : ";
            // 
            // dgvPassengerRefund
            // 
            this.dgvPassengerRefund.AllowUserToAddRows = false;
            this.dgvPassengerRefund.AllowUserToDeleteRows = false;
            this.dgvPassengerRefund.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPassengerRefund.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPassengerRefund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPassengerRefund.Location = new System.Drawing.Point(7, 138);
            this.dgvPassengerRefund.Margin = new System.Windows.Forms.Padding(6);
            this.dgvPassengerRefund.Name = "dgvPassengerRefund";
            this.dgvPassengerRefund.ReadOnly = true;
            this.dgvPassengerRefund.RowHeadersWidth = 82;
            this.dgvPassengerRefund.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassengerRefund.Size = new System.Drawing.Size(281, 791);
            this.dgvPassengerRefund.TabIndex = 4;
            // 
            // Refund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 936);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Refund";
            this.Text = "Refund";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlPassengerRefundManage.ResumeLayout(false);
            this.pnlPassengerRefundManage.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerRefund)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPassengerRefundManage;
        private System.Windows.Forms.Label lblPassengerRefundInfo;
        private System.Windows.Forms.Panel pnlPassengerRefundManage;
        private System.Windows.Forms.Label lblPassengerRefundPaymentId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnPassengerRefundPay;
        private System.Windows.Forms.Label lblPassengerRefundDate;
        private System.Windows.Forms.DateTimePicker dtpRD;
        private System.Windows.Forms.Label lblPassengerRefundAmount;
        private System.Windows.Forms.Label lblPassengerRefundId;
        private System.Windows.Forms.DataGridView dgvPassengerRefund;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.TextBox txtRId;
        private System.Windows.Forms.TextBox txtPId;
        private System.Windows.Forms.Button button1;
    }
}