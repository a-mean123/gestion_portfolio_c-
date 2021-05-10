namespace amineportfolio
{
    partial class Projet
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
            this.IDTXT = new System.Windows.Forms.TextBox();
            this.u_lien = new System.Windows.Forms.TextBox();
            this.u_description = new System.Windows.Forms.TextBox();
            this.u_titre = new System.Windows.Forms.TextBox();
            this.IDTXT1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lien = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.titre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Gestion des projets";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.Location = new System.Drawing.Point(513, 246);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 34);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_update.Location = new System.Drawing.Point(386, 246);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 34);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_save.Location = new System.Drawing.Point(266, 246);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 34);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(37, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(792, 377);
            this.groupBox3.TabIndex = 10;
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
            this.groupBox2.Controls.Add(this.IDTXT);
            this.groupBox2.Controls.Add(this.u_lien);
            this.groupBox2.Controls.Add(this.u_description);
            this.groupBox2.Controls.Add(this.u_titre);
            this.groupBox2.Controls.Add(this.IDTXT1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(443, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 152);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update / delete";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // IDTXT
            // 
            this.IDTXT.Location = new System.Drawing.Point(297, 13);
            this.IDTXT.Name = "IDTXT";
            this.IDTXT.Size = new System.Drawing.Size(32, 20);
            this.IDTXT.TabIndex = 10;
            // 
            // u_lien
            // 
            this.u_lien.Location = new System.Drawing.Point(113, 126);
            this.u_lien.Name = "u_lien";
            this.u_lien.Size = new System.Drawing.Size(216, 20);
            this.u_lien.TabIndex = 9;
            // 
            // u_description
            // 
            this.u_description.Location = new System.Drawing.Point(113, 76);
            this.u_description.Multiline = true;
            this.u_description.Name = "u_description";
            this.u_description.Size = new System.Drawing.Size(216, 40);
            this.u_description.TabIndex = 8;
            // 
            // u_titre
            // 
            this.u_titre.Location = new System.Drawing.Point(113, 44);
            this.u_titre.Name = "u_titre";
            this.u_titre.Size = new System.Drawing.Size(216, 20);
            this.u_titre.TabIndex = 7;
            this.u_titre.Text = "545";
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
            this.label4.Location = new System.Drawing.Point(31, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "lien :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "description :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "titre :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lien);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Controls.Add(this.titre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 152);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lien
            // 
            this.lien.Location = new System.Drawing.Point(117, 117);
            this.lien.Name = "lien";
            this.lien.Size = new System.Drawing.Size(216, 20);
            this.lien.TabIndex = 5;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(117, 67);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(216, 40);
            this.description.TabIndex = 4;
            // 
            // titre
            // 
            this.titre.Location = new System.Drawing.Point(117, 35);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(216, 20);
            this.titre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "lien :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "titre :";
            // 
            // Projet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(869, 742);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Projet";
            this.Text = "Projet";
            this.Load += new System.EventHandler(this.Projet_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox IDTXT;
        private System.Windows.Forms.TextBox u_lien;
        private System.Windows.Forms.TextBox u_description;
        private System.Windows.Forms.TextBox u_titre;
        private System.Windows.Forms.Label IDTXT1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lien;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox titre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}