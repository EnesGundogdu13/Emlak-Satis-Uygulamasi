namespace JetEmlak
{
    partial class AnaSayfa
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
            this.btnilanekle = new System.Windows.Forms.Button();
            this.dgwilanlar = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btngeridon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwilanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnilanekle
            // 
            this.btnilanekle.Location = new System.Drawing.Point(779, 12);
            this.btnilanekle.Name = "btnilanekle";
            this.btnilanekle.Size = new System.Drawing.Size(129, 49);
            this.btnilanekle.TabIndex = 0;
            this.btnilanekle.Text = "İlan Ekle";
            this.btnilanekle.UseVisualStyleBackColor = true;
            this.btnilanekle.Click += new System.EventHandler(this.btnilanekle_Click);
            // 
            // dgwilanlar
            // 
            this.dgwilanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwilanlar.Location = new System.Drawing.Point(67, 107);
            this.dgwilanlar.Name = "dgwilanlar";
            this.dgwilanlar.Size = new System.Drawing.Size(650, 325);
            this.dgwilanlar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kendi İlanlarım";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngeridon
            // 
            this.btngeridon.Location = new System.Drawing.Point(12, 452);
            this.btngeridon.Name = "btngeridon";
            this.btngeridon.Size = new System.Drawing.Size(83, 29);
            this.btngeridon.TabIndex = 3;
            this.btngeridon.Text = "Geri Dön";
            this.btngeridon.UseVisualStyleBackColor = true;
            this.btngeridon.Click += new System.EventHandler(this.btngeridon_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 493);
            this.Controls.Add(this.btngeridon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwilanlar);
            this.Controls.Add(this.btnilanekle);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwilanlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnilanekle;
        private System.Windows.Forms.DataGridView dgwilanlar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btngeridon;
    }
}