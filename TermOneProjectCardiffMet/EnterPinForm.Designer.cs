namespace TermOneProjectCardiffMet
{
    partial class EnterPinForm
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
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPINOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "You need to enter your PIN to change these settings.";
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.Location = new System.Drawing.Point(52, 174);
            this.textBoxPIN.MaxLength = 4;
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.PasswordChar = '#';
            this.textBoxPIN.Size = new System.Drawing.Size(245, 31);
            this.textBoxPIN.TabIndex = 1;
            this.textBoxPIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPIN_KeyDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(46, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your four digit PIN.";
            // 
            // btnPINOK
            // 
            this.btnPINOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPINOK.Location = new System.Drawing.Point(331, 169);
            this.btnPINOK.Name = "btnPINOK";
            this.btnPINOK.Size = new System.Drawing.Size(139, 41);
            this.btnPINOK.TabIndex = 4;
            this.btnPINOK.Text = "OK";
            this.btnPINOK.UseVisualStyleBackColor = true;
            this.btnPINOK.Click += new System.EventHandler(this.BtnPINOK_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(485, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EnterPinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 283);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPINOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPIN);
            this.Controls.Add(this.label1);
            this.Name = "EnterPinForm";
            this.Text = "PIN required";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPINOK;
        private System.Windows.Forms.Button button1;
    }
}