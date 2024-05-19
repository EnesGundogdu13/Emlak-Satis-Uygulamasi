namespace JetEmlak
{
    partial class Kayitlar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.txtekullaniciadi = new System.Windows.Forms.TextBox();
            this.txteeposta = new System.Windows.Forms.TextBox();
            this.txtesifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdsifre = new System.Windows.Forms.TextBox();
            this.txtdeposta = new System.Windows.Forms.TextBox();
            this.txtdkullaniciadi = new System.Windows.Forms.TextBox();
            this.btnduzenle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdid = new System.Windows.Forms.TextBox();
            this.btngeridon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(135, 401);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(100, 23);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "Kayıt Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txtekullaniciadi
            // 
            this.txtekullaniciadi.Location = new System.Drawing.Point(135, 273);
            this.txtekullaniciadi.Name = "txtekullaniciadi";
            this.txtekullaniciadi.Size = new System.Drawing.Size(100, 20);
            this.txtekullaniciadi.TabIndex = 2;
            // 
            // txteeposta
            // 
            this.txteeposta.Location = new System.Drawing.Point(135, 312);
            this.txteeposta.Name = "txteeposta";
            this.txteeposta.Size = new System.Drawing.Size(100, 20);
            this.txteeposta.TabIndex = 3;
            // 
            // txtesifre
            // 
            this.txtesifre.Location = new System.Drawing.Point(135, 352);
            this.txtesifre.Name = "txtesifre";
            this.txtesifre.Size = new System.Drawing.Size(100, 20);
            this.txtesifre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "E-Posta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(131, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kayıt Ekle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(516, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kayıt Düzenle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Şifre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "E-Posta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Kullanıcı Adı:";
            // 
            // txtdsifre
            // 
            this.txtdsifre.Location = new System.Drawing.Point(553, 374);
            this.txtdsifre.Name = "txtdsifre";
            this.txtdsifre.Size = new System.Drawing.Size(100, 20);
            this.txtdsifre.TabIndex = 12;
            // 
            // txtdeposta
            // 
            this.txtdeposta.Location = new System.Drawing.Point(553, 335);
            this.txtdeposta.Name = "txtdeposta";
            this.txtdeposta.Size = new System.Drawing.Size(100, 20);
            this.txtdeposta.TabIndex = 11;
            // 
            // txtdkullaniciadi
            // 
            this.txtdkullaniciadi.Location = new System.Drawing.Point(553, 298);
            this.txtdkullaniciadi.Name = "txtdkullaniciadi";
            this.txtdkullaniciadi.Size = new System.Drawing.Size(100, 20);
            this.txtdkullaniciadi.TabIndex = 10;
            // 
            // btnduzenle
            // 
            this.btnduzenle.Location = new System.Drawing.Point(553, 415);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(100, 23);
            this.btnduzenle.TabIndex = 9;
            this.btnduzenle.Text = "Kayıt Düzenle";
            this.btnduzenle.UseVisualStyleBackColor = true;
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(325, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Kayıt Sil";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "İd:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(329, 273);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 17;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(329, 312);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(100, 23);
            this.btnsil.TabIndex = 20;
            this.btnsil.Text = "Kayıt Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(528, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "İd:";
            // 
            // txtdid
            // 
            this.txtdid.Location = new System.Drawing.Point(553, 263);
            this.txtdid.Name = "txtdid";
            this.txtdid.Size = new System.Drawing.Size(100, 20);
            this.txtdid.TabIndex = 21;
            // 
            // btngeridon
            // 
            this.btngeridon.Location = new System.Drawing.Point(12, 415);
            this.btngeridon.Name = "btngeridon";
            this.btngeridon.Size = new System.Drawing.Size(84, 23);
            this.btngeridon.TabIndex = 23;
            this.btngeridon.Text = "Geri Dön";
            this.btngeridon.UseVisualStyleBackColor = true;
            this.btngeridon.Click += new System.EventHandler(this.btngeridon_Click);
            // 
            // Kayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.btngeridon);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtdid);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdsifre);
            this.Controls.Add(this.txtdeposta);
            this.Controls.Add(this.txtdkullaniciadi);
            this.Controls.Add(this.btnduzenle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtesifre);
            this.Controls.Add(this.txteeposta);
            this.Controls.Add(this.txtekullaniciadi);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kayitlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayitlar";
            this.Load += new System.EventHandler(this.Kayitlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtekullaniciadi;
        private System.Windows.Forms.TextBox txteeposta;
        private System.Windows.Forms.TextBox txtesifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdsifre;
        private System.Windows.Forms.TextBox txtdeposta;
        private System.Windows.Forms.TextBox txtdkullaniciadi;
        private System.Windows.Forms.Button btnduzenle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdid;
        private System.Windows.Forms.Button btngeridon;
    }
}