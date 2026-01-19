namespace Atms
{
    partial class View_Booking_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Booking_List));
            this.dvgFlights = new System.Windows.Forms.DataGridView();
            this.btnbackview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgFlights
            // 
            this.dvgFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFlights.Location = new System.Drawing.Point(213, 78);
            this.dvgFlights.Name = "dvgFlights";
            this.dvgFlights.RowHeadersWidth = 51;
            this.dvgFlights.RowTemplate.Height = 24;
            this.dvgFlights.Size = new System.Drawing.Size(665, 294);
            this.dvgFlights.TabIndex = 0;
            // 
            // btnbackview
            // 
            this.btnbackview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbackview.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackview.Location = new System.Drawing.Point(478, 422);
            this.btnbackview.Name = "btnbackview";
            this.btnbackview.Size = new System.Drawing.Size(122, 43);
            this.btnbackview.TabIndex = 1;
            this.btnbackview.Text = "Back";
            this.btnbackview.UseVisualStyleBackColor = false;
            this.btnbackview.Click += new System.EventHandler(this.btnbackview_Click);
            // 
            // View_Booking_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1132, 717);
            this.Controls.Add(this.btnbackview);
            this.Controls.Add(this.dvgFlights);
            this.Name = "View_Booking_List";
            this.Text = "View_Booking_List";
            this.Load += new System.EventHandler(this.View_Booking_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgFlights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgFlights;
        private System.Windows.Forms.Button btnbackview;
    }
}