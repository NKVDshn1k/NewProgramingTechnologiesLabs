namespace View
{
    partial class AddShapeForm
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
            Size1_Label = new Label();
            Size2_Label = new Label();
            Type_ComboBox = new ComboBox();
            label3 = new Label();
            Cancel_Button = new Button();
            Confirm_Button = new Button();
            Size1_Numeric = new NumericUpDown();
            Size2_Numeric = new NumericUpDown();
            CreateRandomData = new Button();
            ((System.ComponentModel.ISupportInitialize)Size1_Numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Size2_Numeric).BeginInit();
            SuspendLayout();
            // 
            // Size1_Label
            // 
            Size1_Label.AutoSize = true;
            Size1_Label.Location = new Point(51, 55);
            Size1_Label.Name = "Size1_Label";
            Size1_Label.Size = new Size(38, 15);
            Size1_Label.TabIndex = 0;
            Size1_Label.Text = "label1";
            // 
            // Size2_Label
            // 
            Size2_Label.AutoSize = true;
            Size2_Label.Location = new Point(51, 88);
            Size2_Label.Name = "Size2_Label";
            Size2_Label.Size = new Size(38, 15);
            Size2_Label.TabIndex = 1;
            Size2_Label.Text = "label2";
            // 
            // Type_ComboBox
            // 
            Type_ComboBox.FormattingEnabled = true;
            Type_ComboBox.Location = new Point(62, 15);
            Type_ComboBox.Name = "Type_ComboBox";
            Type_ComboBox.Size = new Size(134, 23);
            Type_ComboBox.TabIndex = 4;
            Type_ComboBox.SelectedIndexChanged += Type_ComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 15);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "Type: ";
            // 
            // Cancel_Button
            // 
            Cancel_Button.Location = new Point(19, 147);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new Size(75, 23);
            Cancel_Button.TabIndex = 6;
            Cancel_Button.Text = "Cancel";
            Cancel_Button.UseVisualStyleBackColor = true;
            Cancel_Button.Click += Cancel_Button_Click;
            // 
            // Confirm_Button
            // 
            Confirm_Button.Location = new Point(121, 147);
            Confirm_Button.Name = "Confirm_Button";
            Confirm_Button.Size = new Size(75, 23);
            Confirm_Button.TabIndex = 7;
            Confirm_Button.Text = "Confirm";
            Confirm_Button.UseVisualStyleBackColor = true;
            Confirm_Button.Click += Confirm_Button_Click;
            // 
            // Size1_Numeric
            // 
            Size1_Numeric.Location = new Point(111, 53);
            Size1_Numeric.Name = "Size1_Numeric";
            Size1_Numeric.Size = new Size(60, 23);
            Size1_Numeric.TabIndex = 8;
            // 
            // Size2_Numeric
            // 
            Size2_Numeric.Location = new Point(111, 86);
            Size2_Numeric.Name = "Size2_Numeric";
            Size2_Numeric.Size = new Size(60, 23);
            Size2_Numeric.TabIndex = 9;
            // 
            // CreateRandomData
            // 
            CreateRandomData.Location = new Point(50, 116);
            CreateRandomData.Name = "CreateRandomData";
            CreateRandomData.Size = new Size(121, 23);
            CreateRandomData.TabIndex = 10;
            CreateRandomData.Text = "CreateRandomData";
            CreateRandomData.UseVisualStyleBackColor = true;
            CreateRandomData.Click += CreateRandomData_Click;
            // 
            // AddShapeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 182);
            Controls.Add(CreateRandomData);
            Controls.Add(Size2_Numeric);
            Controls.Add(Size1_Numeric);
            Controls.Add(Confirm_Button);
            Controls.Add(Cancel_Button);
            Controls.Add(label3);
            Controls.Add(Type_ComboBox);
            Controls.Add(Size2_Label);
            Controls.Add(Size1_Label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddShapeForm";
            Text = "AddShapeForm";
            ((System.ComponentModel.ISupportInitialize)Size1_Numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)Size2_Numeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Size1_Label;
        private Label Size2_Label;
        private ComboBox Type_ComboBox;
        private Label label3;
        private Button Cancel_Button;
        private Button Confirm_Button;
        private NumericUpDown Size1_Numeric;
        private NumericUpDown Size2_Numeric;
        private Button CreateRandomData;
    }
}