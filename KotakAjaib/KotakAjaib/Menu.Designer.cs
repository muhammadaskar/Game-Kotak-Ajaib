namespace KotakAjaib
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonCaraBermain = new System.Windows.Forms.Button();
            this.buttonPembuatPermainan = new System.Windows.Forms.Button();
            this.buttonMasukkanNamaPemain = new System.Windows.Forms.Button();
            this.buttonMulaiPermainan = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(108, 9);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(153, 29);
            this.labelMenu.TabIndex = 11;
            this.labelMenu.Text = "Menu Game";
            this.labelMenu.Click += new System.EventHandler(this.labelMenu_Click);
            // 
            // buttonCaraBermain
            // 
            this.buttonCaraBermain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCaraBermain.BackgroundImage")));
            this.buttonCaraBermain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCaraBermain.Location = new System.Drawing.Point(12, 61);
            this.buttonCaraBermain.Name = "buttonCaraBermain";
            this.buttonCaraBermain.Size = new System.Drawing.Size(153, 34);
            this.buttonCaraBermain.TabIndex = 12;
            this.buttonCaraBermain.Text = "Cara Bermain";
            this.buttonCaraBermain.UseVisualStyleBackColor = true;
            this.buttonCaraBermain.Click += new System.EventHandler(this.buttonCaraBermain_Click);
            // 
            // buttonPembuatPermainan
            // 
            this.buttonPembuatPermainan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPembuatPermainan.BackgroundImage")));
            this.buttonPembuatPermainan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPembuatPermainan.Location = new System.Drawing.Point(190, 61);
            this.buttonPembuatPermainan.Name = "buttonPembuatPermainan";
            this.buttonPembuatPermainan.Size = new System.Drawing.Size(153, 34);
            this.buttonPembuatPermainan.TabIndex = 13;
            this.buttonPembuatPermainan.Text = "Pembuat Permainan";
            this.buttonPembuatPermainan.UseVisualStyleBackColor = true;
            this.buttonPembuatPermainan.Click += new System.EventHandler(this.buttonPembuatPermainan_Click);
            // 
            // buttonMasukkanNamaPemain
            // 
            this.buttonMasukkanNamaPemain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMasukkanNamaPemain.BackgroundImage")));
            this.buttonMasukkanNamaPemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasukkanNamaPemain.ForeColor = System.Drawing.Color.Blue;
            this.buttonMasukkanNamaPemain.Location = new System.Drawing.Point(126, 159);
            this.buttonMasukkanNamaPemain.Name = "buttonMasukkanNamaPemain";
            this.buttonMasukkanNamaPemain.Size = new System.Drawing.Size(123, 45);
            this.buttonMasukkanNamaPemain.TabIndex = 14;
            this.buttonMasukkanNamaPemain.Text = "OK";
            this.buttonMasukkanNamaPemain.UseVisualStyleBackColor = true;
            this.buttonMasukkanNamaPemain.Click += new System.EventHandler(this.buttonMasukkanNamaPemain_Click);
            // 
            // buttonMulaiPermainan
            // 
            this.buttonMulaiPermainan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMulaiPermainan.BackgroundImage")));
            this.buttonMulaiPermainan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMulaiPermainan.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonMulaiPermainan.Location = new System.Drawing.Point(108, 210);
            this.buttonMulaiPermainan.Name = "buttonMulaiPermainan";
            this.buttonMulaiPermainan.Size = new System.Drawing.Size(161, 65);
            this.buttonMulaiPermainan.TabIndex = 15;
            this.buttonMulaiPermainan.Text = "Mulai Permainan";
            this.buttonMulaiPermainan.UseVisualStyleBackColor = true;
            this.buttonMulaiPermainan.Click += new System.EventHandler(this.buttonMulaiPermainan_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonKeluar.BackgroundImage")));
            this.buttonKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonKeluar.Location = new System.Drawing.Point(139, 281);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(100, 31);
            this.buttonKeluar.TabIndex = 16;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = true;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(108, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 24);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Masukkan Nama Pemain : ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(355, 347);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonMulaiPermainan);
            this.Controls.Add(this.buttonMasukkanNamaPemain);
            this.Controls.Add(this.buttonPembuatPermainan);
            this.Controls.Add(this.buttonCaraBermain);
            this.Controls.Add(this.labelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonCaraBermain;
        private System.Windows.Forms.Button buttonPembuatPermainan;
        private System.Windows.Forms.Button buttonMasukkanNamaPemain;
        private System.Windows.Forms.Button buttonMulaiPermainan;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

