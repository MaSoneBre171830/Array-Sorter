namespace Sorter
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
            btn_Generate = new Button();
            SortNumbers = new Button();
            comboBox1 = new ComboBox();
            lbl_SortTime = new Label();
            btnLoadFile = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            btn_Enter = new Button();
            label1 = new Label();
            btnStats = new Button();
            SuspendLayout();
            // 
            // btn_Generate
            // 
            btn_Generate.Anchor = AnchorStyles.None;
            btn_Generate.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Generate.Location = new Point(598, 24);
            btn_Generate.Margin = new Padding(4, 3, 4, 3);
            btn_Generate.Name = "btn_Generate";
            btn_Generate.Size = new Size(231, 38);
            btn_Generate.TabIndex = 1;
            btn_Generate.Text = "Generate numbers";
            btn_Generate.TextAlign = ContentAlignment.TopCenter;
            btn_Generate.UseVisualStyleBackColor = true;
            btn_Generate.Click += button1_Click;
            // 
            // SortNumbers
            // 
            SortNumbers.Anchor = AnchorStyles.None;
            SortNumbers.Font = new Font("Stencil", 28F);
            SortNumbers.Location = new Point(598, 193);
            SortNumbers.Name = "SortNumbers";
            SortNumbers.Size = new Size(231, 94);
            SortNumbers.TabIndex = 3;
            SortNumbers.Text = "Sort";
            SortNumbers.UseVisualStyleBackColor = true;
            SortNumbers.Click += SortNumbers_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bubble sort", "Insertion sort", "Selection sort", "Quick sort", "Array.Sort" });
            comboBox1.Location = new Point(436, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(155, 23);
            comboBox1.TabIndex = 4;
            // 
            // lbl_SortTime
            // 
            lbl_SortTime.AutoSize = true;
            lbl_SortTime.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_SortTime.Location = new Point(91, 68);
            lbl_SortTime.Name = "lbl_SortTime";
            lbl_SortTime.Size = new Size(0, 15);
            lbl_SortTime.TabIndex = 5;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Anchor = AnchorStyles.None;
            btnLoadFile.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadFile.Location = new Point(598, 68);
            btnLoadFile.Margin = new Padding(4, 3, 4, 3);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(231, 38);
            btnLoadFile.TabIndex = 6;
            btnLoadFile.Text = "Load file";
            btnLoadFile.TextAlign = ContentAlignment.TopCenter;
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 131);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(452, 280);
            label2.TabIndex = 7;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 68);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 8;
            label3.Text = "Sort time: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 15);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 9;
            label4.Text = "Unsorted numbers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 105);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 10;
            label5.Text = "Sorted numbers";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(30, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 23);
            textBox1.TabIndex = 11;
            // 
            // btn_Enter
            // 
            btn_Enter.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Enter.Location = new Point(347, 41);
            btn_Enter.Name = "btn_Enter";
            btn_Enter.Size = new Size(75, 23);
            btn_Enter.TabIndex = 12;
            btn_Enter.Text = "ENTER";
            btn_Enter.UseVisualStyleBackColor = true;
            btn_Enter.Click += btn_Enter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 68);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 13;
            // 
            // btnStats
            // 
            btnStats.Anchor = AnchorStyles.None;
            btnStats.Font = new Font("Stencil", 10F);
            btnStats.Location = new Point(633, 357);
            btnStats.Margin = new Padding(4, 3, 4, 3);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(163, 25);
            btnStats.TabIndex = 14;
            btnStats.Text = "Statistics";
            btnStats.TextAlign = ContentAlignment.TopCenter;
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 434);
            Controls.Add(btnStats);
            Controls.Add(label1);
            Controls.Add(btn_Enter);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLoadFile);
            Controls.Add(lbl_SortTime);
            Controls.Add(comboBox1);
            Controls.Add(SortNumbers);
            Controls.Add(btn_Generate);
            Font = new Font("Wingdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Generate;
        private Button SortNumbers;
        private ComboBox comboBox1;
        private Label lbl_SortTime;
        private Button btnLoadFile;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Button btn_Enter;
        private Label label1;
        private Button btnStats;
    }
}
