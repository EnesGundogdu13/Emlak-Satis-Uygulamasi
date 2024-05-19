namespace JetEmlak
{
    partial class AdminPanel
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
            this.btnkayitlar = new System.Windows.Forms.Button();
            this.btnadmingiris = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnilanlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkayitlar
            // 
            this.btnkayitlar.Location = new System.Drawing.Point(517, 148);
            this.btnkayitlar.Name = "btnkayitlar";
            this.btnkayitlar.Size = new System.Drawing.Size(123, 56);
            this.btnkayitlar.TabIndex = 0;
            this.btnkayitlar.Text = "Kayıtlar";
            this.btnkayitlar.UseVisualStyleBackColor = true;
            this.btnkayitlar.Click += new System.EventHandler(this.btnkayitlar_Click);
            // 
            // btnadmingiris
            // 
            this.btnadmingiris.Location = new System.Drawing.Point(318, 148);
            this.btnadmingiris.Name = "btnadmingiris";
            this.btnadmingiris.Size = new System.Drawing.Size(123, 56);
            this.btnadmingiris.TabIndex = 1;
            this.btnadmingiris.Text = "Admin Girişleri";
            this.btnadmingiris.UseVisualStyleBackColor = true;
            this.btnadmingiris.Click += new System.EventHandler(this.btnadmingiris_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnilanlar
            // 
            this.btnilanlar.Location = new System.Drawing.Point(119, 148);
            this.btnilanlar.Name = "btnilanlar";
            this.btnilanlar.Size = new System.Drawing.Size(123, 56);
            this.btnilanlar.TabIndex = 3;
            this.btnilanlar.Text = "İlanlar";
            this.btnilanlar.UseVisualStyleBackColor = true;
            this.btnilanlar.Click += new System.EventHandler(this.btnilanlar_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnilanlar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnadmingiris);
            this.Controls.Add(this.btnkayitlar);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkayitlar;
        private System.Windows.Forms.Button btnadmingiris;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnilanlar;
    }
}