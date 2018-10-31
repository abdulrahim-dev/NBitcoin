namespace BitCoinNew
{
    partial class Home
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
            this.lblAddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(270, 236);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(0, 13);
            this.lblAddress.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Public Key";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(273, 195);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(412, 20);
            this.txtPublicKey.TabIndex = 9;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(273, 155);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(412, 20);
            this.txtPrivateKey.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Private Key";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(273, 105);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(172, 29);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 487);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
    }
}

