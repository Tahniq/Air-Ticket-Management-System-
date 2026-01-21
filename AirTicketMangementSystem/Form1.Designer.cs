namespace AirTicketMangementSystem
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
            this.lblPassengerPanelText = new System.Windows.Forms.Label();
            this.btnPassengerFlight = new System.Windows.Forms.Button();
            this.btnPassengerBooking = new System.Windows.Forms.Button();
            this.btnPassengerPayment = new System.Windows.Forms.Button();
            this.btnPassengerRefund = new System.Windows.Forms.Button();
            this.btnPassengerSignOut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassengerPanelText
            // 
            this.lblPassengerPanelText.AutoSize = true;
            this.lblPassengerPanelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerPanelText.Location = new System.Drawing.Point(32, 26);
            this.lblPassengerPanelText.Name = "lblPassengerPanelText";
            this.lblPassengerPanelText.Size = new System.Drawing.Size(184, 25);
            this.lblPassengerPanelText.TabIndex = 0;
            this.lblPassengerPanelText.Text = "PassengerPanel";
            // 
            // btnPassengerFlight
            // 
            this.btnPassengerFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerFlight.Location = new System.Drawing.Point(13, 93);
            this.btnPassengerFlight.Name = "btnPassengerFlight";
            this.btnPassengerFlight.Size = new System.Drawing.Size(203, 57);
            this.btnPassengerFlight.TabIndex = 1;
            this.btnPassengerFlight.Text = "Flight";
            this.btnPassengerFlight.UseVisualStyleBackColor = true;
            this.btnPassengerFlight.Click += new System.EventHandler(this.btnPassengerFlight_Click);
            // 
            // btnPassengerBooking
            // 
            this.btnPassengerBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerBooking.Location = new System.Drawing.Point(13, 178);
            this.btnPassengerBooking.Name = "btnPassengerBooking";
            this.btnPassengerBooking.Size = new System.Drawing.Size(203, 46);
            this.btnPassengerBooking.TabIndex = 2;
            this.btnPassengerBooking.Text = "Booking";
            this.btnPassengerBooking.UseVisualStyleBackColor = true;
            this.btnPassengerBooking.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPassengerPayment
            // 
            this.btnPassengerPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerPayment.Location = new System.Drawing.Point(24, 252);
            this.btnPassengerPayment.Name = "btnPassengerPayment";
            this.btnPassengerPayment.Size = new System.Drawing.Size(192, 40);
            this.btnPassengerPayment.TabIndex = 4;
            this.btnPassengerPayment.Text = "Payment";
            this.btnPassengerPayment.UseVisualStyleBackColor = true;
            this.btnPassengerPayment.Click += new System.EventHandler(this.btnPassengerPayment_Click);
            // 
            // btnPassengerRefund
            // 
            this.btnPassengerRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerRefund.Location = new System.Drawing.Point(24, 321);
            this.btnPassengerRefund.Name = "btnPassengerRefund";
            this.btnPassengerRefund.Size = new System.Drawing.Size(192, 53);
            this.btnPassengerRefund.TabIndex = 5;
            this.btnPassengerRefund.Text = "Refund";
            this.btnPassengerRefund.UseVisualStyleBackColor = true;
            this.btnPassengerRefund.Click += new System.EventHandler(this.btnPassengerRefund_Click);
            // 
            // btnPassengerSignOut
            // 
            this.btnPassengerSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerSignOut.Location = new System.Drawing.Point(24, 409);
            this.btnPassengerSignOut.Name = "btnPassengerSignOut";
            this.btnPassengerSignOut.Size = new System.Drawing.Size(192, 46);
            this.btnPassengerSignOut.TabIndex = 6;
            this.btnPassengerSignOut.Text = "SignOut";
            this.btnPassengerSignOut.UseVisualStyleBackColor = true;
            this.btnPassengerSignOut.Click += new System.EventHandler(this.btnPassengerSignOut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(268, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(716, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 693);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPassengerSignOut);
            this.Controls.Add(this.btnPassengerRefund);
            this.Controls.Add(this.btnPassengerPayment);
            this.Controls.Add(this.btnPassengerBooking);
            this.Controls.Add(this.btnPassengerFlight);
            this.Controls.Add(this.lblPassengerPanelText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassengerPanelText;
        private System.Windows.Forms.Button btnPassengerFlight;
        private System.Windows.Forms.Button btnPassengerBooking;
        private System.Windows.Forms.Button btnPassengerPayment;
        private System.Windows.Forms.Button btnPassengerRefund;
        private System.Windows.Forms.Button btnPassengerSignOut;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

