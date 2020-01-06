namespace TermOneProjectCardiffMet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.welcomePage = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.TabPage();
            this.browserHistory = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.webAddressBox = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.calculator = new System.Windows.Forms.TabPage();
            this.ideaBox = new System.Windows.Forms.TextBox();
            this.btnIdeaGenerator = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearSums = new System.Windows.Forms.Button();
            this.calcHistory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.calcBtn9 = new System.Windows.Forms.Button();
            this.calcBtnClear = new System.Windows.Forms.Button();
            this.CalcDisplay = new System.Windows.Forms.TextBox();
            this.calcBtn8 = new System.Windows.Forms.Button();
            this.calcBtnDivide = new System.Windows.Forms.Button();
            this.calcBtnEquals = new System.Windows.Forms.Button();
            this.calcBtn7 = new System.Windows.Forms.Button();
            this.calcBtnMultiply = new System.Windows.Forms.Button();
            this.calcBtnMinus = new System.Windows.Forms.Button();
            this.calcBtn6 = new System.Windows.Forms.Button();
            this.calcBtnPlus = new System.Windows.Forms.Button();
            this.calcBtn0 = new System.Windows.Forms.Button();
            this.calcBtn1 = new System.Windows.Forms.Button();
            this.calcBtn5 = new System.Windows.Forms.Button();
            this.calcBtn4 = new System.Windows.Forms.Button();
            this.calcBtn3 = new System.Windows.Forms.Button();
            this.calcBtn2 = new System.Windows.Forms.Button();
            this.textEditor = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRandomStyle = new System.Windows.Forms.Button();
            this.btnWritingPrompt = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.openFile = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.textColor6 = new System.Windows.Forms.Button();
            this.textColor5 = new System.Windows.Forms.Button();
            this.textColor4 = new System.Windows.Forms.Button();
            this.textColor3 = new System.Windows.Forms.Button();
            this.textColor2 = new System.Windows.Forms.Button();
            this.textColor1 = new System.Windows.Forms.Button();
            this.backColor6 = new System.Windows.Forms.Button();
            this.backColor5 = new System.Windows.Forms.Button();
            this.backColor4 = new System.Windows.Forms.Button();
            this.backColor3 = new System.Windows.Forms.Button();
            this.backColor2 = new System.Windows.Forms.Button();
            this.backColor1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fontList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.webBrowser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.calculator.SuspendLayout();
            this.panel3.SuspendLayout();
            this.textEditor.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.welcomePage);
            this.tabControl1.Controls.Add(this.webBrowser);
            this.tabControl1.Controls.Add(this.calculator);
            this.tabControl1.Controls.Add(this.textEditor);
            this.tabControl1.Location = new System.Drawing.Point(2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1767, 964);
            this.tabControl1.TabIndex = 0;
            // 
            // welcomePage
            // 
            this.welcomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.welcomePage.Location = new System.Drawing.Point(8, 39);
            this.welcomePage.Name = "welcomePage";
            this.welcomePage.Size = new System.Drawing.Size(1751, 917);
            this.welcomePage.TabIndex = 3;
            this.welcomePage.Text = "Welcome";
            // 
            // webBrowser
            // 
            this.webBrowser.Controls.Add(this.browserHistory);
            this.webBrowser.Controls.Add(this.webBrowser1);
            this.webBrowser.Controls.Add(this.panel1);
            this.webBrowser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webBrowser.Location = new System.Drawing.Point(8, 39);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.webBrowser.Size = new System.Drawing.Size(1751, 917);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Text = "Browse the web";
            this.webBrowser.UseVisualStyleBackColor = true;
            // 
            // browserHistory
            // 
            this.browserHistory.FormattingEnabled = true;
            this.browserHistory.ItemHeight = 37;
            this.browserHistory.Items.AddRange(new object[] {
            "https://www.ecosia.org/"});
            this.browserHistory.Location = new System.Drawing.Point(1236, 90);
            this.browserHistory.Name = "browserHistory";
            this.browserHistory.Size = new System.Drawing.Size(350, 448);
            this.browserHistory.TabIndex = 4;
            this.browserHistory.Visible = false;
            this.browserHistory.SelectedIndexChanged += new System.EventHandler(this.browserHistory_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(-8, 110);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1605, 734);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://www.ecosia.org/?c=en", System.UriKind.Absolute);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Controls.Add(this.webAddressBox);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(37, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1560, 101);
            this.panel1.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = global::TermOneProjectCardiffMet.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Location = new System.Drawing.Point(1377, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 74);
            this.btnRefresh.TabIndex = 17;
            this.toolTip.SetToolTip(this.btnRefresh, "Refresh");
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.btnGo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(1106, 7);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(87, 74);
            this.btnGo.TabIndex = 16;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.BackgroundImage = global::TermOneProjectCardiffMet.Properties.Resources.history;
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHistory.ForeColor = System.Drawing.Color.Transparent;
            this.btnHistory.Location = new System.Drawing.Point(1466, 7);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(83, 74);
            this.btnHistory.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnHistory, "See your history");
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnForward
            // 
            this.btnForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.BackgroundImage = global::TermOneProjectCardiffMet.Properties.Resources.ForwardArrow;
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnForward.ForeColor = System.Drawing.Color.Transparent;
            this.btnForward.Location = new System.Drawing.Point(1288, 7);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(83, 74);
            this.btnForward.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnForward, "Go forward");
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.button2_Click);
            // 
            // webAddressBox
            // 
            this.webAddressBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webAddressBox.Location = new System.Drawing.Point(3, 22);
            this.webAddressBox.Name = "webAddressBox";
            this.webAddressBox.Size = new System.Drawing.Size(1083, 45);
            this.webAddressBox.TabIndex = 2;
            this.webAddressBox.Text = "https://www.ecosia.org/";
            this.toolTip.SetToolTip(this.webAddressBox, "Enter web address");
            this.webAddressBox.Enter += new System.EventHandler(this.btnGo_Click);
            this.webAddressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.webAddressBox_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::TermOneProjectCardiffMet.Properties.Resources.BackArrow;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.ImageIndex = 0;
            this.btnBack.Location = new System.Drawing.Point(1199, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 74);
            this.btnBack.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnBack, "Go back");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // calculator
            // 
            this.calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calculator.Controls.Add(this.ideaBox);
            this.calculator.Controls.Add(this.btnIdeaGenerator);
            this.calculator.Controls.Add(this.label8);
            this.calculator.Controls.Add(this.btnClearSums);
            this.calculator.Controls.Add(this.calcHistory);
            this.calculator.Controls.Add(this.label1);
            this.calculator.Controls.Add(this.label2);
            this.calculator.Controls.Add(this.panel3);
            this.calculator.Location = new System.Drawing.Point(8, 39);
            this.calculator.Name = "calculator";
            this.calculator.Padding = new System.Windows.Forms.Padding(3);
            this.calculator.Size = new System.Drawing.Size(1751, 917);
            this.calculator.TabIndex = 1;
            this.calculator.Text = "Play with numbers";
            // 
            // ideaBox
            // 
            this.ideaBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ideaBox.Location = new System.Drawing.Point(197, 727);
            this.ideaBox.Name = "ideaBox";
            this.ideaBox.Size = new System.Drawing.Size(655, 57);
            this.ideaBox.TabIndex = 18;
            // 
            // btnIdeaGenerator
            // 
            this.btnIdeaGenerator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(240)))));
            this.btnIdeaGenerator.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdeaGenerator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.btnIdeaGenerator.Location = new System.Drawing.Point(18, 726);
            this.btnIdeaGenerator.Name = "btnIdeaGenerator";
            this.btnIdeaGenerator.Size = new System.Drawing.Size(163, 58);
            this.btnIdeaGenerator.TabIndex = 20;
            this.btnIdeaGenerator.Text = "Get Ideas";
            this.btnIdeaGenerator.UseVisualStyleBackColor = false;
            this.btnIdeaGenerator.Click += new System.EventHandler(this.btnIdeaGenerator_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.label8.Location = new System.Drawing.Point(6, 660);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(846, 50);
            this.label8.TabIndex = 19;
            this.label8.Text = "Click below to get ideas for sums to try:";
            // 
            // btnClearSums
            // 
            this.btnClearSums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(240)))));
            this.btnClearSums.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.btnClearSums.Location = new System.Drawing.Point(662, 574);
            this.btnClearSums.Name = "btnClearSums";
            this.btnClearSums.Size = new System.Drawing.Size(361, 53);
            this.btnClearSums.TabIndex = 18;
            this.btnClearSums.Text = "Clear sums";
            this.btnClearSums.UseVisualStyleBackColor = false;
            this.btnClearSums.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // calcHistory
            // 
            this.calcHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.calcHistory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcHistory.ForeColor = System.Drawing.Color.White;
            this.calcHistory.Location = new System.Drawing.Point(662, 191);
            this.calcHistory.Multiline = true;
            this.calcHistory.Name = "calcHistory";
            this.calcHistory.ReadOnly = true;
            this.calcHistory.Size = new System.Drawing.Size(361, 377);
            this.calcHistory.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(923, 87);
            this.label1.TabIndex = 4;
            this.label1.Text = "Let\'s play with numbers!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(718, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your sums";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(240)))));
            this.panel3.Controls.Add(this.calcBtn9);
            this.panel3.Controls.Add(this.calcBtnClear);
            this.panel3.Controls.Add(this.CalcDisplay);
            this.panel3.Controls.Add(this.calcBtn8);
            this.panel3.Controls.Add(this.calcBtnDivide);
            this.panel3.Controls.Add(this.calcBtnEquals);
            this.panel3.Controls.Add(this.calcBtn7);
            this.panel3.Controls.Add(this.calcBtnMultiply);
            this.panel3.Controls.Add(this.calcBtnMinus);
            this.panel3.Controls.Add(this.calcBtn6);
            this.panel3.Controls.Add(this.calcBtnPlus);
            this.panel3.Controls.Add(this.calcBtn0);
            this.panel3.Controls.Add(this.calcBtn1);
            this.panel3.Controls.Add(this.calcBtn5);
            this.panel3.Controls.Add(this.calcBtn4);
            this.panel3.Controls.Add(this.calcBtn3);
            this.panel3.Controls.Add(this.calcBtn2);
            this.panel3.Location = new System.Drawing.Point(18, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 488);
            this.panel3.TabIndex = 7;
            // 
            // calcBtn9
            // 
            this.calcBtn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.calcBtn9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn9.ForeColor = System.Drawing.Color.White;
            this.calcBtn9.Location = new System.Drawing.Point(243, 297);
            this.calcBtn9.Name = "calcBtn9";
            this.calcBtn9.Size = new System.Drawing.Size(92, 78);
            this.calcBtn9.TabIndex = 9;
            this.calcBtn9.Text = "9";
            this.calcBtn9.UseVisualStyleBackColor = false;
            this.calcBtn9.Click += new System.EventHandler(this.calcBtn9_Click);
            // 
            // calcBtnClear
            // 
            this.calcBtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(192)))), ((int)(((byte)(72)))));
            this.calcBtnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtnClear.ForeColor = System.Drawing.Color.Black;
            this.calcBtnClear.Location = new System.Drawing.Point(369, 390);
            this.calcBtnClear.Name = "calcBtnClear";
            this.calcBtnClear.Size = new System.Drawing.Size(190, 78);
            this.calcBtnClear.TabIndex = 17;
            this.calcBtnClear.Text = "Clear";
            this.calcBtnClear.UseVisualStyleBackColor = false;
            this.calcBtnClear.Click += new System.EventHandler(this.calcBtnClear_Click);
            // 
            // CalcDisplay
            // 
            this.CalcDisplay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcDisplay.Location = new System.Drawing.Point(28, 27);
            this.CalcDisplay.Name = "CalcDisplay";
            this.CalcDisplay.Size = new System.Drawing.Size(531, 57);
            this.CalcDisplay.TabIndex = 3;
            // 
            // calcBtn8
            // 
            this.calcBtn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.calcBtn8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn8.ForeColor = System.Drawing.Color.White;
            this.calcBtn8.Location = new System.Drawing.Point(135, 297);
            this.calcBtn8.Name = "calcBtn8";
            this.calcBtn8.Size = new System.Drawing.Size(92, 78);
            this.calcBtn8.TabIndex = 8;
            this.calcBtn8.Text = "8";
            this.calcBtn8.UseVisualStyleBackColor = false;
            this.calcBtn8.Click += new System.EventHandler(this.calcBtn8_Click);
            // 
            // calcBtnDivide
            // 
            this.calcBtnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(192)))), ((int)(((byte)(72)))));
            this.calcBtnDivide.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtnDivide.ForeColor = System.Drawing.Color.Black;
            this.calcBtnDivide.Location = new System.Drawing.Point(467, 202);
            this.calcBtnDivide.Name = "calcBtnDivide";
            this.calcBtnDivide.Size = new System.Drawing.Size(92, 78);
            this.calcBtnDivide.TabIndex = 14;
            this.calcBtnDivide.Text = "÷";
            this.toolTip.SetToolTip(this.calcBtnDivide, "Divide by the number");
            this.calcBtnDivide.UseVisualStyleBackColor = false;
            this.calcBtnDivide.Click += new System.EventHandler(this.calcBtnDivide_Click);
            // 
            // calcBtnEquals
            // 
            this.calcBtnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(192)))), ((int)(((byte)(72)))));
            this.calcBtnEquals.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtnEquals.ForeColor = System.Drawing.Color.Black;
            this.calcBtnEquals.Location = new System.Drawing.Point(369, 297);
            this.calcBtnEquals.Name = "calcBtnEquals";
            this.calcBtnEquals.Size = new System.Drawing.Size(190, 78);
            this.calcBtnEquals.TabIndex = 15;
            this.calcBtnEquals.Text = "=";
            this.calcBtnEquals.UseVisualStyleBackColor = false;
            this.calcBtnEquals.Click += new System.EventHandler(this.calcBtnEquals_Click);
            // 
            // calcBtn7
            // 
            this.calcBtn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.calcBtn7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn7.ForeColor = System.Drawing.Color.White;
            this.calcBtn7.Location = new System.Drawing.Point(26, 297);
            this.calcBtn7.Name = "calcBtn7";
            this.calcBtn7.Size = new System.Drawing.Size(92, 78);
            this.calcBtn7.TabIndex = 7;
            this.calcBtn7.Text = "7";
            this.calcBtn7.UseVisualStyleBackColor = false;
            this.calcBtn7.Click += new System.EventHandler(this.calcBtn7_Click);
            // 
            // calcBtnMultiply
            // 
            this.calcBtnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(192)))), ((int)(((byte)(72)))));
            this.calcBtnMultiply.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtnMultiply.ForeColor = System.Drawing.Color.Black;
            this.calcBtnMultiply.Location = new System.Drawing.Point(369, 202);
            this.calcBtnMultiply.Name = "calcBtnMultiply";
            this.calcBtnMultiply.Size = new System.Drawing.Size(92, 78);
            this.calcBtnMultiply.TabIndex = 13;
            this.calcBtnMultiply.Text = "x";
            this.toolTip.SetToolTip(this.calcBtnMultiply, "Times the numbers together");
            this.calcBtnMultiply.UseVisualStyleBackColor = false;
            this.calcBtnMultiply.Click += new System.EventHandler(this.calcBtnMultiply_Click);
            // 
            // calcBtnMinus
            // 
            this.calcBtnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(192)))), ((int)(((byte)(72)))));
            this.calcBtnMinus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtnMinus.ForeColor = System.Drawing.Color.Black;
            this.calcBtnMinus.Location = new System.Drawing.Point(467, 107);
            this.calcBtnMinus.Name = "calcBtnMinus";
            this.calcBtnMinus.Size = new System.Drawing.Size(92, 78);
            this.calcBtnMinus.TabIndex = 12;
            this.calcBtnMinus.Text = "-";
            this.toolTip.SetToolTip(this.calcBtnMinus, "Take the number away");
            this.calcBtnMinus.UseVisualStyleBackColor = false;
            this.calcBtnMinus.Click += new System.EventHandler(this.calcBtnMinus_Click);
            // 
            // calcBtn6
            // 
            this.calcBtn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.calcBtn6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn6.ForeColor = System.Drawing.Color.White;
            this.calcBtn6.Location = new System.Drawing.Point(243, 202);
            this.calcBtn6.Name = "calcBtn6";
            this.calcBtn6.Size = new System.Drawing.Size(92, 78);
            this.calcBtn6.TabIndex = 6;
            this.calcBtn6.Text = "6";
            this.calcBtn6.UseVisualStyleBackColor = false;
            this.calcBtn6.Click += new System.EventHandler(this.calcBtn6_Click);
            // 
            // calcBtnPlus
            // 
            this.calcBtnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(192)))), ((int)(((byte)(72)))));
            this.calcBtnPlus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtnPlus.ForeColor = System.Drawing.Color.Black;
            this.calcBtnPlus.Location = new System.Drawing.Point(369, 107);
            this.calcBtnPlus.Name = "calcBtnPlus";
            this.calcBtnPlus.Size = new System.Drawing.Size(92, 78);
            this.calcBtnPlus.TabIndex = 11;
            this.calcBtnPlus.Text = "+";
            this.toolTip.SetToolTip(this.calcBtnPlus, "Add the numbers together");
            this.calcBtnPlus.UseVisualStyleBackColor = false;
            this.calcBtnPlus.Click += new System.EventHandler(this.calcBtnPlus_Click);
            // 
            // calcBtn0
            // 
            this.calcBtn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.calcBtn0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn0.ForeColor = System.Drawing.Color.White;
            this.calcBtn0.Location = new System.Drawing.Point(135, 390);
            this.calcBtn0.Name = "calcBtn0";
            this.calcBtn0.Size = new System.Drawing.Size(92, 78);
            this.calcBtn0.TabIndex = 10;
            this.calcBtn0.Text = "0";
            this.calcBtn0.UseVisualStyleBackColor = false;
            this.calcBtn0.Click += new System.EventHandler(this.calcBtn0_Click);
            // 
            // calcBtn1
            // 
            this.calcBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.calcBtn1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn1.ForeColor = System.Drawing.Color.White;
            this.calcBtn1.Location = new System.Drawing.Point(26, 107);
            this.calcBtn1.Name = "calcBtn1";
            this.calcBtn1.Size = new System.Drawing.Size(92, 78);
            this.calcBtn1.TabIndex = 1;
            this.calcBtn1.Text = "1";
            this.calcBtn1.UseVisualStyleBackColor = false;
            this.calcBtn1.Click += new System.EventHandler(this.calcBtn1_Click);
            // 
            // calcBtn5
            // 
            this.calcBtn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.calcBtn5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn5.ForeColor = System.Drawing.Color.White;
            this.calcBtn5.Location = new System.Drawing.Point(135, 202);
            this.calcBtn5.Name = "calcBtn5";
            this.calcBtn5.Size = new System.Drawing.Size(92, 78);
            this.calcBtn5.TabIndex = 5;
            this.calcBtn5.Text = "5";
            this.calcBtn5.UseVisualStyleBackColor = false;
            this.calcBtn5.Click += new System.EventHandler(this.calcBtn5_Click);
            // 
            // calcBtn4
            // 
            this.calcBtn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.calcBtn4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn4.ForeColor = System.Drawing.Color.White;
            this.calcBtn4.Location = new System.Drawing.Point(26, 202);
            this.calcBtn4.Name = "calcBtn4";
            this.calcBtn4.Size = new System.Drawing.Size(92, 78);
            this.calcBtn4.TabIndex = 4;
            this.calcBtn4.Text = "4";
            this.calcBtn4.UseVisualStyleBackColor = false;
            this.calcBtn4.Click += new System.EventHandler(this.calcBtn4_Click);
            // 
            // calcBtn3
            // 
            this.calcBtn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.calcBtn3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn3.ForeColor = System.Drawing.Color.White;
            this.calcBtn3.Location = new System.Drawing.Point(243, 107);
            this.calcBtn3.Name = "calcBtn3";
            this.calcBtn3.Size = new System.Drawing.Size(92, 78);
            this.calcBtn3.TabIndex = 3;
            this.calcBtn3.Text = "3";
            this.calcBtn3.UseVisualStyleBackColor = false;
            this.calcBtn3.Click += new System.EventHandler(this.calcBtn3_Click);
            // 
            // calcBtn2
            // 
            this.calcBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.calcBtn2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn2.ForeColor = System.Drawing.Color.White;
            this.calcBtn2.Location = new System.Drawing.Point(135, 107);
            this.calcBtn2.Name = "calcBtn2";
            this.calcBtn2.Size = new System.Drawing.Size(92, 78);
            this.calcBtn2.TabIndex = 2;
            this.calcBtn2.Text = "2";
            this.calcBtn2.UseVisualStyleBackColor = false;
            this.calcBtn2.Click += new System.EventHandler(this.calcBtn2_Click);
            // 
            // textEditor
            // 
            this.textEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textEditor.Controls.Add(this.panel2);
            this.textEditor.Controls.Add(this.label3);
            this.textEditor.Location = new System.Drawing.Point(8, 39);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(1751, 917);
            this.textEditor.TabIndex = 2;
            this.textEditor.Text = "Write";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRandomStyle);
            this.panel2.Controls.Add(this.btnWritingPrompt);
            this.panel2.Controls.Add(this.richTextBox);
            this.panel2.Controls.Add(this.openFile);
            this.panel2.Controls.Add(this.saveBtn);
            this.panel2.Controls.Add(this.textColor6);
            this.panel2.Controls.Add(this.textColor5);
            this.panel2.Controls.Add(this.textColor4);
            this.panel2.Controls.Add(this.textColor3);
            this.panel2.Controls.Add(this.textColor2);
            this.panel2.Controls.Add(this.textColor1);
            this.panel2.Controls.Add(this.backColor6);
            this.panel2.Controls.Add(this.backColor5);
            this.panel2.Controls.Add(this.backColor4);
            this.panel2.Controls.Add(this.backColor3);
            this.panel2.Controls.Add(this.backColor2);
            this.panel2.Controls.Add(this.backColor1);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.fontList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1751, 830);
            this.panel2.TabIndex = 3;
            // 
            // btnRandomStyle
            // 
            this.btnRandomStyle.Location = new System.Drawing.Point(432, 660);
            this.btnRandomStyle.Name = "btnRandomStyle";
            this.btnRandomStyle.Size = new System.Drawing.Size(126, 56);
            this.btnRandomStyle.TabIndex = 25;
            this.btnRandomStyle.Text = "Random";
            this.btnRandomStyle.UseVisualStyleBackColor = true;
            this.btnRandomStyle.Click += new System.EventHandler(this.btnRandomStyle_Click);
            // 
            // btnWritingPrompt
            // 
            this.btnWritingPrompt.Location = new System.Drawing.Point(564, 660);
            this.btnWritingPrompt.Name = "btnWritingPrompt";
            this.btnWritingPrompt.Size = new System.Drawing.Size(126, 56);
            this.btnWritingPrompt.TabIndex = 24;
            this.btnWritingPrompt.Text = "Get idea";
            this.btnWritingPrompt.UseVisualStyleBackColor = true;
            this.btnWritingPrompt.Click += new System.EventHandler(this.btnWritingPrompt_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(5, 13);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(966, 644);
            this.richTextBox.TabIndex = 4;
            this.richTextBox.Text = "Write something here and change the font, size and colours.";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(828, 660);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(126, 56);
            this.openFile.TabIndex = 23;
            this.openFile.Text = "Open file";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.button18_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(696, 660);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(126, 56);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.Button17_Click);
            // 
            // textColor6
            // 
            this.textColor6.BackColor = System.Drawing.Color.Black;
            this.textColor6.Location = new System.Drawing.Point(1351, 590);
            this.textColor6.Name = "textColor6";
            this.textColor6.Size = new System.Drawing.Size(67, 54);
            this.textColor6.TabIndex = 22;
            this.textColor6.UseVisualStyleBackColor = false;
            this.textColor6.Click += new System.EventHandler(this.textColor6_Click);
            // 
            // textColor5
            // 
            this.textColor5.BackColor = System.Drawing.Color.Green;
            this.textColor5.Location = new System.Drawing.Point(1278, 590);
            this.textColor5.Name = "textColor5";
            this.textColor5.Size = new System.Drawing.Size(67, 54);
            this.textColor5.TabIndex = 21;
            this.textColor5.UseVisualStyleBackColor = false;
            this.textColor5.Click += new System.EventHandler(this.textColor5_Click);
            // 
            // textColor4
            // 
            this.textColor4.BackColor = System.Drawing.Color.Yellow;
            this.textColor4.Location = new System.Drawing.Point(1205, 590);
            this.textColor4.Name = "textColor4";
            this.textColor4.Size = new System.Drawing.Size(67, 54);
            this.textColor4.TabIndex = 20;
            this.textColor4.UseVisualStyleBackColor = false;
            this.textColor4.Click += new System.EventHandler(this.textColor4_Click);
            // 
            // textColor3
            // 
            this.textColor3.BackColor = System.Drawing.Color.Blue;
            this.textColor3.Location = new System.Drawing.Point(1132, 590);
            this.textColor3.Name = "textColor3";
            this.textColor3.Size = new System.Drawing.Size(67, 54);
            this.textColor3.TabIndex = 19;
            this.textColor3.UseVisualStyleBackColor = false;
            this.textColor3.Click += new System.EventHandler(this.textColor3_Click);
            // 
            // textColor2
            // 
            this.textColor2.BackColor = System.Drawing.Color.Red;
            this.textColor2.Location = new System.Drawing.Point(1059, 590);
            this.textColor2.Name = "textColor2";
            this.textColor2.Size = new System.Drawing.Size(67, 54);
            this.textColor2.TabIndex = 18;
            this.textColor2.UseVisualStyleBackColor = false;
            this.textColor2.Click += new System.EventHandler(this.textColor2_Click);
            // 
            // textColor1
            // 
            this.textColor1.BackColor = System.Drawing.Color.White;
            this.textColor1.Location = new System.Drawing.Point(986, 590);
            this.textColor1.Name = "textColor1";
            this.textColor1.Size = new System.Drawing.Size(67, 54);
            this.textColor1.TabIndex = 17;
            this.textColor1.UseVisualStyleBackColor = false;
            this.textColor1.Click += new System.EventHandler(this.textColor1_Click);
            // 
            // backColor6
            // 
            this.backColor6.BackColor = System.Drawing.Color.Black;
            this.backColor6.Location = new System.Drawing.Point(1351, 467);
            this.backColor6.Name = "backColor6";
            this.backColor6.Size = new System.Drawing.Size(67, 54);
            this.backColor6.TabIndex = 16;
            this.backColor6.UseVisualStyleBackColor = false;
            this.backColor6.Click += new System.EventHandler(this.button9_Click);
            // 
            // backColor5
            // 
            this.backColor5.BackColor = System.Drawing.Color.Green;
            this.backColor5.Location = new System.Drawing.Point(1278, 467);
            this.backColor5.Name = "backColor5";
            this.backColor5.Size = new System.Drawing.Size(67, 54);
            this.backColor5.TabIndex = 15;
            this.backColor5.UseVisualStyleBackColor = false;
            this.backColor5.Click += new System.EventHandler(this.button8_Click);
            // 
            // backColor4
            // 
            this.backColor4.BackColor = System.Drawing.Color.Yellow;
            this.backColor4.Location = new System.Drawing.Point(1205, 467);
            this.backColor4.Name = "backColor4";
            this.backColor4.Size = new System.Drawing.Size(67, 54);
            this.backColor4.TabIndex = 14;
            this.backColor4.UseVisualStyleBackColor = false;
            this.backColor4.Click += new System.EventHandler(this.button6_Click);
            // 
            // backColor3
            // 
            this.backColor3.BackColor = System.Drawing.Color.Blue;
            this.backColor3.Location = new System.Drawing.Point(1132, 467);
            this.backColor3.Name = "backColor3";
            this.backColor3.Size = new System.Drawing.Size(67, 54);
            this.backColor3.TabIndex = 13;
            this.backColor3.UseVisualStyleBackColor = false;
            this.backColor3.Click += new System.EventHandler(this.button5_Click);
            // 
            // backColor2
            // 
            this.backColor2.BackColor = System.Drawing.Color.Red;
            this.backColor2.Location = new System.Drawing.Point(1059, 467);
            this.backColor2.Name = "backColor2";
            this.backColor2.Size = new System.Drawing.Size(67, 54);
            this.backColor2.TabIndex = 12;
            this.backColor2.UseVisualStyleBackColor = false;
            this.backColor2.Click += new System.EventHandler(this.backColor2_Click);
            // 
            // backColor1
            // 
            this.backColor1.BackColor = System.Drawing.Color.White;
            this.backColor1.Location = new System.Drawing.Point(986, 467);
            this.backColor1.Name = "backColor1";
            this.backColor1.Size = new System.Drawing.Size(67, 54);
            this.backColor1.TabIndex = 11;
            this.backColor1.UseVisualStyleBackColor = false;
            this.backColor1.Click += new System.EventHandler(this.backColor1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(984, 319);
            this.trackBar1.Maximum = 36;
            this.trackBar1.Minimum = 8;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(418, 90);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 14;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(979, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 37);
            this.label7.TabIndex = 8;
            this.label7.Text = "Choose text size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(979, 538);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = "Choose text colour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(977, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(436, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "Choose background colour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(977, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Choose font";
            // 
            // fontList
            // 
            this.fontList.FormattingEnabled = true;
            this.fontList.ItemHeight = 25;
            this.fontList.Items.AddRange(new object[] {
            "Arial",
            "Arial Rounded MT",
            "Comic Sans MS",
            "Courier New",
            "Georgia",
            "Jokerman",
            "Lucida Handwriting",
            "Papyrus",
            "Snap ITC",
            "Times New Roman",
            "Verdana"});
            this.fontList.Location = new System.Drawing.Point(986, 53);
            this.fontList.Name = "fontList";
            this.fontList.Size = new System.Drawing.Size(418, 204);
            this.fontList.TabIndex = 3;
            this.fontList.SelectedIndexChanged += new System.EventHandler(this.fontList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(657, 87);
            this.label3.TabIndex = 1;
            this.label3.Text = "Write something!";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipTitle = "Help";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BackArrow.png");
            this.imageList1.Images.SetKeyName(1, "ForwardArrow.png");
            this.imageList1.Images.SetKeyName(2, "history.png");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1759, 912);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.webBrowser.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.calculator.ResumeLayout(false);
            this.calculator.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.textEditor.ResumeLayout(false);
            this.textEditor.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage webBrowser;
        private System.Windows.Forms.TabPage calculator;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage textEditor;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox fontList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage welcomePage;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button textColor6;
        private System.Windows.Forms.Button textColor5;
        private System.Windows.Forms.Button textColor4;
        private System.Windows.Forms.Button textColor3;
        private System.Windows.Forms.Button textColor2;
        private System.Windows.Forms.Button textColor1;
        private System.Windows.Forms.Button backColor6;
        private System.Windows.Forms.Button backColor5;
        private System.Windows.Forms.Button backColor4;
        private System.Windows.Forms.Button backColor3;
        private System.Windows.Forms.Button backColor2;
        private System.Windows.Forms.Button backColor1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.TextBox webAddressBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClearSums;
        private System.Windows.Forms.TextBox calcHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button calcBtn9;
        private System.Windows.Forms.Button calcBtnClear;
        private System.Windows.Forms.TextBox CalcDisplay;
        private System.Windows.Forms.Button calcBtn8;
        private System.Windows.Forms.Button calcBtnDivide;
        private System.Windows.Forms.Button calcBtnEquals;
        private System.Windows.Forms.Button calcBtn7;
        private System.Windows.Forms.Button calcBtnMultiply;
        private System.Windows.Forms.Button calcBtnMinus;
        private System.Windows.Forms.Button calcBtn6;
        private System.Windows.Forms.Button calcBtnPlus;
        private System.Windows.Forms.Button calcBtn0;
        private System.Windows.Forms.Button calcBtn1;
        private System.Windows.Forms.Button calcBtn5;
        private System.Windows.Forms.Button calcBtn4;
        private System.Windows.Forms.Button calcBtn3;
        private System.Windows.Forms.Button calcBtn2;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox ideaBox;
        private System.Windows.Forms.Button btnIdeaGenerator;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox browserHistory;
        private System.Windows.Forms.Button btnRandomStyle;
        private System.Windows.Forms.Button btnWritingPrompt;
    }
}