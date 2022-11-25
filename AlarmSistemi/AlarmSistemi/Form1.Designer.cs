namespace AlarmSistemi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.lblHareket = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.cbxPort = new System.Windows.Forms.ComboBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMesaj);
            this.panel1.Controls.Add(this.btnBaglan);
            this.panel1.Controls.Add(this.lblHareket);
            this.panel1.Controls.Add(this.lblDurum);
            this.panel1.Controls.Add(this.lblPort);
            this.panel1.Controls.Add(this.cbxPort);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 427);
            this.panel1.TabIndex = 0;
            // 
            // btnBaglan
            // 
            this.btnBaglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaglan.Location = new System.Drawing.Point(582, 156);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(224, 46);
            this.btnBaglan.TabIndex = 15;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // lblHareket
            // 
            this.lblHareket.AutoSize = true;
            this.lblHareket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHareket.Location = new System.Drawing.Point(310, 218);
            this.lblHareket.Name = "lblHareket";
            this.lblHareket.Size = new System.Drawing.Size(226, 31);
            this.lblHareket.TabIndex = 14;
            this.lblHareket.Text = "Hareket Durumu :";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(33, 118);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(184, 25);
            this.lblDurum.TabIndex = 13;
            this.lblDurum.Text = "Bağlantı Durumu :";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPort.Location = new System.Drawing.Point(33, 164);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(64, 25);
            this.lblPort.TabIndex = 12;
            this.lblPort.Text = "Port :";
            // 
            // cbxPort
            // 
            this.cbxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxPort.FormattingEnabled = true;
            this.cbxPort.Location = new System.Drawing.Point(301, 164);
            this.cbxPort.Name = "cbxPort";
            this.cbxPort.Size = new System.Drawing.Size(200, 33);
            this.cbxPort.TabIndex = 11;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(262, 263);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 25);
            this.lblMesaj.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 451);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Güvenlik Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHareket;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cbxPort;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Label lblMesaj;
    }
}

