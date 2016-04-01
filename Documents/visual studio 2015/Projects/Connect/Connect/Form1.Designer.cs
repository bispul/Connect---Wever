namespace Connect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.waterPumpStatus = new System.Windows.Forms.Label();
            this.waterLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deviceName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, -11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connect";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(255, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Water Pump Status";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // waterPumpStatus
            // 
            this.waterPumpStatus.AutoSize = true;
            this.waterPumpStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterPumpStatus.ForeColor = System.Drawing.Color.Indigo;
            this.waterPumpStatus.Location = new System.Drawing.Point(284, 106);
            this.waterPumpStatus.Name = "waterPumpStatus";
            this.waterPumpStatus.Size = new System.Drawing.Size(55, 31);
            this.waterPumpStatus.TabIndex = 3;
            this.waterPumpStatus.Text = "ON";
            // 
            // waterLevel
            // 
            this.waterLevel.AutoSize = true;
            this.waterLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterLevel.ForeColor = System.Drawing.Color.Indigo;
            this.waterLevel.Location = new System.Drawing.Point(286, 195);
            this.waterLevel.Name = "waterLevel";
            this.waterLevel.Size = new System.Drawing.Size(53, 31);
            this.waterLevel.TabIndex = 5;
            this.waterLevel.Text = "0%";
            this.waterLevel.Click += new System.EventHandler(this.waterLevel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(275, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Water Level";
            // 
            // deviceName
            // 
            this.deviceName.AutoSize = true;
            this.deviceName.Font = new System.Drawing.Font("Minion Pro", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceName.ForeColor = System.Drawing.Color.DarkCyan;
            this.deviceName.Location = new System.Drawing.Point(149, 32);
            this.deviceName.Name = "deviceName";
            this.deviceName.Size = new System.Drawing.Size(135, 22);
            this.deviceName.TabIndex = 6;
            this.deviceName.Text = "Device Name : null";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(412, 265);
            this.Controls.Add(this.deviceName);
            this.Controls.Add(this.waterLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.waterPumpStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label waterPumpStatus;
        private System.Windows.Forms.Label waterLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label deviceName;
    }
}

