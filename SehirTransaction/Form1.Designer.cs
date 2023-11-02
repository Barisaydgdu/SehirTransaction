
namespace SehirTransaction
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIlAd = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstIlceler = new System.Windows.Forms.ListBox();
            this.txtIlceAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İL:";
            // 
            // txtIlAd
            // 
            this.txtIlAd.Location = new System.Drawing.Point(98, 31);
            this.txtIlAd.Name = "txtIlAd";
            this.txtIlAd.Size = new System.Drawing.Size(236, 20);
            this.txtIlAd.TabIndex = 1;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(98, 57);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(236, 20);
            this.txtPlaka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PLAKA:";
            // 
            // lstIlceler
            // 
            this.lstIlceler.FormattingEnabled = true;
            this.lstIlceler.Location = new System.Drawing.Point(57, 94);
            this.lstIlceler.Name = "lstIlceler";
            this.lstIlceler.Size = new System.Drawing.Size(115, 225);
            this.lstIlceler.TabIndex = 4;
            // 
            // txtIlceAd
            // 
            this.txtIlceAd.Location = new System.Drawing.Point(227, 94);
            this.txtIlceAd.Name = "txtIlceAd";
            this.txtIlceAd.Size = new System.Drawing.Size(107, 20);
            this.txtIlceAd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "İLÇE AD:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "İLÇE EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "İL VE İLÇELERİNİ KAYDET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(454, 46);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(155, 273);
            this.treeView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIlceAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstIlceler);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIlAd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIlAd;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstIlceler;
        private System.Windows.Forms.TextBox txtIlceAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView treeView1;
    }
}

