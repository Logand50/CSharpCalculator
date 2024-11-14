namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            ZeroButton = new Button();
            DecimalButton = new Button();
            EqualsButton = new Button();
            TwoButton = new Button();
            OneButton = new Button();
            AddButton = new Button();
            ThreeButton = new Button();
            SubtractButton = new Button();
            SixButton = new Button();
            FiveButton = new Button();
            FourButton = new Button();
            MultiplyButton = new Button();
            NineButton = new Button();
            EightButton = new Button();
            SevenButton = new Button();
            DivisionButton = new Button();
            PercentButton = new Button();
            NegativeButton = new Button();
            ClearButton = new Button();
            OutputLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(ZeroButton, 0, 5);
            tableLayoutPanel1.Controls.Add(DecimalButton, 0, 5);
            tableLayoutPanel1.Controls.Add(EqualsButton, 0, 5);
            tableLayoutPanel1.Controls.Add(TwoButton, 0, 4);
            tableLayoutPanel1.Controls.Add(OneButton, 0, 4);
            tableLayoutPanel1.Controls.Add(AddButton, 3, 4);
            tableLayoutPanel1.Controls.Add(ThreeButton, 2, 4);
            tableLayoutPanel1.Controls.Add(SubtractButton, 3, 3);
            tableLayoutPanel1.Controls.Add(SixButton, 2, 3);
            tableLayoutPanel1.Controls.Add(FiveButton, 1, 3);
            tableLayoutPanel1.Controls.Add(FourButton, 0, 3);
            tableLayoutPanel1.Controls.Add(MultiplyButton, 3, 2);
            tableLayoutPanel1.Controls.Add(NineButton, 2, 2);
            tableLayoutPanel1.Controls.Add(EightButton, 1, 2);
            tableLayoutPanel1.Controls.Add(SevenButton, 0, 2);
            tableLayoutPanel1.Controls.Add(DivisionButton, 3, 1);
            tableLayoutPanel1.Controls.Add(PercentButton, 2, 1);
            tableLayoutPanel1.Controls.Add(NegativeButton, 1, 1);
            tableLayoutPanel1.Controls.Add(ClearButton, 0, 1);
            tableLayoutPanel1.Controls.Add(OutputLabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.5398369F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8920336F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8920336F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8920336F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8920336F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8920336F));
            tableLayoutPanel1.Size = new Size(384, 461);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ZeroButton
            // 
            ZeroButton.AutoSize = true;
            ZeroButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ZeroButton.BackColor = Color.FromArgb(51, 51, 51);
            tableLayoutPanel1.SetColumnSpan(ZeroButton, 2);
            ZeroButton.Dock = DockStyle.Fill;
            ZeroButton.FlatStyle = FlatStyle.Popup;
            ZeroButton.Font = new Font("Stencil", 27.75F);
            ZeroButton.ForeColor = Color.White;
            ZeroButton.Location = new Point(3, 392);
            ZeroButton.MinimumSize = new Size(89, 62);
            ZeroButton.Name = "ZeroButton";
            ZeroButton.Size = new Size(186, 66);
            ZeroButton.TabIndex = 20;
            ZeroButton.Text = "0";
            ZeroButton.UseVisualStyleBackColor = false;
            ZeroButton.Click += NumberButtonClick;
            // 
            // DecimalButton
            // 
            DecimalButton.AutoSize = true;
            DecimalButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DecimalButton.BackColor = Color.FromArgb(51, 51, 51);
            DecimalButton.Dock = DockStyle.Fill;
            DecimalButton.FlatStyle = FlatStyle.Popup;
            DecimalButton.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold);
            DecimalButton.ForeColor = Color.White;
            DecimalButton.Location = new Point(195, 392);
            DecimalButton.MinimumSize = new Size(89, 62);
            DecimalButton.Name = "DecimalButton";
            DecimalButton.Size = new Size(90, 66);
            DecimalButton.TabIndex = 19;
            DecimalButton.Text = ".";
            DecimalButton.UseVisualStyleBackColor = false;
            DecimalButton.Click += NumberButtonClick;
            // 
            // EqualsButton
            // 
            EqualsButton.AutoSize = true;
            EqualsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EqualsButton.BackColor = Color.FromArgb(229, 155, 51);
            EqualsButton.Dock = DockStyle.Fill;
            EqualsButton.FlatStyle = FlatStyle.Popup;
            EqualsButton.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold);
            EqualsButton.ForeColor = Color.White;
            EqualsButton.Location = new Point(291, 392);
            EqualsButton.MinimumSize = new Size(89, 62);
            EqualsButton.Name = "EqualsButton";
            EqualsButton.Size = new Size(90, 66);
            EqualsButton.TabIndex = 18;
            EqualsButton.Text = "=";
            EqualsButton.UseVisualStyleBackColor = false;
            EqualsButton.Click += CalculateEquasion;
            // 
            // TwoButton
            // 
            TwoButton.AutoSize = true;
            TwoButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TwoButton.BackColor = Color.FromArgb(51, 51, 51);
            TwoButton.Dock = DockStyle.Fill;
            TwoButton.FlatStyle = FlatStyle.Popup;
            TwoButton.Font = new Font("Stencil", 27.75F);
            TwoButton.ForeColor = Color.White;
            TwoButton.Location = new Point(99, 324);
            TwoButton.MinimumSize = new Size(89, 62);
            TwoButton.Name = "TwoButton";
            TwoButton.Size = new Size(90, 62);
            TwoButton.TabIndex = 17;
            TwoButton.Text = "2";
            TwoButton.UseVisualStyleBackColor = false;
            TwoButton.Click += NumberButtonClick;
            // 
            // OneButton
            // 
            OneButton.AutoSize = true;
            OneButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            OneButton.BackColor = Color.FromArgb(51, 51, 51);
            OneButton.Dock = DockStyle.Fill;
            OneButton.FlatStyle = FlatStyle.Popup;
            OneButton.Font = new Font("Stencil", 27.75F);
            OneButton.ForeColor = Color.White;
            OneButton.Location = new Point(3, 324);
            OneButton.MinimumSize = new Size(89, 62);
            OneButton.Name = "OneButton";
            OneButton.Size = new Size(90, 62);
            OneButton.TabIndex = 16;
            OneButton.Text = "1";
            OneButton.UseVisualStyleBackColor = false;
            OneButton.Click += NumberButtonClick;
            // 
            // AddButton
            // 
            AddButton.AutoSize = true;
            AddButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddButton.BackColor = Color.FromArgb(229, 155, 51);
            AddButton.Dock = DockStyle.Fill;
            AddButton.FlatStyle = FlatStyle.Popup;
            AddButton.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(291, 324);
            AddButton.MinimumSize = new Size(89, 62);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(90, 62);
            AddButton.TabIndex = 15;
            AddButton.Text = "+";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += SymbolButtonClick;
            // 
            // ThreeButton
            // 
            ThreeButton.AutoSize = true;
            ThreeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ThreeButton.BackColor = Color.FromArgb(51, 51, 51);
            ThreeButton.Dock = DockStyle.Fill;
            ThreeButton.FlatStyle = FlatStyle.Popup;
            ThreeButton.Font = new Font("Stencil", 27.75F);
            ThreeButton.ForeColor = Color.White;
            ThreeButton.Location = new Point(195, 324);
            ThreeButton.MinimumSize = new Size(89, 62);
            ThreeButton.Name = "ThreeButton";
            ThreeButton.Size = new Size(90, 62);
            ThreeButton.TabIndex = 14;
            ThreeButton.Text = "3";
            ThreeButton.UseVisualStyleBackColor = false;
            ThreeButton.Click += NumberButtonClick;
            // 
            // SubtractButton
            // 
            SubtractButton.AutoSize = true;
            SubtractButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SubtractButton.BackColor = Color.FromArgb(229, 155, 51);
            SubtractButton.Dock = DockStyle.Fill;
            SubtractButton.FlatStyle = FlatStyle.Popup;
            SubtractButton.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold);
            SubtractButton.ForeColor = Color.White;
            SubtractButton.Location = new Point(291, 256);
            SubtractButton.MinimumSize = new Size(89, 62);
            SubtractButton.Name = "SubtractButton";
            SubtractButton.Size = new Size(90, 62);
            SubtractButton.TabIndex = 11;
            SubtractButton.Text = "—";
            SubtractButton.UseVisualStyleBackColor = false;
            SubtractButton.Click += SymbolButtonClick;
            // 
            // SixButton
            // 
            SixButton.AutoSize = true;
            SixButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SixButton.BackColor = Color.FromArgb(51, 51, 51);
            SixButton.Dock = DockStyle.Fill;
            SixButton.FlatStyle = FlatStyle.Popup;
            SixButton.Font = new Font("Stencil", 27.75F);
            SixButton.ForeColor = Color.White;
            SixButton.Location = new Point(195, 256);
            SixButton.MinimumSize = new Size(89, 62);
            SixButton.Name = "SixButton";
            SixButton.Size = new Size(90, 62);
            SixButton.TabIndex = 10;
            SixButton.Text = "6";
            SixButton.UseVisualStyleBackColor = false;
            SixButton.Click += NumberButtonClick;
            // 
            // FiveButton
            // 
            FiveButton.AutoSize = true;
            FiveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FiveButton.BackColor = Color.FromArgb(51, 51, 51);
            FiveButton.Dock = DockStyle.Fill;
            FiveButton.FlatStyle = FlatStyle.Popup;
            FiveButton.Font = new Font("Stencil", 27.75F);
            FiveButton.ForeColor = Color.White;
            FiveButton.Location = new Point(99, 256);
            FiveButton.MinimumSize = new Size(89, 62);
            FiveButton.Name = "FiveButton";
            FiveButton.Size = new Size(90, 62);
            FiveButton.TabIndex = 9;
            FiveButton.Text = "5";
            FiveButton.UseVisualStyleBackColor = false;
            FiveButton.Click += NumberButtonClick;
            // 
            // FourButton
            // 
            FourButton.AutoSize = true;
            FourButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FourButton.BackColor = Color.FromArgb(51, 51, 51);
            FourButton.Dock = DockStyle.Fill;
            FourButton.FlatStyle = FlatStyle.Popup;
            FourButton.Font = new Font("Stencil", 27.75F);
            FourButton.ForeColor = Color.White;
            FourButton.Location = new Point(3, 256);
            FourButton.MinimumSize = new Size(89, 62);
            FourButton.Name = "FourButton";
            FourButton.Size = new Size(90, 62);
            FourButton.TabIndex = 8;
            FourButton.Text = "4";
            FourButton.UseVisualStyleBackColor = false;
            FourButton.Click += NumberButtonClick;
            // 
            // MultiplyButton
            // 
            MultiplyButton.AutoSize = true;
            MultiplyButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MultiplyButton.BackColor = Color.FromArgb(229, 155, 51);
            MultiplyButton.Dock = DockStyle.Fill;
            MultiplyButton.FlatStyle = FlatStyle.Popup;
            MultiplyButton.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold);
            MultiplyButton.ForeColor = Color.White;
            MultiplyButton.Location = new Point(291, 188);
            MultiplyButton.MinimumSize = new Size(89, 62);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(90, 62);
            MultiplyButton.TabIndex = 7;
            MultiplyButton.Text = "X";
            MultiplyButton.UseVisualStyleBackColor = false;
            MultiplyButton.Click += SymbolButtonClick;
            // 
            // NineButton
            // 
            NineButton.AutoSize = true;
            NineButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NineButton.BackColor = Color.FromArgb(51, 51, 51);
            NineButton.Dock = DockStyle.Fill;
            NineButton.FlatStyle = FlatStyle.Popup;
            NineButton.Font = new Font("Stencil", 27.75F);
            NineButton.ForeColor = Color.White;
            NineButton.Location = new Point(195, 188);
            NineButton.MinimumSize = new Size(89, 62);
            NineButton.Name = "NineButton";
            NineButton.Size = new Size(90, 62);
            NineButton.TabIndex = 6;
            NineButton.Text = "9";
            NineButton.UseVisualStyleBackColor = false;
            NineButton.Click += NumberButtonClick;
            // 
            // EightButton
            // 
            EightButton.AutoSize = true;
            EightButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EightButton.BackColor = Color.FromArgb(51, 51, 51);
            EightButton.Dock = DockStyle.Fill;
            EightButton.FlatStyle = FlatStyle.Popup;
            EightButton.Font = new Font("Stencil", 27.75F);
            EightButton.ForeColor = Color.White;
            EightButton.Location = new Point(99, 188);
            EightButton.MinimumSize = new Size(89, 62);
            EightButton.Name = "EightButton";
            EightButton.Size = new Size(90, 62);
            EightButton.TabIndex = 5;
            EightButton.Text = "8";
            EightButton.UseVisualStyleBackColor = false;
            EightButton.Click += NumberButtonClick;
            // 
            // SevenButton
            // 
            SevenButton.AutoSize = true;
            SevenButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SevenButton.BackColor = Color.FromArgb(51, 51, 51);
            SevenButton.Dock = DockStyle.Fill;
            SevenButton.FlatStyle = FlatStyle.Popup;
            SevenButton.Font = new Font("Stencil", 27.75F);
            SevenButton.ForeColor = Color.White;
            SevenButton.Location = new Point(3, 188);
            SevenButton.MinimumSize = new Size(89, 62);
            SevenButton.Name = "SevenButton";
            SevenButton.Size = new Size(90, 62);
            SevenButton.TabIndex = 4;
            SevenButton.Text = "7";
            SevenButton.UseVisualStyleBackColor = false;
            SevenButton.Click += NumberButtonClick;
            // 
            // DivisionButton
            // 
            DivisionButton.AutoSize = true;
            DivisionButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DivisionButton.BackColor = Color.FromArgb(229, 155, 51);
            DivisionButton.Dock = DockStyle.Fill;
            DivisionButton.FlatStyle = FlatStyle.Popup;
            DivisionButton.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold);
            DivisionButton.ForeColor = Color.White;
            DivisionButton.Location = new Point(291, 120);
            DivisionButton.MinimumSize = new Size(89, 62);
            DivisionButton.Name = "DivisionButton";
            DivisionButton.Size = new Size(90, 62);
            DivisionButton.TabIndex = 3;
            DivisionButton.Text = "÷";
            DivisionButton.UseVisualStyleBackColor = false;
            DivisionButton.Click += SymbolButtonClick;
            // 
            // PercentButton
            // 
            PercentButton.AutoSize = true;
            PercentButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PercentButton.BackColor = Color.FromArgb(165, 165, 165);
            PercentButton.Dock = DockStyle.Fill;
            PercentButton.FlatStyle = FlatStyle.Popup;
            PercentButton.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold);
            PercentButton.Location = new Point(195, 120);
            PercentButton.MinimumSize = new Size(89, 62);
            PercentButton.Name = "PercentButton";
            PercentButton.Size = new Size(90, 62);
            PercentButton.TabIndex = 2;
            PercentButton.Text = "%";
            PercentButton.UseVisualStyleBackColor = false;
            PercentButton.Click += SymbolButtonClick;
            // 
            // NegativeButton
            // 
            NegativeButton.AutoSize = true;
            NegativeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NegativeButton.BackColor = Color.FromArgb(165, 165, 165);
            NegativeButton.Dock = DockStyle.Fill;
            NegativeButton.FlatStyle = FlatStyle.Popup;
            NegativeButton.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold);
            NegativeButton.Location = new Point(99, 120);
            NegativeButton.MinimumSize = new Size(89, 62);
            NegativeButton.Name = "NegativeButton";
            NegativeButton.Size = new Size(90, 62);
            NegativeButton.TabIndex = 1;
            NegativeButton.Text = "±";
            NegativeButton.UseVisualStyleBackColor = false;
            NegativeButton.Click += SymbolButtonClick;
            // 
            // ClearButton
            // 
            ClearButton.AutoSize = true;
            ClearButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClearButton.BackColor = Color.FromArgb(165, 165, 165);
            ClearButton.Dock = DockStyle.Fill;
            ClearButton.FlatStyle = FlatStyle.Popup;
            ClearButton.Font = new Font("Stencil", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClearButton.Location = new Point(3, 120);
            ClearButton.MinimumSize = new Size(89, 62);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(90, 62);
            ClearButton.TabIndex = 0;
            ClearButton.Text = "C";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // OutputLabel
            // 
            OutputLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OutputLabel.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(OutputLabel, 4);
            OutputLabel.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OutputLabel.ForeColor = Color.White;
            OutputLabel.Location = new Point(3, 0);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(378, 117);
            OutputLabel.TabIndex = 21;
            OutputLabel.Text = "0";
            OutputLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(384, 0);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(384, 461);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(400, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button AddButton;
        private Button ThreeButton;
        private Button SubtractButton;
        private Button SixButton;
        private Button FiveButton;
        private Button FourButton;
        private Button MultiplyButton;
        private Button NineButton;
        private Button EightButton;
        private Button SevenButton;
        private Button DivisionButton;
        private Button PercentButton;
        private Button NegativeButton;
        private Button ClearButton;
        private Button ZeroButton;
        private Button DecimalButton;
        private Button EqualsButton;
        private Button TwoButton;
        private Button OneButton;
        private Label OutputLabel;
    }
}
