namespace View
{
    partial class SearchForm
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
            Shapes_DataGridView = new DataGridView();
            Type = new DataGridViewTextBoxColumn();
            Square = new DataGridViewTextBoxColumn();
            Type_ComboBox = new ComboBox();
            Square_Numeric = new NumericUpDown();
            this.Search_Button = new Button();
            Type_CheckBox = new CheckBox();
            Square_CheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)Shapes_DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Square_Numeric).BeginInit();
            SuspendLayout();
            // 
            // Shapes_DataGridView
            // 
            Shapes_DataGridView.AllowUserToAddRows = false;
            Shapes_DataGridView.AllowUserToDeleteRows = false;
            Shapes_DataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Shapes_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Shapes_DataGridView.Columns.AddRange(new DataGridViewColumn[] { Type, Square });
            Shapes_DataGridView.Location = new Point(12, 56);
            Shapes_DataGridView.MultiSelect = false;
            Shapes_DataGridView.Name = "Shapes_DataGridView";
            Shapes_DataGridView.ReadOnly = true;
            Shapes_DataGridView.RowTemplate.Height = 25;
            Shapes_DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Shapes_DataGridView.Size = new Size(304, 373);
            Shapes_DataGridView.TabIndex = 1;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // Square
            // 
            Square.HeaderText = "Square";
            Square.Name = "Square";
            Square.ReadOnly = true;
            // 
            // Type_ComboBox
            // 
            Type_ComboBox.FormattingEnabled = true;
            Type_ComboBox.Location = new Point(66, 26);
            Type_ComboBox.Name = "Type_ComboBox";
            Type_ComboBox.Size = new Size(84, 23);
            Type_ComboBox.TabIndex = 3;
            // 
            // Square_Numeric
            // 
            Square_Numeric.Location = new Point(156, 27);
            Square_Numeric.Name = "Square_Numeric";
            Square_Numeric.Size = new Size(95, 23);
            Square_Numeric.TabIndex = 4;
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new Point(257, 26);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new Size(59, 24);
            this.Search_Button.TabIndex = 7;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += this.Search_Button_Click;
            // 
            // Type_CheckBox
            // 
            Type_CheckBox.AutoSize = true;
            Type_CheckBox.Location = new Point(66, 5);
            Type_CheckBox.Name = "Type_CheckBox";
            Type_CheckBox.Size = new Size(50, 19);
            Type_CheckBox.TabIndex = 8;
            Type_CheckBox.Text = "Type";
            Type_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Square_CheckBox
            // 
            Square_CheckBox.AutoSize = true;
            Square_CheckBox.Location = new Point(157, 5);
            Square_CheckBox.Name = "Square_CheckBox";
            Square_CheckBox.Size = new Size(62, 19);
            Square_CheckBox.TabIndex = 9;
            Square_CheckBox.Text = "Square";
            Square_CheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 441);
            Controls.Add(Square_CheckBox);
            Controls.Add(Type_CheckBox);
            Controls.Add(this.Search_Button);
            Controls.Add(Square_Numeric);
            Controls.Add(Type_ComboBox);
            Controls.Add(Shapes_DataGridView);
            Name = "SearchForm";
            Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)Shapes_DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)Square_Numeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Shapes_DataGridView;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Square;
        private ComboBox Type_ComboBox;
        private NumericUpDown Square_Numeric;
        private Button Search_Button;
        private CheckBox Type_CheckBox;
        private CheckBox Square_CheckBox;
    }
}