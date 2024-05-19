namespace JetEmlak
{
    partial class Form1
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
            this.btnkayitol = new System.Windows.Forms.Button();
            this.btnmisafirgiris = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txteposta = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkayitol
            // 
            this.btnkayitol.Location = new System.Drawing.Point(697, 12);
            this.btnkayitol.Name = "btnkayitol";
            this.btnkayitol.Size = new System.Drawing.Size(91, 33);
            this.btnkayitol.TabIndex = 0;
            this.btnkayitol.Text = "Kayıt Ol";
            this.btnkayitol.UseVisualStyleBackColor = true;
            this.btnkayitol.Click += new System.EventHandler(this.btnkayitol_Click);
            // 
            // btnmisafirgiris
            // 
            this.btnmisafirgiris.Location = new System.Drawing.Point(600, 12);
            this.btnmisafirgiris.Name = "btnmisafirgiris";
            this.btnmisafirgiris.Size = new System.Drawing.Size(91, 33);
            this.btnmisafirgiris.TabIndex = 1;
            this.btnmisafirgiris.Text = "Misafir Giriş";
            this.btnmisafirgiris.UseVisualStyleBackColor = true;
            this.btnmisafirgiris.Click += new System.EventHandler(this.btnmisafirgiris_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.Location = new System.Drawing.Point(503, 12);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(91, 33);
            this.btnadmin.TabIndex = 2;
            this.btnadmin.Text = "Admin Giriş";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(115, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = "Giriş Yap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "E-Posta";
            // 
            // txteposta
            // 
            this.txteposta.Location = new System.Drawing.Point(122, 182);
            this.txteposta.Name = "txteposta";
            this.txteposta.Size = new System.Drawing.Size(121, 20);
            this.txteposta.TabIndex = 13;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(122, 217);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(121, 20);
            this.txtsifre.TabIndex = 12;
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(122, 266);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(121, 31);
            this.btngiris.TabIndex = 11;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txteposta);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btnmisafirgiris);
            this.Controls.Add(this.btnkayitol);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkayitol;
        private System.Windows.Forms.Button btnmisafirgiris;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txteposta;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btngiris;
    }
}

