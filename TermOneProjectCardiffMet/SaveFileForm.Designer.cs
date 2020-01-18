namespace TermOneProjectCardiffMet
{
    partial class SaveFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveFileForm));
            this.messageBtnYes = new System.Windows.Forms.Button();
            this.messageBtnNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.messageBtnSave = new System.Windows.Forms.Button();
            this.chckBoxDontAsk = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // messageBtnYes
            // 
            this.messageBtnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.messageBtnYes.Location = new System.Drawing.Point(201, 156);
            this.messageBtnYes.Name = "messageBtnYes";
            this.messageBtnYes.Size = new System.Drawing.Size(146, 58);
            this.messageBtnYes.TabIndex = 0;
            this.messageBtnYes.Text = "Yes";
            this.messageBtnYes.UseVisualStyleBackColor = true;
            // 
            // messageBtnNo
            // 
            this.messageBtnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.messageBtnNo.Location = new System.Drawing.Point(367, 156);
            this.messageBtnNo.Name = "messageBtnNo";
            this.messageBtnNo.Size = new System.Drawing.Size(146, 58);
            this.messageBtnNo.TabIndex = 1;
            this.messageBtnNo.Text = "No";
            this.messageBtnNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(195, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 120);
            this.label1.TabIndex = 2;
            this.label1.Text = "Getting a writing idea will delete your work. Are you sure?";
            // 
            // messageBtnSave
            // 
            this.messageBtnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.messageBtnSave.Location = new System.Drawing.Point(533, 156);
            this.messageBtnSave.Name = "messageBtnSave";
            this.messageBtnSave.Size = new System.Drawing.Size(146, 58);
            this.messageBtnSave.TabIndex = 4;
            this.messageBtnSave.Text = "Save first";
            this.messageBtnSave.UseVisualStyleBackColor = true;
            // 
            // chckBoxDontAsk
            // 
            this.chckBoxDontAsk.AutoSize = true;
            this.chckBoxDontAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chckBoxDontAsk.Location = new System.Drawing.Point(201, 113);
            this.chckBoxDontAsk.Name = "chckBoxDontAsk";
            this.chckBoxDontAsk.Size = new System.Drawing.Size(230, 30);
            this.chckBoxDontAsk.TabIndex = 5;
            this.chckBoxDontAsk.Text = "Don\'t ask me again";
            this.chckBoxDontAsk.UseVisualStyleBackColor = true;
            this.chckBoxDontAsk.CheckedChanged += new System.EventHandler(this.chckBoxDontAsk_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 249);
            this.Controls.Add(this.chckBoxDontAsk);
            this.Controls.Add(this.messageBtnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageBtnNo);
            this.Controls.Add(this.messageBtnYes);
            this.Name = "MessageForm";
            this.Text = "Warning";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button messageBtnYes;
        private System.Windows.Forms.Button messageBtnNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button messageBtnSave;
        private System.Windows.Forms.CheckBox chckBoxDontAsk;
    }
}