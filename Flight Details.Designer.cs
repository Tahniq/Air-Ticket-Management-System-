namespace AirTicketManagementSystem
{
    partial class FlightDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightDetails));
            this.cmbDprt = new System.Windows.Forms.ComboBox();
            this.cmbArvl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvFd = new System.Windows.Forms.DataGridView();
            this.Route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFd)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDprt
            // 
            this.cmbDprt.FormattingEnabled = true;
            this.cmbDprt.Items.AddRange(new object[] {
            "Chittagong",
            "Dhaka ",
            "Sylhet",
            "Rangpur",
            "Rajshahi",
            "Barisal",
            "Jessore "});
            this.cmbDprt.Location = new System.Drawing.Point(545, 196);
            this.cmbDprt.Name = "cmbDprt";
            this.cmbDprt.Size = new System.Drawing.Size(416, 28);
            this.cmbDprt.TabIndex = 0;
            // 
            // cmbArvl
            // 
            this.cmbArvl.FormattingEnabled = true;
            this.cmbArvl.Items.AddRange(new object[] {
            "Chittagong ",
            "Dhaka ",
            "Sylhet",
            "Rangpur",
            "Rajshahi",
            "Jessore ",
            "Barishal"});
            this.cmbArvl.Location = new System.Drawing.Point(545, 298);
            this.cmbArvl.Name = "cmbArvl";
            this.cmbArvl.Size = new System.Drawing.Size(416, 28);
            this.cmbArvl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departure from : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arrival to :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 4;
            // 
            // dgvFd
            // 
            this.dgvFd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Route,
            this.Seats,
            this.Status});
            this.dgvFd.Location = new System.Drawing.Point(109, 363);
            this.dgvFd.Name = "dgvFd";
            this.dgvFd.RowHeadersWidth = 62;
            this.dgvFd.RowTemplate.Height = 28;
            this.dgvFd.Size = new System.Drawing.Size(932, 168);
            this.dgvFd.TabIndex = 6;
            // 
            // Route
            // 
            this.Route.HeaderText = "Route";
            this.Route.MinimumWidth = 8;
            this.Route.Name = "Route";
            this.Route.Width = 150;
            // 
            // Seats
            // 
            this.Seats.HeaderText = "Seats";
            this.Seats.MinimumWidth = 8;
            this.Seats.Name = "Seats";
            this.Seats.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 62);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(593, 566);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 62);
            this.button2.TabIndex = 8;
            this.button2.Text = "proceed to booking";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FlightDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1128, 708);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvFd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbArvl);
            this.Controls.Add(this.cmbDprt);
            this.Name = "FlightDetails";
            this.Text = "FlightDetails";
            this.Load += new System.EventHandler(this.FlightDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDprt;
        private System.Windows.Forms.ComboBox cmbArvl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Route;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button button2;
    }
}