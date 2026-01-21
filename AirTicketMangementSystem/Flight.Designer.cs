namespace AirTicketMangementSystem
{
    partial class Flight
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.rdbDelayed = new System.Windows.Forms.RadioButton();
            this.rdbOnTime = new System.Windows.Forms.RadioButton();
            this.txtDstn = new System.Windows.Forms.TextBox();
            this.txtOr = new System.Windows.Forms.TextBox();
            this.txtFNo = new System.Windows.Forms.TextBox();
            this.txtFId = new System.Windows.Forms.TextBox();
            this.lblPassengerFlightArrivalTime = new System.Windows.Forms.Label();
            this.lblPassengerFlightDepartureTIme = new System.Windows.Forms.Label();
            this.lblPassengerFlightStatus = new System.Windows.Forms.Label();
            this.lblPassengerFlightDestination = new System.Windows.Forms.Label();
            this.lblPassengerFlightOrigin = new System.Windows.Forms.Label();
            this.lblPassengerFlightNo = new System.Windows.Forms.Label();
            this.lblPassengerFlightId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpArrivalTime);
            this.panel1.Controls.Add(this.dtpDepartureTime);
            this.panel1.Controls.Add(this.rdbDelayed);
            this.panel1.Controls.Add(this.rdbOnTime);
            this.panel1.Controls.Add(this.txtDstn);
            this.panel1.Controls.Add(this.txtOr);
            this.panel1.Controls.Add(this.txtFNo);
            this.panel1.Controls.Add(this.txtFId);
            this.panel1.Controls.Add(this.lblPassengerFlightArrivalTime);
            this.panel1.Controls.Add(this.lblPassengerFlightDepartureTIme);
            this.panel1.Controls.Add(this.lblPassengerFlightStatus);
            this.panel1.Controls.Add(this.lblPassengerFlightDestination);
            this.panel1.Controls.Add(this.lblPassengerFlightOrigin);
            this.panel1.Controls.Add(this.lblPassengerFlightNo);
            this.panel1.Controls.Add(this.lblPassengerFlightId);
            this.panel1.Location = new System.Drawing.Point(42, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 560);
            this.panel1.TabIndex = 4;
            // 
            // dtpArrivalTime
            // 
            this.dtpArrivalTime.Location = new System.Drawing.Point(191, 485);
            this.dtpArrivalTime.Name = "dtpArrivalTime";
            this.dtpArrivalTime.Size = new System.Drawing.Size(311, 31);
            this.dtpArrivalTime.TabIndex = 14;
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Location = new System.Drawing.Point(191, 422);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.Size = new System.Drawing.Size(311, 31);
            this.dtpDepartureTime.TabIndex = 13;
            this.dtpDepartureTime.ValueChanged += new System.EventHandler(this.dtpPassengerFlightDepartureTime_ValueChanged);
            // 
            // rdbDelayed
            // 
            this.rdbDelayed.AutoSize = true;
            this.rdbDelayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDelayed.Location = new System.Drawing.Point(331, 348);
            this.rdbDelayed.Name = "rdbDelayed";
            this.rdbDelayed.Size = new System.Drawing.Size(129, 29);
            this.rdbDelayed.TabIndex = 12;
            this.rdbDelayed.TabStop = true;
            this.rdbDelayed.Text = "Delayed";
            this.rdbDelayed.UseVisualStyleBackColor = true;
            // 
            // rdbOnTime
            // 
            this.rdbOnTime.AutoSize = true;
            this.rdbOnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOnTime.Location = new System.Drawing.Point(168, 348);
            this.rdbOnTime.Name = "rdbOnTime";
            this.rdbOnTime.Size = new System.Drawing.Size(124, 29);
            this.rdbOnTime.TabIndex = 11;
            this.rdbOnTime.TabStop = true;
            this.rdbOnTime.Text = "OnTime";
            this.rdbOnTime.UseVisualStyleBackColor = true;
            // 
            // txtDstn
            // 
            this.txtDstn.Location = new System.Drawing.Point(168, 281);
            this.txtDstn.Name = "txtDstn";
            this.txtDstn.Size = new System.Drawing.Size(246, 31);
            this.txtDstn.TabIndex = 10;
            this.txtDstn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDstnKeyPress);
            // 
            // txtOr
            // 
            this.txtOr.Location = new System.Drawing.Point(168, 195);
            this.txtOr.Name = "txtOr";
            this.txtOr.Size = new System.Drawing.Size(246, 31);
            this.txtOr.TabIndex = 9;
            this.txtOr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrKeyPress);
            // 
            // txtFNo
            // 
            this.txtFNo.Location = new System.Drawing.Point(168, 118);
            this.txtFNo.Name = "txtFNo";
            this.txtFNo.Size = new System.Drawing.Size(246, 31);
            this.txtFNo.TabIndex = 8;
            // 
            // txtFId
            // 
            this.txtFId.Location = new System.Drawing.Point(168, 32);
            this.txtFId.Name = "txtFId";
            this.txtFId.Size = new System.Drawing.Size(246, 31);
            this.txtFId.TabIndex = 7;
            this.txtFId.TextChanged += new System.EventHandler(this.txtFId_TextChanged);
            this.txtFId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFId_KeyPress);
            // 
            // lblPassengerFlightArrivalTime
            // 
            this.lblPassengerFlightArrivalTime.AutoSize = true;
            this.lblPassengerFlightArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerFlightArrivalTime.Location = new System.Drawing.Point(14, 491);
            this.lblPassengerFlightArrivalTime.Name = "lblPassengerFlightArrivalTime";
            this.lblPassengerFlightArrivalTime.Size = new System.Drawing.Size(131, 25);
            this.lblPassengerFlightArrivalTime.TabIndex = 6;
            this.lblPassengerFlightArrivalTime.Text = "ArrivalTime";
            // 
            // lblPassengerFlightDepartureTIme
            // 
            this.lblPassengerFlightDepartureTIme.AutoSize = true;
            this.lblPassengerFlightDepartureTIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerFlightDepartureTIme.Location = new System.Drawing.Point(14, 422);
            this.lblPassengerFlightDepartureTIme.Name = "lblPassengerFlightDepartureTIme";
            this.lblPassengerFlightDepartureTIme.Size = new System.Drawing.Size(167, 25);
            this.lblPassengerFlightDepartureTIme.TabIndex = 5;
            this.lblPassengerFlightDepartureTIme.Text = "DepartureTIme";
            // 
            // lblPassengerFlightStatus
            // 
            this.lblPassengerFlightStatus.AutoSize = true;
            this.lblPassengerFlightStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerFlightStatus.Location = new System.Drawing.Point(14, 352);
            this.lblPassengerFlightStatus.Name = "lblPassengerFlightStatus";
            this.lblPassengerFlightStatus.Size = new System.Drawing.Size(138, 25);
            this.lblPassengerFlightStatus.TabIndex = 4;
            this.lblPassengerFlightStatus.Text = "FlightStatus";
            // 
            // lblPassengerFlightDestination
            // 
            this.lblPassengerFlightDestination.AutoSize = true;
            this.lblPassengerFlightDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerFlightDestination.Location = new System.Drawing.Point(14, 281);
            this.lblPassengerFlightDestination.Name = "lblPassengerFlightDestination";
            this.lblPassengerFlightDestination.Size = new System.Drawing.Size(131, 25);
            this.lblPassengerFlightDestination.TabIndex = 3;
            this.lblPassengerFlightDestination.Text = "Destination";
            // 
            // lblPassengerFlightOrigin
            // 
            this.lblPassengerFlightOrigin.AutoSize = true;
            this.lblPassengerFlightOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerFlightOrigin.Location = new System.Drawing.Point(60, 198);
            this.lblPassengerFlightOrigin.Name = "lblPassengerFlightOrigin";
            this.lblPassengerFlightOrigin.Size = new System.Drawing.Size(75, 25);
            this.lblPassengerFlightOrigin.TabIndex = 2;
            this.lblPassengerFlightOrigin.Text = "Origin";
            // 
            // lblPassengerFlightNo
            // 
            this.lblPassengerFlightNo.AutoSize = true;
            this.lblPassengerFlightNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerFlightNo.Location = new System.Drawing.Point(45, 118);
            this.lblPassengerFlightNo.Name = "lblPassengerFlightNo";
            this.lblPassengerFlightNo.Size = new System.Drawing.Size(100, 25);
            this.lblPassengerFlightNo.TabIndex = 1;
            this.lblPassengerFlightNo.Text = "FlightNo";
            // 
            // lblPassengerFlightId
            // 
            this.lblPassengerFlightId.AutoSize = true;
            this.lblPassengerFlightId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerFlightId.Location = new System.Drawing.Point(45, 32);
            this.lblPassengerFlightId.Name = "lblPassengerFlightId";
            this.lblPassengerFlightId.Size = new System.Drawing.Size(90, 25);
            this.lblPassengerFlightId.TabIndex = 0;
            this.lblPassengerFlightId.Text = "FlightId";
            this.lblPassengerFlightId.Click += new System.EventHandler(this.lblPassengerFlightId_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(595, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(502, 560);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(281, 647);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(128, 34);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 693);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Flight";
            this.Text = "Flight";
            this.Load += new System.EventHandler(this.Flight_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPassengerFlightDepartureTIme;
        private System.Windows.Forms.Label lblPassengerFlightStatus;
        private System.Windows.Forms.Label lblPassengerFlightDestination;
        private System.Windows.Forms.Label lblPassengerFlightOrigin;
        private System.Windows.Forms.Label lblPassengerFlightNo;
        private System.Windows.Forms.Label lblPassengerFlightId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdbOnTime;
        private System.Windows.Forms.TextBox txtDstn;
        private System.Windows.Forms.TextBox txtOr;
        private System.Windows.Forms.TextBox txtFNo;
        private System.Windows.Forms.TextBox txtFId;
        private System.Windows.Forms.Label lblPassengerFlightArrivalTime;
        private System.Windows.Forms.DateTimePicker dtpArrivalTime;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.RadioButton rdbDelayed;
        private System.Windows.Forms.Button btnOK;
    }
}