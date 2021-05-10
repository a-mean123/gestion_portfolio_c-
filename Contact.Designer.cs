namespace amineportfolio
{
    partial class Contact
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
            this.label7 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.u_budget = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.u_organization = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.u_message = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.u_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTXT = new System.Windows.Forms.TextBox();
            this.u_email = new System.Windows.Forms.TextBox();
            this.u_lastname = new System.Windows.Forms.TextBox();
            this.u_name = new System.Windows.Forms.TextBox();
            this.IDTXT1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Gestion des contact";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_delete.Location = new System.Drawing.Point(537, 304);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 35);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_update.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_update.Location = new System.Drawing.Point(410, 304);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 35);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_save.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_save.Location = new System.Drawing.Point(290, 304);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 35);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "affiche";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(61, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(792, 377);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "read / viewing data";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(760, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.u_budget);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.u_organization);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.u_message);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.u_phone);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.IDTXT);
            this.groupBox2.Controls.Add(this.u_email);
            this.groupBox2.Controls.Add(this.u_lastname);
            this.groupBox2.Controls.Add(this.u_name);
            this.groupBox2.Controls.Add(this.IDTXT1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(74, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 191);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update / delete";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // u_budget
            // 
            this.u_budget.Location = new System.Drawing.Point(114, 150);
            this.u_budget.Name = "u_budget";
            this.u_budget.Size = new System.Drawing.Size(216, 20);
            this.u_budget.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "budget :";
            // 
            // u_organization
            // 
            this.u_organization.Location = new System.Drawing.Point(462, 78);
            this.u_organization.Name = "u_organization";
            this.u_organization.Size = new System.Drawing.Size(216, 20);
            this.u_organization.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "organization :";
            // 
            // u_message
            // 
            this.u_message.Location = new System.Drawing.Point(463, 116);
            this.u_message.Multiline = true;
            this.u_message.Name = "u_message";
            this.u_message.Size = new System.Drawing.Size(216, 59);
            this.u_message.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "message :";
            // 
            // u_phone
            // 
            this.u_phone.Location = new System.Drawing.Point(463, 44);
            this.u_phone.Name = "u_phone";
            this.u_phone.Size = new System.Drawing.Size(216, 20);
            this.u_phone.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "phone :";
            // 
            // IDTXT
            // 
            this.IDTXT.Location = new System.Drawing.Point(297, 13);
            this.IDTXT.Name = "IDTXT";
            this.IDTXT.Size = new System.Drawing.Size(32, 20);
            this.IDTXT.TabIndex = 10;
            // 
            // u_email
            // 
            this.u_email.Location = new System.Drawing.Point(113, 115);
            this.u_email.Name = "u_email";
            this.u_email.Size = new System.Drawing.Size(216, 20);
            this.u_email.TabIndex = 9;
            // 
            // u_lastname
            // 
            this.u_lastname.Location = new System.Drawing.Point(113, 76);
            this.u_lastname.Multiline = true;
            this.u_lastname.Name = "u_lastname";
            this.u_lastname.Size = new System.Drawing.Size(216, 23);
            this.u_lastname.TabIndex = 8;
            // 
            // u_name
            // 
            this.u_name.Location = new System.Drawing.Point(113, 44);
            this.u_name.Name = "u_name";
            this.u_name.Size = new System.Drawing.Size(216, 20);
            this.u_name.TabIndex = 7;
            this.u_name.Text = "545";
            // 
            // IDTXT1
            // 
            this.IDTXT1.AutoSize = true;
            this.IDTXT1.Location = new System.Drawing.Point(276, 16);
            this.IDTXT1.Name = "IDTXT1";
            this.IDTXT1.Size = new System.Drawing.Size(24, 13);
            this.IDTXT1.TabIndex = 6;
            this.IDTXT1.Text = "ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "lastname :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "name :";
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(914, 735);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Contact";
            this.Text = "Contact";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox u_message;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox u_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTXT;
        private System.Windows.Forms.TextBox u_email;
        private System.Windows.Forms.TextBox u_lastname;
        private System.Windows.Forms.TextBox u_name;
        private System.Windows.Forms.Label IDTXT1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox u_budget;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox u_organization;
        private System.Windows.Forms.Label label3;
    }
}