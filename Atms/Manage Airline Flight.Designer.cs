namespace Atms
{
    partial class Manage_Airline_Flight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Airline_Flight));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAirlineName = new System.Windows.Forms.TextBox();
            this.txtFlightCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.btnUpdateFlight = new System.Windows.Forms.Button();
            this.btnDeleteFlight = new System.Windows.Forms.Button();
            this.btnSearchFlight = new System.Windows.Forms.Button();
            this.dgvFlightList = new System.Windows.Forms.DataGridView();
            this.colAirlineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFlightCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlightList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Airline Name :";
            // 
            // txtAirlineName
            // 
            this.txtAirlineName.Location = new System.Drawing.Point(545, 29);
            this.txtAirlineName.Name = "txtAirlineName";
            this.txtAirlineName.Size = new System.Drawing.Size(238, 22);
            this.txtAirlineName.TabIndex = 1;
            // 
            // txtFlightCode
            // 
            this.txtFlightCode.Location = new System.Drawing.Point(545, 93);
            this.txtFlightCode.Name = "txtFlightCode";
            this.txtFlightCode.Size = new System.Drawing.Size(238, 22);
            this.txtFlightCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Flight Code :";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(545, 156);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(238, 22);
            this.txtFrom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "From :";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(545, 218);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(238, 22);
            this.txtTo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "To :";
            // 
            // txtDepartureTime
            // 
            this.txtDepartureTime.Location = new System.Drawing.Point(545, 277);
            this.txtDepartureTime.Name = "txtDepartureTime";
            this.txtDepartureTime.Size = new System.Drawing.Size(238, 22);
            this.txtDepartureTime.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Departure Time :";
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.Location = new System.Drawing.Point(150, 343);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(122, 42);
            this.btnAddFlight.TabIndex = 10;
            this.btnAddFlight.Text = "Add";
            this.btnAddFlight.UseVisualStyleBackColor = false;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // btnUpdateFlight
            // 
            this.btnUpdateFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFlight.Location = new System.Drawing.Point(436, 343);
            this.btnUpdateFlight.Name = "btnUpdateFlight";
            this.btnUpdateFlight.Size = new System.Drawing.Size(122, 42);
            this.btnUpdateFlight.TabIndex = 11;
            this.btnUpdateFlight.Text = "Update";
            this.btnUpdateFlight.UseVisualStyleBackColor = false;
            this.btnUpdateFlight.Click += new System.EventHandler(this.btnUpdateFlight_Click);
            // 
            // btnDeleteFlight
            // 
            this.btnDeleteFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFlight.Location = new System.Drawing.Point(682, 343);
            this.btnDeleteFlight.Name = "btnDeleteFlight";
            this.btnDeleteFlight.Size = new System.Drawing.Size(122, 42);
            this.btnDeleteFlight.TabIndex = 12;
            this.btnDeleteFlight.Text = "Delete";
            this.btnDeleteFlight.UseVisualStyleBackColor = false;
            this.btnDeleteFlight.Click += new System.EventHandler(this.btnDeleteFlight_Click);
            // 
            // btnSearchFlight
            // 
            this.btnSearchFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFlight.Location = new System.Drawing.Point(919, 343);
            this.btnSearchFlight.Name = "btnSearchFlight";
            this.btnSearchFlight.Size = new System.Drawing.Size(122, 42);
            this.btnSearchFlight.TabIndex = 13;
            this.btnSearchFlight.Text = "Search";
            this.btnSearchFlight.UseVisualStyleBackColor = false;
            this.btnSearchFlight.Click += new System.EventHandler(this.btnSearchFlight_Click);
            // 
            // dgvFlightList
            // 
            this.dgvFlightList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlightList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAirlineName,
            this.colFlightCode,
            this.colFrom,
            this.colTo,
            this.colDepartureTime});
            this.dgvFlightList.Location = new System.Drawing.Point(150, 434);
            this.dgvFlightList.Name = "dgvFlightList";
            this.dgvFlightList.RowHeadersWidth = 51;
            this.dgvFlightList.RowTemplate.Height = 24;
            this.dgvFlightList.Size = new System.Drawing.Size(891, 209);
            this.dgvFlightList.TabIndex = 14;
            // 
            // colAirlineName
            // 
            this.colAirlineName.HeaderText = "Airline Name";
            this.colAirlineName.MinimumWidth = 6;
            this.colAirlineName.Name = "colAirlineName";
            this.colAirlineName.Width = 125;
            // 
            // colFlightCode
            // 
            this.colFlightCode.HeaderText = "Flight Code";
            this.colFlightCode.MinimumWidth = 6;
            this.colFlightCode.Name = "colFlightCode";
            this.colFlightCode.Width = 125;
            // 
            // colFrom
            // 
            this.colFrom.HeaderText = "From";
            this.colFrom.MinimumWidth = 6;
            this.colFrom.Name = "colFrom";
            this.colFrom.Width = 125;
            // 
            // colTo
            // 
            this.colTo.HeaderText = "To";
            this.colTo.MinimumWidth = 6;
            this.colTo.Name = "colTo";
            this.colTo.Width = 125;
            // 
            // colDepartureTime
            // 
            this.colDepartureTime.HeaderText = "Departure Time";
            this.colDepartureTime.MinimumWidth = 6;
            this.colDepartureTime.Name = "colDepartureTime";
            this.colDepartureTime.Width = 129;
            // 
            // Manage_Airline_Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1132, 717);
            this.Controls.Add(this.dgvFlightList);
            this.Controls.Add(this.btnSearchFlight);
            this.Controls.Add(this.btnDeleteFlight);
            this.Controls.Add(this.btnUpdateFlight);
            this.Controls.Add(this.btnAddFlight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDepartureTime);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFlightCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAirlineName);
            this.Controls.Add(this.label1);
            this.Name = "Manage_Airline_Flight";
            this.Text = "Manage_Airline_Flight";
            this.Load += new System.EventHandler(this.Manage_Airline_Flight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlightList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAirlineName;
        private System.Windows.Forms.TextBox txtFlightCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtDepartureTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Button btnUpdateFlight;
        private System.Windows.Forms.Button btnDeleteFlight;
        private System.Windows.Forms.Button btnSearchFlight;
        private System.Windows.Forms.DataGridView dgvFlightList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAirlineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFlightCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartureTime;
    }
}