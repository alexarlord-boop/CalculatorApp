namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.stopBtn = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.additionButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.substractionButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outTextBox = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageLabel2 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.journalView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clearJournalBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.secondsSelector = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.resultsCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.requestsCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondsSelector)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1003, 710);
            this.splitContainer1.SplitterDistance = 644;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.stopBtn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.zeroButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.decimalButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.oneButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.additionButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.twoButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.threeButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.substractionButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.equalsButton, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.fourButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fiveButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.sixButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.multiplicationButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.sevenButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.eightButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nineButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.divisionButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.clearButton, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.inputTextBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.outTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.startBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.messageLabel, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.messageLabel2, 4, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.85715F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 706);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.SystemColors.Window;
            this.stopBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopBtn.Location = new System.Drawing.Point(131, 633);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(122, 70);
            this.stopBtn.TabIndex = 23;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // zeroButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.zeroButton, 2);
            this.zeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroButton.Location = new System.Drawing.Point(5, 509);
            this.zeroButton.Margin = new System.Windows.Forms.Padding(5);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(246, 116);
            this.zeroButton.TabIndex = 16;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decimalButton.Location = new System.Drawing.Point(261, 509);
            this.decimalButton.Margin = new System.Windows.Forms.Padding(5);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(118, 116);
            this.decimalButton.TabIndex = 18;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneButton.Location = new System.Drawing.Point(5, 383);
            this.oneButton.Margin = new System.Windows.Forms.Padding(5);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(118, 116);
            this.oneButton.TabIndex = 11;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // additionButton
            // 
            this.additionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.additionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionButton.Location = new System.Drawing.Point(389, 509);
            this.additionButton.Margin = new System.Windows.Forms.Padding(5);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(118, 116);
            this.additionButton.TabIndex = 19;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoButton.Location = new System.Drawing.Point(133, 383);
            this.twoButton.Margin = new System.Windows.Forms.Padding(5);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(118, 116);
            this.twoButton.TabIndex = 12;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threeButton.Location = new System.Drawing.Point(261, 383);
            this.threeButton.Margin = new System.Windows.Forms.Padding(5);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(118, 116);
            this.threeButton.TabIndex = 13;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // substractionButton
            // 
            this.substractionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.substractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.substractionButton.Location = new System.Drawing.Point(389, 383);
            this.substractionButton.Margin = new System.Windows.Forms.Padding(5);
            this.substractionButton.Name = "substractionButton";
            this.substractionButton.Size = new System.Drawing.Size(118, 116);
            this.substractionButton.TabIndex = 14;
            this.substractionButton.Text = "-";
            this.substractionButton.UseVisualStyleBackColor = true;
            this.substractionButton.Click += new System.EventHandler(this.SubstractionButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equalsButton.Location = new System.Drawing.Point(517, 131);
            this.equalsButton.Margin = new System.Windows.Forms.Padding(5);
            this.equalsButton.Name = "equalsButton";
            this.tableLayoutPanel1.SetRowSpan(this.equalsButton, 2);
            this.equalsButton.Size = new System.Drawing.Size(118, 242);
            this.equalsButton.TabIndex = 15;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourButton.Location = new System.Drawing.Point(5, 257);
            this.fourButton.Margin = new System.Windows.Forms.Padding(5);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(118, 116);
            this.fourButton.TabIndex = 6;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiveButton.Location = new System.Drawing.Point(133, 257);
            this.fiveButton.Margin = new System.Windows.Forms.Padding(5);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(118, 116);
            this.fiveButton.TabIndex = 7;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sixButton.Location = new System.Drawing.Point(261, 257);
            this.sixButton.Margin = new System.Windows.Forms.Padding(5);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(118, 116);
            this.sixButton.TabIndex = 8;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplicationButton.Location = new System.Drawing.Point(389, 257);
            this.multiplicationButton.Margin = new System.Windows.Forms.Padding(5);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(118, 116);
            this.multiplicationButton.TabIndex = 9;
            this.multiplicationButton.Text = "*";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sevenButton.Location = new System.Drawing.Point(5, 131);
            this.sevenButton.Margin = new System.Windows.Forms.Padding(5);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(118, 116);
            this.sevenButton.TabIndex = 1;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eightButton.Location = new System.Drawing.Point(133, 131);
            this.eightButton.Margin = new System.Windows.Forms.Padding(5);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(118, 116);
            this.eightButton.TabIndex = 2;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nineButton.Location = new System.Drawing.Point(261, 131);
            this.nineButton.Margin = new System.Windows.Forms.Padding(5);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(118, 116);
            this.nineButton.TabIndex = 3;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divisionButton.Location = new System.Drawing.Point(389, 131);
            this.divisionButton.Margin = new System.Windows.Forms.Padding(5);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(118, 116);
            this.divisionButton.TabIndex = 4;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(517, 383);
            this.clearButton.Margin = new System.Windows.Forms.Padding(5);
            this.clearButton.Name = "clearButton";
            this.tableLayoutPanel1.SetRowSpan(this.clearButton, 2);
            this.clearButton.Size = new System.Drawing.Size(118, 242);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.inputTextBox, 3);
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextBox.Location = new System.Drawing.Point(259, 36);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(378, 53);
            this.inputTextBox.TabIndex = 20;
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // outTextBox
            // 
            this.outTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.outTextBox, 2);
            this.outTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outTextBox.Location = new System.Drawing.Point(3, 36);
            this.outTextBox.Multiline = true;
            this.outTextBox.Name = "outTextBox";
            this.outTextBox.Size = new System.Drawing.Size(250, 53);
            this.outTextBox.TabIndex = 21;
            this.outTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.SystemColors.Window;
            this.startBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startBtn.Location = new System.Drawing.Point(3, 633);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(122, 70);
            this.startBtn.TabIndex = 22;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.SystemColors.Window;
            this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.messageLabel, 2);
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLabel.Location = new System.Drawing.Point(259, 630);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(250, 76);
            this.messageLabel.TabIndex = 24;
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // messageLabel2
            // 
            this.messageLabel2.AutoSize = true;
            this.messageLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.messageLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageLabel2.Location = new System.Drawing.Point(515, 630);
            this.messageLabel2.Name = "messageLabel2";
            this.messageLabel2.Size = new System.Drawing.Size(122, 76);
            this.messageLabel2.TabIndex = 25;
            this.messageLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(355, 710);
            this.splitContainer2.SplitterDistance = 303;
            this.splitContainer2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.journalView, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.clearJournalBtn, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.03986F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.63707F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.32307F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(351, 299);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // journalView
            // 
            this.journalView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.journalView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journalView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.journalView.HideSelection = false;
            this.journalView.Location = new System.Drawing.Point(3, 117);
            this.journalView.Name = "journalView";
            this.journalView.Size = new System.Drawing.Size(345, 179);
            this.journalView.TabIndex = 2;
            this.journalView.UseCompatibleStateImageBehavior = false;
            this.journalView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Counted:";
            this.columnHeader1.Width = 219;
            // 
            // clearJournalBtn
            // 
            this.clearJournalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearJournalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearJournalBtn.Location = new System.Drawing.Point(5, 64);
            this.clearJournalBtn.Margin = new System.Windows.Forms.Padding(5);
            this.clearJournalBtn.Name = "clearJournalBtn";
            this.clearJournalBtn.Size = new System.Drawing.Size(341, 45);
            this.clearJournalBtn.TabIndex = 4;
            this.clearJournalBtn.Text = "Clear";
            this.clearJournalBtn.UseVisualStyleBackColor = true;
            this.clearJournalBtn.Click += new System.EventHandler(this.ClearJournalBtn_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.secondsSelector, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(345, 53);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // secondsSelector
            // 
            this.secondsSelector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.secondsSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondsSelector.Location = new System.Drawing.Point(198, 7);
            this.secondsSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.secondsSelector.Name = "secondsSelector";
            this.secondsSelector.Size = new System.Drawing.Size(120, 39);
            this.secondsSelector.TabIndex = 1;
            this.secondsSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.secondsSelector.ValueChanged += new System.EventHandler(this.SecondsSelector_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Задержка:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.resultsCountLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.requestsCountLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(351, 399);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // resultsCountLabel
            // 
            this.resultsCountLabel.AutoSize = true;
            this.resultsCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultsCountLabel.Location = new System.Drawing.Point(180, 204);
            this.resultsCountLabel.Margin = new System.Windows.Forms.Padding(3);
            this.resultsCountLabel.Name = "resultsCountLabel";
            this.resultsCountLabel.Size = new System.Drawing.Size(165, 189);
            this.resultsCountLabel.TabIndex = 5;
            this.resultsCountLabel.Text = "0";
            this.resultsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(180, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Results";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // requestsCountLabel
            // 
            this.requestsCountLabel.AutoSize = true;
            this.requestsCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.requestsCountLabel.Location = new System.Drawing.Point(6, 204);
            this.requestsCountLabel.Margin = new System.Windows.Forms.Padding(3);
            this.requestsCountLabel.Name = "requestsCountLabel";
            this.requestsCountLabel.Size = new System.Drawing.Size(165, 189);
            this.requestsCountLabel.TabIndex = 4;
            this.requestsCountLabel.Text = "0";
            this.requestsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Requests";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 710);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondsSelector)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button substractionButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outTextBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultsCountLabel;
        private System.Windows.Forms.Label requestsCountLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown secondsSelector;
        private System.Windows.Forms.ListView journalView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label messageLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button clearJournalBtn;
        private System.Windows.Forms.Label label3;
    }
}

