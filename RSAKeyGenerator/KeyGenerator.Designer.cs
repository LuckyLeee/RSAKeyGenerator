namespace RSAKeyGenerator
{
    partial class KeyGenerator
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyGenerator));
            this.txtPublicXml = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPrivateXml = new System.Windows.Forms.TextBox();
            this.grpPublicKey = new System.Windows.Forms.GroupBox();
            this.txtPublicPem = new System.Windows.Forms.TextBox();
            this.grpPrivateKey = new System.Windows.Forms.GroupBox();
            this.txtPrivatePem = new System.Windows.Forms.TextBox();
            this.rdo1024 = new System.Windows.Forms.RadioButton();
            this.rdo2048 = new System.Windows.Forms.RadioButton();
            this.grpPublicKey.SuspendLayout();
            this.grpPrivateKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPublicXml
            // 
            this.txtPublicXml.BackColor = System.Drawing.Color.White;
            this.txtPublicXml.Location = new System.Drawing.Point(6, 20);
            this.txtPublicXml.Multiline = true;
            this.txtPublicXml.Name = "txtPublicXml";
            this.txtPublicXml.ReadOnly = true;
            this.txtPublicXml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPublicXml.Size = new System.Drawing.Size(450, 145);
            this.txtPublicXml.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(861, 471);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtPrivateXml
            // 
            this.txtPrivateXml.BackColor = System.Drawing.Color.White;
            this.txtPrivateXml.Location = new System.Drawing.Point(6, 20);
            this.txtPrivateXml.Multiline = true;
            this.txtPrivateXml.Name = "txtPrivateXml";
            this.txtPrivateXml.ReadOnly = true;
            this.txtPrivateXml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrivateXml.Size = new System.Drawing.Size(450, 247);
            this.txtPrivateXml.TabIndex = 2;
            // 
            // grpPublicKey
            // 
            this.grpPublicKey.Controls.Add(this.txtPublicPem);
            this.grpPublicKey.Controls.Add(this.txtPublicXml);
            this.grpPublicKey.Location = new System.Drawing.Point(13, 13);
            this.grpPublicKey.Name = "grpPublicKey";
            this.grpPublicKey.Size = new System.Drawing.Size(921, 171);
            this.grpPublicKey.TabIndex = 3;
            this.grpPublicKey.TabStop = false;
            this.grpPublicKey.Text = "Public Key";
            // 
            // txtPublicPem
            // 
            this.txtPublicPem.BackColor = System.Drawing.Color.White;
            this.txtPublicPem.Location = new System.Drawing.Point(462, 20);
            this.txtPublicPem.Multiline = true;
            this.txtPublicPem.Name = "txtPublicPem";
            this.txtPublicPem.ReadOnly = true;
            this.txtPublicPem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPublicPem.Size = new System.Drawing.Size(450, 145);
            this.txtPublicPem.TabIndex = 1;
            // 
            // grpPrivateKey
            // 
            this.grpPrivateKey.Controls.Add(this.txtPrivatePem);
            this.grpPrivateKey.Controls.Add(this.txtPrivateXml);
            this.grpPrivateKey.Location = new System.Drawing.Point(13, 191);
            this.grpPrivateKey.Name = "grpPrivateKey";
            this.grpPrivateKey.Size = new System.Drawing.Size(921, 273);
            this.grpPrivateKey.TabIndex = 4;
            this.grpPrivateKey.TabStop = false;
            this.grpPrivateKey.Text = "Private Key";
            // 
            // txtPrivatePem
            // 
            this.txtPrivatePem.BackColor = System.Drawing.Color.White;
            this.txtPrivatePem.Location = new System.Drawing.Point(462, 20);
            this.txtPrivatePem.Multiline = true;
            this.txtPrivatePem.Name = "txtPrivatePem";
            this.txtPrivatePem.ReadOnly = true;
            this.txtPrivatePem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrivatePem.Size = new System.Drawing.Size(450, 247);
            this.txtPrivatePem.TabIndex = 3;
            // 
            // rdo1024
            // 
            this.rdo1024.AutoSize = true;
            this.rdo1024.Checked = true;
            this.rdo1024.Location = new System.Drawing.Point(703, 474);
            this.rdo1024.Name = "rdo1024";
            this.rdo1024.Size = new System.Drawing.Size(71, 16);
            this.rdo1024.TabIndex = 5;
            this.rdo1024.TabStop = true;
            this.rdo1024.Text = "1024 bit";
            this.rdo1024.UseVisualStyleBackColor = true;
            // 
            // rdo2048
            // 
            this.rdo2048.AutoSize = true;
            this.rdo2048.Location = new System.Drawing.Point(780, 474);
            this.rdo2048.Name = "rdo2048";
            this.rdo2048.Size = new System.Drawing.Size(71, 16);
            this.rdo2048.TabIndex = 6;
            this.rdo2048.Text = "2048 bit";
            this.rdo2048.UseVisualStyleBackColor = true;
            // 
            // KeyGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 502);
            this.Controls.Add(this.rdo2048);
            this.Controls.Add(this.rdo1024);
            this.Controls.Add(this.grpPrivateKey);
            this.Controls.Add(this.grpPublicKey);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KeyGenerator";
            this.Text = "RSA KeyGenerator";
            this.grpPublicKey.ResumeLayout(false);
            this.grpPublicKey.PerformLayout();
            this.grpPrivateKey.ResumeLayout(false);
            this.grpPrivateKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPublicXml;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPrivateXml;
        private System.Windows.Forms.GroupBox grpPublicKey;
        private System.Windows.Forms.GroupBox grpPrivateKey;
        private System.Windows.Forms.RadioButton rdo1024;
        private System.Windows.Forms.RadioButton rdo2048;
        private System.Windows.Forms.TextBox txtPublicPem;
        private System.Windows.Forms.TextBox txtPrivatePem;
    }
}

