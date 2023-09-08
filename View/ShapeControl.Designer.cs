namespace View
{
    partial class ShapeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Size2_Numeric = new NumericUpDown();
            Size1_Numeric = new NumericUpDown();
            Size2_Label = new Label();
            Size1_Label = new Label();
            CreateRandomData = new Button();
            ((System.ComponentModel.ISupportInitialize)Size2_Numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Size1_Numeric).BeginInit();
            SuspendLayout();
            // 
            // Size2_Numeric
            // 
            Size2_Numeric.DecimalPlaces = 2;
            Size2_Numeric.Location = new Point(77, 46);
            Size2_Numeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            Size2_Numeric.Name = "Size2_Numeric";
            Size2_Numeric.Size = new Size(60, 23);
            Size2_Numeric.TabIndex = 13;
            // 
            // Size1_Numeric
            // 
            Size1_Numeric.DecimalPlaces = 2;
            Size1_Numeric.Location = new Point(77, 13);
            Size1_Numeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            Size1_Numeric.Name = "Size1_Numeric";
            Size1_Numeric.Size = new Size(60, 23);
            Size1_Numeric.TabIndex = 12;
            // 
            // Size2_Label
            // 
            Size2_Label.AutoSize = true;
            Size2_Label.Location = new Point(17, 48);
            Size2_Label.Name = "Size2_Label";
            Size2_Label.Size = new Size(38, 15);
            Size2_Label.TabIndex = 11;
            Size2_Label.Text = "label2";
            // 
            // Size1_Label
            // 
            Size1_Label.AutoSize = true;
            Size1_Label.Location = new Point(17, 15);
            Size1_Label.Name = "Size1_Label";
            Size1_Label.Size = new Size(38, 15);
            Size1_Label.TabIndex = 10;
            Size1_Label.Text = "label1";
            // 
            // CreateRandomData
            // 
            CreateRandomData.Location = new Point(16, 75);
            CreateRandomData.Name = "CreateRandomData";
            CreateRandomData.Size = new Size(121, 23);
            CreateRandomData.TabIndex = 14;
            CreateRandomData.Text = "CreateRandomData";
            CreateRandomData.UseVisualStyleBackColor = true;
            CreateRandomData.Click += CreateRandomData_Click;
            // 
            // ShapeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CreateRandomData);
            Controls.Add(Size2_Numeric);
            Controls.Add(Size1_Numeric);
            Controls.Add(Size2_Label);
            Controls.Add(Size1_Label);
            Name = "ShapeControl";
            Size = new Size(150, 108);
            ((System.ComponentModel.ISupportInitialize)Size2_Numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)Size1_Numeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown Size2_Numeric;
        private NumericUpDown Size1_Numeric;
        private Label Size2_Label;
        private Label Size1_Label;
        private Button CreateRandomData;
    }
}
