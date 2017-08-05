namespace Assignment5
{
    partial class DemoBMICalculator
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
            this.Heightlabel = new System.Windows.Forms.Label();
            this.HeightLable = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.KilogramtextBox = new System.Windows.Forms.TextBox();
            this.PoundTextbox = new System.Windows.Forms.TextBox();
            this.MetrestextBox = new System.Windows.Forms.TextBox();
            this.KilogramradioButton = new System.Windows.Forms.RadioButton();
            this.PoundradioButton = new System.Windows.Forms.RadioButton();
            this.InchesradioButton = new System.Windows.Forms.RadioButton();
            this.InchestextBox = new System.Windows.Forms.TextBox();
            this.MetresradioButton = new System.Windows.Forms.RadioButton();
            this.MetricradioButton = new System.Windows.Forms.RadioButton();
            this.ImperialradioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ResulttextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Heightlabel
            // 
            this.Heightlabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Heightlabel, 2);
            this.Heightlabel.Location = new System.Drawing.Point(5, 49);
            this.Heightlabel.Margin = new System.Windows.Forms.Padding(5);
            this.Heightlabel.Name = "Heightlabel";
            this.Heightlabel.Size = new System.Drawing.Size(136, 31);
            this.Heightlabel.TabIndex = 6;
            this.Heightlabel.Text = "My Height";
            this.Heightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Heightlabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // HeightLable
            // 
            this.HeightLable.AutoSize = true;
            this.HeightLable.Location = new System.Drawing.Point(161, 176);
            this.HeightLable.Name = "HeightLable";
            this.HeightLable.Size = new System.Drawing.Size(0, 31);
            this.HeightLable.TabIndex = 3;
            this.HeightLable.Click += new System.EventHandler(this.label2_Click);
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(5, 181);
            this.Weight.Margin = new System.Windows.Forms.Padding(5, 5, 3, 0);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(141, 31);
            this.Weight.TabIndex = 8;
            this.Weight.Text = "My Weight";
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.BackColor = System.Drawing.SystemColors.GrayText;
            this.tableLayoutPanel1.SetColumnSpan(this.Calculatebutton, 2);
            this.Calculatebutton.Location = new System.Drawing.Point(3, 311);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(310, 42);
            this.Calculatebutton.TabIndex = 14;
            this.Calculatebutton.Text = "Calculate ";
            this.Calculatebutton.UseVisualStyleBackColor = false;
            // 
            // KilogramtextBox
            // 
            this.KilogramtextBox.BackColor = System.Drawing.Color.LightGray;
            this.KilogramtextBox.Location = new System.Drawing.Point(161, 267);
            this.KilogramtextBox.Name = "KilogramtextBox";
            this.KilogramtextBox.Size = new System.Drawing.Size(100, 38);
            this.KilogramtextBox.TabIndex = 13;
            // 
            // PoundTextbox
            // 
            this.PoundTextbox.BackColor = System.Drawing.Color.LightGray;
            this.PoundTextbox.Location = new System.Drawing.Point(3, 267);
            this.PoundTextbox.Name = "PoundTextbox";
            this.PoundTextbox.Size = new System.Drawing.Size(100, 38);
            this.PoundTextbox.TabIndex = 12;
            // 
            // MetrestextBox
            // 
            this.MetrestextBox.BackColor = System.Drawing.Color.LightGray;
            this.MetrestextBox.Location = new System.Drawing.Point(3, 135);
            this.MetrestextBox.Name = "MetrestextBox";
            this.MetrestextBox.Size = new System.Drawing.Size(100, 38);
            this.MetrestextBox.TabIndex = 11;
            // 
            // KilogramradioButton
            // 
            this.KilogramradioButton.AutoSize = true;
            this.KilogramradioButton.Location = new System.Drawing.Point(161, 223);
            this.KilogramradioButton.Name = "KilogramradioButton";
            this.KilogramradioButton.Size = new System.Drawing.Size(152, 35);
            this.KilogramradioButton.TabIndex = 10;
            this.KilogramradioButton.TabStop = true;
            this.KilogramradioButton.Text = "Kilograms";
            this.KilogramradioButton.UseVisualStyleBackColor = true;
            this.KilogramradioButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // PoundradioButton
            // 
            this.PoundradioButton.AutoSize = true;
            this.PoundradioButton.Location = new System.Drawing.Point(3, 223);
            this.PoundradioButton.Name = "PoundradioButton";
            this.PoundradioButton.Size = new System.Drawing.Size(124, 35);
            this.PoundradioButton.TabIndex = 9;
            this.PoundradioButton.TabStop = true;
            this.PoundradioButton.Text = "Pounds";
            this.PoundradioButton.UseVisualStyleBackColor = true;
            // 
            // InchesradioButton
            // 
            this.InchesradioButton.AutoSize = true;
            this.InchesradioButton.Location = new System.Drawing.Point(3, 91);
            this.InchesradioButton.Name = "InchesradioButton";
            this.InchesradioButton.Size = new System.Drawing.Size(113, 35);
            this.InchesradioButton.TabIndex = 4;
            this.InchesradioButton.TabStop = true;
            this.InchesradioButton.Text = "Inches";
            this.InchesradioButton.UseVisualStyleBackColor = true;
            // 
            // InchestextBox
            // 
            this.InchestextBox.BackColor = System.Drawing.Color.LightGray;
            this.InchestextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InchestextBox.Enabled = false;
            this.InchestextBox.Location = new System.Drawing.Point(161, 135);
            this.InchestextBox.Name = "InchestextBox";
            this.InchestextBox.ReadOnly = true;
            this.InchestextBox.Size = new System.Drawing.Size(100, 38);
            this.InchestextBox.TabIndex = 7;
            // 
            // MetresradioButton
            // 
            this.MetresradioButton.AutoSize = true;
            this.MetresradioButton.Location = new System.Drawing.Point(161, 91);
            this.MetresradioButton.Name = "MetresradioButton";
            this.MetresradioButton.Size = new System.Drawing.Size(115, 35);
            this.MetresradioButton.TabIndex = 5;
            this.MetresradioButton.TabStop = true;
            this.MetresradioButton.Text = "Metres";
            this.MetresradioButton.UseVisualStyleBackColor = true;
            // 
            // MetricradioButton
            // 
            this.MetricradioButton.AutoSize = true;
            this.MetricradioButton.Location = new System.Drawing.Point(161, 3);
            this.MetricradioButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.MetricradioButton.Name = "MetricradioButton";
            this.MetricradioButton.Size = new System.Drawing.Size(159, 35);
            this.MetricradioButton.TabIndex = 1;
            this.MetricradioButton.TabStop = true;
            this.MetricradioButton.Text = "Metric Units";
            this.MetricradioButton.UseVisualStyleBackColor = true;
            this.MetricradioButton.CheckedChanged += new System.EventHandler(this.MetricradioButton_CheckedChanged);
            // 
            // ImperialradioButton
            // 
            this.ImperialradioButton.AutoSize = true;
            this.ImperialradioButton.Location = new System.Drawing.Point(3, 3);
            this.ImperialradioButton.Name = "ImperialradioButton";
            this.ImperialradioButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialradioButton.TabIndex = 0;
            this.ImperialradioButton.TabStop = true;
            this.ImperialradioButton.Text = "Imperial";
            this.ImperialradioButton.UseVisualStyleBackColor = true;
            this.ImperialradioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.67949F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.32051F));
            this.tableLayoutPanel1.Controls.Add(this.ImperialradioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MetricradioButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.InchesradioButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PoundradioButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.KilogramradioButton, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.PoundTextbox, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.KilogramtextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Calculatebutton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.Weight, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.MetresradioButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.InchestextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.HeightLable, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.MetrestextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Heightlabel, 0, 1);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 356);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // ResulttextBox
            // 
            this.ResulttextBox.BackColor = System.Drawing.Color.White;
            this.ResulttextBox.Enabled = false;
            this.ResulttextBox.Location = new System.Drawing.Point(2, 388);
            this.ResulttextBox.Name = "ResulttextBox";
            this.ResulttextBox.Size = new System.Drawing.Size(309, 38);
            this.ResulttextBox.TabIndex = 1;
            // 
            // DemoBMICalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(314, 455);
            this.Controls.Add(this.ResulttextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DemoBMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heightlabel;
        private System.Windows.Forms.Label HeightLable;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.TextBox KilogramtextBox;
        private System.Windows.Forms.TextBox PoundTextbox;
        private System.Windows.Forms.TextBox MetrestextBox;
        private System.Windows.Forms.RadioButton KilogramradioButton;
        private System.Windows.Forms.RadioButton PoundradioButton;
        private System.Windows.Forms.RadioButton InchesradioButton;
        private System.Windows.Forms.TextBox InchestextBox;
        private System.Windows.Forms.RadioButton MetresradioButton;
        private System.Windows.Forms.RadioButton MetricradioButton;
        private System.Windows.Forms.RadioButton ImperialradioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox ResulttextBox;
    }
}

