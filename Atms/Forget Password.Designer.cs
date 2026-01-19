namespace Atms
{
    partial class Forget_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forget_Password));
            this.label1 = new System.Windows.Forms.Label();
            this.txtforgotemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.btnnewsubmit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email :";
            // 
            // txtforgotemail
            // 
            this.txtforgotemail.Location = new System.Drawing.Point(535, 225);
            this.txtforgotemail.Name = "txtforgotemail";
            this.txtforgotemail.Size = new System.Drawing.Size(189, 22);
            this.txtforgotemail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(535, 310);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(189, 22);
            this.txtnewpassword.TabIndex = 3;
            this.txtnewpassword.UseSystemPasswordChar = true;
            // 
            // btnnewsubmit
            // 
            this.btnnewsubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnnewsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewsubmit.Location = new System.Drawing.Point(357, 386);
            this.btnnewsubmit.Name = "btnnewsubmit";
            this.btnnewsubmit.Size = new System.Drawing.Size(113, 54);
            this.btnnewsubmit.TabIndex = 4;
            this.btnnewsubmit.Text = "Submit";
            this.btnnewsubmit.UseVisualStyleBackColor = false;
            this.btnnewsubmit.Click += new System.EventHandler(this.btnnewsubmit_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(560, 386);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(113, 54);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Forget_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1132, 717);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnnewsubmit);
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtforgotemail);
            this.Controls.Add(this.label1);
            this.Name = "Forget_Password";
            this.Text = "Forget_Password";
            this.Load += new System.EventHandler(this.Forget_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtforgotemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.Button btnnewsubmit;
        private System.Windows.Forms.Button btnback;
    }
}