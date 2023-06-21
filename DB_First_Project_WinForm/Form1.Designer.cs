namespace DB_First_Project_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtAd = new TextBox();
            btnEkle = new Button();
            dgvBolgeler = new DataGridView();
            btnSil = new Button();
            btnGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBolgeler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 80);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Bolge Id: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 122);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Bolge Adı:";
            // 
            // txtId
            // 
            txtId.Location = new Point(142, 77);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(142, 119);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(67, 177);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvBolgeler
            // 
            dgvBolgeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBolgeler.Location = new Point(393, 26);
            dgvBolgeler.Name = "dgvBolgeler";
            dgvBolgeler.RowTemplate.Height = 25;
            dgvBolgeler.Size = new Size(374, 231);
            dgvBolgeler.TabIndex = 6;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(264, 177);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 7;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(167, 177);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "GUNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 296);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(dgvBolgeler);
            Controls.Add(btnEkle);
            Controls.Add(txtAd);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvBolgeler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtAd;
        private Button btnEkle;
        private DataGridView dgvBolgeler;
        private Button btnSil;
        private Button btnGuncelle;
    }
}