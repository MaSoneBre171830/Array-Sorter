namespace Sorter
{
    partial class Form2
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            btn_Stats = new Button();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(103, 50);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(553, 359);
            formsPlot1.TabIndex = 0;
            // 
            // btn_Stats
            // 
            btn_Stats.Location = new Point(22, 63);
            btn_Stats.Name = "btn_Stats";
            btn_Stats.Size = new Size(75, 23);
            btn_Stats.TabIndex = 1;
            btn_Stats.Text = "Fill up";
            btn_Stats.UseVisualStyleBackColor = true;
            btn_Stats.Click += btn_Stats_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Stats);
            Controls.Add(formsPlot1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Button btn_Stats;
    }
}