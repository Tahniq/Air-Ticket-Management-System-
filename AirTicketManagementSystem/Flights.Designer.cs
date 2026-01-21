namespace AirTicketManagementSystem
{
    partial class Flights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flights));
            this.dgvF = new System.Windows.Forms.DataGridView();
            this.txttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtseat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtfare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnbticket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvF)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvF
            // 
            this.dgvF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txttime,
            this.txtseat,
            this.txtfare,
            this.TotalFare});
            this.dgvF.Location = new System.Drawing.Point(106, 159);
            this.dgvF.Name = "dgvF";
            this.dgvF.RowHeadersWidth = 62;
            this.dgvF.RowTemplate.Height = 28;
            this.dgvF.Size = new System.Drawing.Size(618, 227);
            this.dgvF.TabIndex = 0;
            // 
            // txttime
            // 
            this.txttime.HeaderText = "Time";
            this.txttime.MinimumWidth = 8;
            this.txttime.Name = "txttime";
            this.txttime.Width = 150;
            // 
            // txtseat
            // 
            this.txtseat.HeaderText = "Seat";
            this.txtseat.MinimumWidth = 8;
            this.txtseat.Name = "txtseat";
            this.txtseat.Width = 150;
            // 
            // txtfare
            // 
            this.txtfare.HeaderText = "Fare";
            this.txtfare.MinimumWidth = 8;
            this.txtfare.Name = "txtfare";
            this.txtfare.Width = 150;
            // 
            // TotalFare
            // 
            this.TotalFare.HeaderText = "Total Fare";
            this.TotalFare.MinimumWidth = 8;
            this.TotalFare.Name = "TotalFare";
            this.TotalFare.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnbticket
            // 
            this.btnbticket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbticket.Location = new System.Drawing.Point(417, 407);
            this.btnbticket.Name = "btnbticket";
            this.btnbticket.Size = new System.Drawing.Size(185, 71);
            this.btnbticket.TabIndex = 2;
            this.btnbticket.Text = "Book Ticket";
            this.btnbticket.UseVisualStyleBackColor = true;
            this.btnbticket.Click += new System.EventHandler(this.button2_Click);
            // 
            // Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(761, 708);
            this.Controls.Add(this.btnbticket);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvF);
            this.Name = "Flights";
            this.Text = "Flights";
            this.Load += new System.EventHandler(this.Flights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvF;
        private System.Windows.Forms.DataGridViewTextBoxColumn txttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtseat;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtfare;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFare;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnbticket;
    }
}