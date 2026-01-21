namespace AirTicketManagementSystem
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.Namelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addlbl = new System.Windows.Forms.Label();
            this.doblbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.RichTextBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.txtMobNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Passlbl = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(182, 153);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(75, 27);
            this.Namelbl.TabIndex = 0;
            this.Namelbl.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mobile NO : ";
            // 
            // addlbl
            // 
            this.addlbl.AutoSize = true;
            this.addlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addlbl.Location = new System.Drawing.Point(161, 251);
            this.addlbl.Name = "addlbl";
            this.addlbl.Size = new System.Drawing.Size(96, 27);
            this.addlbl.TabIndex = 2;
            this.addlbl.Text = "Address:";
            // 
            // doblbl
            // 
            this.doblbl.AutoSize = true;
            this.doblbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doblbl.Location = new System.Drawing.Point(110, 380);
            this.doblbl.Name = "doblbl";
            this.doblbl.Size = new System.Drawing.Size(156, 27);
            this.doblbl.TabIndex = 3;
            this.doblbl.Text = "Date Of Birth :";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.Location = new System.Drawing.Point(197, 443);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(74, 27);
            this.emaillbl.TabIndex = 4;
            this.emaillbl.Text = "Email:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(288, 153);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(295, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(289, 251);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(295, 96);
            this.txtAdd.TabIndex = 6;
            this.txtAdd.Text = "";
            this.txtAdd.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(289, 381);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(295, 26);
            this.dtpDob.TabIndex = 7;
            // 
            // txtMobNo
            // 
            this.txtMobNo.Location = new System.Drawing.Point(288, 207);
            this.txtMobNo.Name = "txtMobNo";
            this.txtMobNo.Size = new System.Drawing.Size(296, 26);
            this.txtMobNo.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(287, 444);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(296, 26);
            this.txtEmail.TabIndex = 9;
            // 
            // Passlbl
            // 
            this.Passlbl.AutoSize = true;
            this.Passlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlbl.Location = new System.Drawing.Point(161, 495);
            this.Passlbl.Name = "Passlbl";
            this.Passlbl.Size = new System.Drawing.Size(110, 27);
            this.Passlbl.TabIndex = 10;
            this.Passlbl.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(288, 496);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(253, 26);
            this.txtPass.TabIndex = 11;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitbtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(287, 545);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(254, 43);
            this.submitbtn.TabIndex = 12;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(761, 708);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.Passlbl);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMobNo);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.doblbl);
            this.Controls.Add(this.addlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Namelbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label addlbl;
        private System.Windows.Forms.Label doblbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox txtAdd;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.TextBox txtMobNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Passlbl;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button submitbtn;
    }
}