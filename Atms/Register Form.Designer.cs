namespace Atms
{
    partial class Register_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegName = new System.Windows.Forms.TextBox();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegMobileNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.btnRegSubmit = new System.Windows.Forms.Button();
            this.txtRegAddress = new System.Windows.Forms.RichTextBox();
            this.linkhaveaccount = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.radiomale = new System.Windows.Forms.RadioButton();
            this.radiofemale = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // txtRegName
            // 
            this.txtRegName.Location = new System.Drawing.Point(557, 62);
            this.txtRegName.Name = "txtRegName";
            this.txtRegName.Size = new System.Drawing.Size(245, 22);
            this.txtRegName.TabIndex = 1;
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Location = new System.Drawing.Point(557, 132);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(245, 22);
            this.txtRegEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email :";
            // 
            // txtRegMobileNumber
            // 
            this.txtRegMobileNumber.Location = new System.Drawing.Point(557, 198);
            this.txtRegMobileNumber.Name = "txtRegMobileNumber";
            this.txtRegMobileNumber.Size = new System.Drawing.Size(245, 22);
            this.txtRegMobileNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mobile Number :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(360, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address :";
            // 
            // txtDateofBirth
            // 
            this.txtDateofBirth.Location = new System.Drawing.Point(557, 360);
            this.txtDateofBirth.Name = "txtDateofBirth";
            this.txtDateofBirth.Size = new System.Drawing.Size(245, 22);
            this.txtDateofBirth.TabIndex = 8;
            this.txtDateofBirth.ValueChanged += new System.EventHandler(this.txtDateofBirth_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(342, 516);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password :";
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(557, 523);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(245, 22);
            this.txtRegPassword.TabIndex = 11;
            this.txtRegPassword.UseSystemPasswordChar = true;
            // 
            // btnRegSubmit
            // 
            this.btnRegSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegSubmit.Location = new System.Drawing.Point(475, 569);
            this.btnRegSubmit.Name = "btnRegSubmit";
            this.btnRegSubmit.Size = new System.Drawing.Size(125, 40);
            this.btnRegSubmit.TabIndex = 12;
            this.btnRegSubmit.Text = "Submit";
            this.btnRegSubmit.UseVisualStyleBackColor = true;
            this.btnRegSubmit.Click += new System.EventHandler(this.btnRegSubmit_Click);
            // 
            // txtRegAddress
            // 
            this.txtRegAddress.Location = new System.Drawing.Point(557, 256);
            this.txtRegAddress.Name = "txtRegAddress";
            this.txtRegAddress.Size = new System.Drawing.Size(245, 87);
            this.txtRegAddress.TabIndex = 13;
            this.txtRegAddress.Text = "";
            this.txtRegAddress.TextChanged += new System.EventHandler(this.txtRegAddress_TextChanged);
            // 
            // linkhaveaccount
            // 
            this.linkhaveaccount.AutoSize = true;
            this.linkhaveaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkhaveaccount.Location = new System.Drawing.Point(421, 625);
            this.linkhaveaccount.Name = "linkhaveaccount";
            this.linkhaveaccount.Size = new System.Drawing.Size(233, 25);
            this.linkhaveaccount.TabIndex = 14;
            this.linkhaveaccount.TabStop = true;
            this.linkhaveaccount.Text = "Already have an account.";
            this.linkhaveaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkhaveaccount_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date of Birth";
            // 
            // radiomale
            // 
            this.radiomale.AutoSize = true;
            this.radiomale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radiomale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiomale.Location = new System.Drawing.Point(557, 443);
            this.radiomale.Name = "radiomale";
            this.radiomale.Size = new System.Drawing.Size(76, 29);
            this.radiomale.TabIndex = 16;
            this.radiomale.TabStop = true;
            this.radiomale.Text = "Male";
            this.radiomale.UseVisualStyleBackColor = false;
            // 
            // radiofemale
            // 
            this.radiofemale.AutoSize = true;
            this.radiofemale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radiofemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiofemale.Location = new System.Drawing.Point(697, 443);
            this.radiofemale.Name = "radiofemale";
            this.radiofemale.Size = new System.Drawing.Size(98, 29);
            this.radiofemale.TabIndex = 17;
            this.radiofemale.TabStop = true;
            this.radiofemale.Text = "Female";
            this.radiofemale.UseVisualStyleBackColor = false;
            // 
            // Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1132, 717);
            this.Controls.Add(this.radiofemale);
            this.Controls.Add(this.radiomale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkhaveaccount);
            this.Controls.Add(this.txtRegAddress);
            this.Controls.Add(this.btnRegSubmit);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDateofBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRegMobileNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegName);
            this.Controls.Add(this.label1);
            this.Name = "Register_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register_Form";
            this.Load += new System.EventHandler(this.Register_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegName;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegMobileNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtDateofBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.Button btnRegSubmit;
        private System.Windows.Forms.RichTextBox txtRegAddress;
        private System.Windows.Forms.LinkLabel linkhaveaccount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radiomale;
        private System.Windows.Forms.RadioButton radiofemale;
    }
}