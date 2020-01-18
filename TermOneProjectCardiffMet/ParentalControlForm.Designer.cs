namespace TermOneProjectCardiffMet
{
    partial class ParentalControlForm
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
            this.listBoxFilters = new System.Windows.Forms.ListBox();
            this.btnRemoveFilter = new System.Windows.Forms.Button();
            this.textBoxAddFilter = new System.Windows.Forms.TextBox();
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApplySettings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelPINChanged = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNewPIN2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewPIN1 = new System.Windows.Forms.TextBox();
            this.btnChangePIN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxViewPIN = new System.Windows.Forms.TextBox();
            this.btnViewPIN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "View, remove and add filters. If filters are present in the web address bar, the " +
    "web browser will not navigate to that address.";
            // 
            // listBoxFilters
            // 
            this.listBoxFilters.FormattingEnabled = true;
            this.listBoxFilters.ItemHeight = 31;
            this.listBoxFilters.Location = new System.Drawing.Point(18, 149);
            this.listBoxFilters.Name = "listBoxFilters";
            this.listBoxFilters.Size = new System.Drawing.Size(685, 159);
            this.listBoxFilters.TabIndex = 1;
            // 
            // btnRemoveFilter
            // 
            this.btnRemoveFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.87F);
            this.btnRemoveFilter.Location = new System.Drawing.Point(424, 323);
            this.btnRemoveFilter.Name = "btnRemoveFilter";
            this.btnRemoveFilter.Size = new System.Drawing.Size(279, 40);
            this.btnRemoveFilter.TabIndex = 2;
            this.btnRemoveFilter.Text = "Remove selected filter";
            this.btnRemoveFilter.UseVisualStyleBackColor = true;
            this.btnRemoveFilter.Click += new System.EventHandler(this.BtnRemoveFilter_Click);
            // 
            // textBoxAddFilter
            // 
            this.textBoxAddFilter.Location = new System.Drawing.Point(21, 380);
            this.textBoxAddFilter.Name = "textBoxAddFilter";
            this.textBoxAddFilter.Size = new System.Drawing.Size(514, 38);
            this.textBoxAddFilter.TabIndex = 3;
            this.textBoxAddFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAddFilter_KeyDown);
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.87F);
            this.btnAddFilter.Location = new System.Drawing.Point(553, 380);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(150, 40);
            this.btnAddFilter.TabIndex = 4;
            this.btnAddFilter.Text = "Add filter";
            this.btnAddFilter.UseVisualStyleBackColor = true;
            this.btnAddFilter.Click += new System.EventHandler(this.BtnAddFilter_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(403, 792);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 40);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(574, 792);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApplySettings
            // 
            this.btnApplySettings.Location = new System.Drawing.Point(234, 792);
            this.btnApplySettings.Name = "btnApplySettings";
            this.btnApplySettings.Size = new System.Drawing.Size(150, 40);
            this.btnApplySettings.TabIndex = 7;
            this.btnApplySettings.Text = "Apply";
            this.btnApplySettings.UseVisualStyleBackColor = true;
            this.btnApplySettings.Click += new System.EventHandler(this.BtnApplySettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxFilters);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAddFilter);
            this.groupBox1.Controls.Add(this.btnAddFilter);
            this.groupBox1.Controls.Add(this.btnRemoveFilter);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(21, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 447);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Web Browser Filters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelPINChanged);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxNewPIN2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxNewPIN1);
            this.groupBox2.Controls.Add(this.btnChangePIN);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxViewPIN);
            this.groupBox2.Controls.Add(this.btnViewPIN);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(21, 479);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 280);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Security";
            // 
            // labelPINChanged
            // 
            this.labelPINChanged.AutoSize = true;
            this.labelPINChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelPINChanged.Location = new System.Drawing.Point(398, 239);
            this.labelPINChanged.Name = "labelPINChanged";
            this.labelPINChanged.Size = new System.Drawing.Size(152, 29);
            this.labelPINChanged.TabIndex = 18;
            this.labelPINChanged.Text = "PIN changed";
            this.labelPINChanged.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(16, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Confirm:";
            // 
            // textBoxNewPIN2
            // 
            this.textBoxNewPIN2.Location = new System.Drawing.Point(222, 183);
            this.textBoxNewPIN2.MaxLength = 4;
            this.textBoxNewPIN2.Name = "textBoxNewPIN2";
            this.textBoxNewPIN2.PasswordChar = '#';
            this.textBoxNewPIN2.Size = new System.Drawing.Size(160, 38);
            this.textBoxNewPIN2.TabIndex = 16;
            this.textBoxNewPIN2.TextChanged += new System.EventHandler(this.TextBoxNewPIN2_TextChanged);
            this.textBoxNewPIN2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxNewPIN2_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(16, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Choose new PIN:";
            // 
            // textBoxNewPIN1
            // 
            this.textBoxNewPIN1.Location = new System.Drawing.Point(222, 133);
            this.textBoxNewPIN1.MaxLength = 4;
            this.textBoxNewPIN1.Name = "textBoxNewPIN1";
            this.textBoxNewPIN1.PasswordChar = '#';
            this.textBoxNewPIN1.Size = new System.Drawing.Size(160, 38);
            this.textBoxNewPIN1.TabIndex = 14;
            this.textBoxNewPIN1.TextChanged += new System.EventHandler(this.TextBoxNewPIN1_TextChanged);
            // 
            // btnChangePIN
            // 
            this.btnChangePIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.87F);
            this.btnChangePIN.Location = new System.Drawing.Point(400, 182);
            this.btnChangePIN.Name = "btnChangePIN";
            this.btnChangePIN.Size = new System.Drawing.Size(150, 40);
            this.btnChangePIN.TabIndex = 13;
            this.btnChangePIN.Text = "Change PIN";
            this.btnChangePIN.UseVisualStyleBackColor = true;
            this.btnChangePIN.Click += new System.EventHandler(this.BtnChangePIN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Your PIN:";
            // 
            // textBoxViewPIN
            // 
            this.textBoxViewPIN.Location = new System.Drawing.Point(222, 58);
            this.textBoxViewPIN.Name = "textBoxViewPIN";
            this.textBoxViewPIN.ReadOnly = true;
            this.textBoxViewPIN.Size = new System.Drawing.Size(160, 38);
            this.textBoxViewPIN.TabIndex = 12;
            this.textBoxViewPIN.Text = "####";
            // 
            // btnViewPIN
            // 
            this.btnViewPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.87F);
            this.btnViewPIN.Location = new System.Drawing.Point(400, 57);
            this.btnViewPIN.Name = "btnViewPIN";
            this.btnViewPIN.Size = new System.Drawing.Size(150, 40);
            this.btnViewPIN.TabIndex = 8;
            this.btnViewPIN.Text = "View PIN";
            this.btnViewPIN.UseVisualStyleBackColor = true;
            this.btnViewPIN.Click += new System.EventHandler(this.BtnViewPIN_Click);
            // 
            // ParentalControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 860);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnApplySettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "ParentalControlForm";
            this.Text = "Set up parental controls";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxFilters;
        private System.Windows.Forms.Button btnRemoveFilter;
        private System.Windows.Forms.TextBox textBoxAddFilter;
        private System.Windows.Forms.Button btnAddFilter;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApplySettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxViewPIN;
        private System.Windows.Forms.Button btnViewPIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNewPIN2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNewPIN1;
        private System.Windows.Forms.Button btnChangePIN;
        private System.Windows.Forms.Label labelPINChanged;
    }
}