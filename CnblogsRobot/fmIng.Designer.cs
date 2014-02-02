namespace CnblogsRobot
{
    partial class fmIng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmIng));
            this.txtIng = new System.Windows.Forms.TextBox();
            this.cbPublic = new System.Windows.Forms.CheckBox();
            this.cbPrivate = new System.Windows.Forms.CheckBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLatest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblFansCnt = new System.Windows.Forms.Label();
            this.lblStarCnt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIng
            // 
            this.txtIng.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIng.Location = new System.Drawing.Point(162, 12);
            this.txtIng.Multiline = true;
            this.txtIng.Name = "txtIng";
            this.txtIng.Size = new System.Drawing.Size(327, 150);
            this.txtIng.TabIndex = 0;
            // 
            // cbPublic
            // 
            this.cbPublic.AutoSize = true;
            this.cbPublic.Location = new System.Drawing.Point(261, 270);
            this.cbPublic.Name = "cbPublic";
            this.cbPublic.Size = new System.Drawing.Size(48, 16);
            this.cbPublic.TabIndex = 1;
            this.cbPublic.Text = "公开";
            this.cbPublic.UseVisualStyleBackColor = true;
            // 
            // cbPrivate
            // 
            this.cbPrivate.AutoSize = true;
            this.cbPrivate.Location = new System.Drawing.Point(332, 269);
            this.cbPrivate.Name = "cbPrivate";
            this.cbPrivate.Size = new System.Drawing.Size(48, 16);
            this.cbPrivate.TabIndex = 2;
            this.cbPrivate.Text = "私有";
            this.cbPrivate.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(407, 265);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(75, 23);
            this.btnPublish.TabIndex = 3;
            this.btnPublish.Text = "发布";
            this.btnPublish.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 149);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "最近一条闪存：";
            // 
            // lblLatest
            // 
            this.lblLatest.AutoSize = true;
            this.lblLatest.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLatest.Location = new System.Drawing.Point(85, 198);
            this.lblLatest.Name = "lblLatest";
            this.lblLatest.Size = new System.Drawing.Size(0, 12);
            this.lblLatest.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "园龄：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "粉丝：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "星星：";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(52, 228);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(0, 12);
            this.lblAge.TabIndex = 8;
            // 
            // lblFansCnt
            // 
            this.lblFansCnt.AutoSize = true;
            this.lblFansCnt.Location = new System.Drawing.Point(54, 251);
            this.lblFansCnt.Name = "lblFansCnt";
            this.lblFansCnt.Size = new System.Drawing.Size(0, 12);
            this.lblFansCnt.TabIndex = 9;
            // 
            // lblStarCnt
            // 
            this.lblStarCnt.AutoSize = true;
            this.lblStarCnt.Location = new System.Drawing.Point(54, 275);
            this.lblStarCnt.Name = "lblStarCnt";
            this.lblStarCnt.Size = new System.Drawing.Size(0, 12);
            this.lblStarCnt.TabIndex = 10;
            // 
            // fmIng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 328);
            this.Controls.Add(this.lblStarCnt);
            this.Controls.Add(this.lblFansCnt);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLatest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.cbPrivate);
            this.Controls.Add(this.cbPublic);
            this.Controls.Add(this.txtIng);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmIng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "闪存客户端";
            this.Load += new System.EventHandler(this.fmIng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIng;
        private System.Windows.Forms.CheckBox cbPublic;
        private System.Windows.Forms.CheckBox cbPrivate;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLatest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblFansCnt;
        private System.Windows.Forms.Label lblStarCnt;
    }
}