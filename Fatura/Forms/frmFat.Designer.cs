
namespace Fatura.Forms
{
    partial class frmFat
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
            this.txFatNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txTarih = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txAd = new System.Windows.Forms.TextBox();
            this.txSoyad = new System.Windows.Forms.TextBox();
            this.txAdres = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txFatTop = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txMiktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuncel = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSevk = new System.Windows.Forms.Button();
            this.lbSevk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fat No";
            // 
            // txFatNo
            // 
            this.txFatNo.Location = new System.Drawing.Point(2, 36);
            this.txFatNo.Name = "txFatNo";
            this.txFatNo.Size = new System.Drawing.Size(100, 20);
            this.txFatNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih";
            // 
            // txTarih
            // 
            this.txTarih.Location = new System.Drawing.Point(137, 36);
            this.txTarih.Name = "txTarih";
            this.txTarih.Size = new System.Drawing.Size(100, 20);
            this.txTarih.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Soyad";
            // 
            // txAd
            // 
            this.txAd.Location = new System.Drawing.Point(271, 36);
            this.txAd.Name = "txAd";
            this.txAd.Size = new System.Drawing.Size(100, 20);
            this.txAd.TabIndex = 6;
            // 
            // txSoyad
            // 
            this.txSoyad.Location = new System.Drawing.Point(395, 36);
            this.txSoyad.Name = "txSoyad";
            this.txSoyad.Size = new System.Drawing.Size(100, 20);
            this.txSoyad.TabIndex = 7;
            // 
            // txAdres
            // 
            this.txAdres.Location = new System.Drawing.Point(321, 62);
            this.txAdres.Multiline = true;
            this.txAdres.Name = "txAdres";
            this.txAdres.Size = new System.Drawing.Size(122, 45);
            this.txAdres.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 98);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fatura Toplam";
            // 
            // txFatTop
            // 
            this.txFatTop.Location = new System.Drawing.Point(395, 244);
            this.txFatTop.Name = "txFatTop";
            this.txFatTop.Size = new System.Drawing.Size(100, 20);
            this.txFatTop.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(2, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 18);
            this.panel1.TabIndex = 12;
            // 
            // txMiktar
            // 
            this.txMiktar.Location = new System.Drawing.Point(688, 144);
            this.txMiktar.Name = "txMiktar";
            this.txMiktar.Size = new System.Drawing.Size(100, 20);
            this.txMiktar.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(647, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Miktar";
            // 
            // btnGuncel
            // 
            this.btnGuncel.Location = new System.Drawing.Point(643, 268);
            this.btnGuncel.Name = "btnGuncel";
            this.btnGuncel.Size = new System.Drawing.Size(75, 23);
            this.btnGuncel.TabIndex = 15;
            this.btnGuncel.Text = "Güncelle";
            this.btnGuncel.UseVisualStyleBackColor = true;
            this.btnGuncel.Click += new System.EventHandler(this.btnGuncel_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(724, 268);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(562, 268);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Ürün Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(615, 170);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(173, 90);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // btnSevk
            // 
            this.btnSevk.Location = new System.Drawing.Point(615, 33);
            this.btnSevk.Name = "btnSevk";
            this.btnSevk.Size = new System.Drawing.Size(75, 23);
            this.btnSevk.TabIndex = 19;
            this.btnSevk.Text = "Sevkiyat";
            this.btnSevk.UseVisualStyleBackColor = true;
            this.btnSevk.Click += new System.EventHandler(this.btnSevk_Click);
            // 
            // lbSevk
            // 
            this.lbSevk.AutoSize = true;
            this.lbSevk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSevk.Location = new System.Drawing.Point(241, 8);
            this.lbSevk.Name = "lbSevk";
            this.lbSevk.Size = new System.Drawing.Size(19, 25);
            this.lbSevk.TabIndex = 20;
            this.lbSevk.Text = "-";
            // 
            // frmFat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSevk);
            this.Controls.Add(this.btnSevk);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txMiktar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txFatTop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txAdres);
            this.Controls.Add(this.txSoyad);
            this.Controls.Add(this.txAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txFatNo);
            this.Controls.Add(this.label1);
            this.Name = "frmFat";
            this.Text = "frmFat";
            this.Load += new System.EventHandler(this.frmFat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txFatNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txAd;
        private System.Windows.Forms.TextBox txSoyad;
        private System.Windows.Forms.TextBox txAdres;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txFatTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txMiktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuncel;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSevk;
        private System.Windows.Forms.Label lbSevk;
    }
}