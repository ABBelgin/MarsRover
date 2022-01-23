namespace MarsRover
{
    partial class MarsRoverForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtInputCopy = new System.Windows.Forms.RichTextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.lblRulesHeader = new System.Windows.Forms.Label();
            this.lblFirstLineRule = new System.Windows.Forms.Label();
            this.lblSecondLineRule = new System.Windows.Forms.Label();
            this.labelThirdLineRule = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(84, 172);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(245, 60);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(84, 286);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(245, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(84, 257);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(245, 23);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Hareket Ettir";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader.Location = new System.Drawing.Point(80, 145);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(132, 23);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Bilgileri Giriniz ";
            // 
            // txtInputCopy
            // 
            this.txtInputCopy.Enabled = false;
            this.txtInputCopy.Location = new System.Drawing.Point(522, 171);
            this.txtInputCopy.Name = "txtInputCopy";
            this.txtInputCopy.Size = new System.Drawing.Size(245, 60);
            this.txtInputCopy.TabIndex = 4;
            this.txtInputCopy.Text = "";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblInput.ForeColor = System.Drawing.Color.Navy;
            this.lblInput.Location = new System.Drawing.Point(472, 171);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(44, 21);
            this.lblInput.TabIndex = 5;
            this.lblInput.Text = "Girdi";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.Navy;
            this.lblResult.Location = new System.Drawing.Point(464, 248);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 21);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Sonuç";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(522, 249);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(245, 60);
            this.txtResult.TabIndex = 7;
            this.txtResult.Text = "";
            // 
            // lblRulesHeader
            // 
            this.lblRulesHeader.AutoSize = true;
            this.lblRulesHeader.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblRulesHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblRulesHeader.Location = new System.Drawing.Point(80, 23);
            this.lblRulesHeader.Name = "lblRulesHeader";
            this.lblRulesHeader.Size = new System.Drawing.Size(138, 21);
            this.lblRulesHeader.TabIndex = 8;
            this.lblRulesHeader.Text = "Bilgi Giriş Kuralları";
            // 
            // lblFirstLineRule
            // 
            this.lblFirstLineRule.AutoSize = true;
            this.lblFirstLineRule.Font = new System.Drawing.Font("Calibri", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblFirstLineRule.Location = new System.Drawing.Point(81, 57);
            this.lblFirstLineRule.Name = "lblFirstLineRule";
            this.lblFirstLineRule.Size = new System.Drawing.Size(363, 15);
            this.lblFirstLineRule.TabIndex = 9;
            this.lblFirstLineRule.Text = "1. Satır iki rakamdan oluşur. Gezilebilecek alanın max (x,y) ikilisidir.";
            // 
            // lblSecondLineRule
            // 
            this.lblSecondLineRule.AutoSize = true;
            this.lblSecondLineRule.Font = new System.Drawing.Font("Calibri", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblSecondLineRule.Location = new System.Drawing.Point(81, 72);
            this.lblSecondLineRule.Name = "lblSecondLineRule";
            this.lblSecondLineRule.Size = new System.Drawing.Size(554, 15);
            this.lblSecondLineRule.TabIndex = 10;
            this.lblSecondLineRule.Text = "2. Satır için gezici koordinatları belirten iki rakam girilir, bir boşluk bırakıl" +
    "ır ve yönü belirten harf girilir.";
            // 
            // labelThirdLineRule
            // 
            this.labelThirdLineRule.AutoSize = true;
            this.labelThirdLineRule.Font = new System.Drawing.Font("Calibri", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelThirdLineRule.Location = new System.Drawing.Point(81, 87);
            this.labelThirdLineRule.Name = "labelThirdLineRule";
            this.labelThirdLineRule.Size = new System.Drawing.Size(371, 15);
            this.labelThirdLineRule.TabIndex = 11;
            this.labelThirdLineRule.Text = "3. Satır L,R ve M harflerinden oluşan hareket komutlarından oluşur.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(81, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Girilecek bilgiler 3 satırdan oluşmalıdır.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MarsRover.Properties.Resources.nasa;
            this.pictureBox1.Location = new System.Drawing.Point(270, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // MarsRoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelThirdLineRule);
            this.Controls.Add(this.lblSecondLineRule);
            this.Controls.Add(this.lblFirstLineRule);
            this.Controls.Add(this.lblRulesHeader);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInputCopy);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtInput);
            this.Name = "MarsRoverForm";
            this.Text = "Mars Rover";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.RichTextBox txtInputCopy;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Label lblRulesHeader;
        private System.Windows.Forms.Label lblFirstLineRule;
        private System.Windows.Forms.Label lblSecondLineRule;
        private System.Windows.Forms.Label labelThirdLineRule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

