namespace View
{
    partial class AddEditeShapeForm
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
            Type_ComboBox = new ComboBox();
            label3 = new Label();
            Cancel_Button = new Button();
            Confirm_Button = new Button();
            ShapeControlPanel = new Panel();
            SuspendLayout();
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
            // ShapeControlPanel
            // 
            ShapeControlPanel.Location = new Point(30, 44);
            ShapeControlPanel.Name = "ShapeControlPanel";
            ShapeControlPanel.Size = new Size(166, 97);
            ShapeControlPanel.TabIndex = 11;
            // 
            // AddEditeShapeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 182);
            Controls.Add(ShapeControlPanel);
            Controls.Add(Confirm_Button);
            Controls.Add(Cancel_Button);
            Controls.Add(label3);
            Controls.Add(Type_ComboBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddEditeShapeForm";
            Text = "AddShapeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox Type_ComboBox;
        private Label label3;
        private Button Cancel_Button;
        private Button Confirm_Button;
        private Panel ShapeControlPanel;
    }
}