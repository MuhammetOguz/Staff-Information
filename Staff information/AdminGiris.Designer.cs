﻿namespace PersonelUygulaması
{
    partial class AdminGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txtkullaniciad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtsifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtgirisyap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // Txtkullaniciad
            // 
            this.Txtkullaniciad.Location = new System.Drawing.Point(127, 85);
            this.Txtkullaniciad.Name = "Txtkullaniciad";
            this.Txtkullaniciad.Size = new System.Drawing.Size(178, 31);
            this.Txtkullaniciad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // Txtsifre
            // 
            this.Txtsifre.Location = new System.Drawing.Point(127, 124);
            this.Txtsifre.Name = "Txtsifre";
            this.Txtsifre.Size = new System.Drawing.Size(178, 31);
            this.Txtsifre.TabIndex = 3;
            this.Txtsifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Bilgi Sistemi Giriş Paneli";
            // 
            // Txtgirisyap
            // 
            this.Txtgirisyap.Location = new System.Drawing.Point(138, 171);
            this.Txtgirisyap.Name = "Txtgirisyap";
            this.Txtgirisyap.Size = new System.Drawing.Size(144, 35);
            this.Txtgirisyap.TabIndex = 5;
            this.Txtgirisyap.Text = "Giriş Yap";
            this.Txtgirisyap.UseVisualStyleBackColor = true;
            this.Txtgirisyap.Click += new System.EventHandler(this.Txtgirisyap_Click);
            // 
            // AdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(463, 356);
            this.Controls.Add(this.Txtgirisyap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txtsifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtkullaniciad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminGiris";
            this.Text = "AdminGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtkullaniciad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtsifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Txtgirisyap;
    }
}