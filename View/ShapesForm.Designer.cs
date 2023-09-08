namespace View
{
    partial class ShapesForm
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
            groupBox1 = new GroupBox();
            ShapeControlPanel = new Panel();
            Search_Button = new Button();
            RemoveShape_Button = new Button();
            AddShape_Button = new Button();
            Shapes_DataGridView = new DataGridView();
            Type = new DataGridViewTextBoxColumn();
            Square = new DataGridViewTextBoxColumn();
            EditeShapeButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Shapes_DataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(EditeShapeButton);
            groupBox1.Controls.Add(ShapeControlPanel);
            groupBox1.Controls.Add(Search_Button);
            groupBox1.Controls.Add(RemoveShape_Button);
            groupBox1.Controls.Add(AddShape_Button);
            groupBox1.Controls.Add(Shapes_DataGridView);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 371);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Geometric shapes";
            // 
            // ShapeControlPanel
            // 
            ShapeControlPanel.Location = new Point(12, 22);
            ShapeControlPanel.Name = "ShapeControlPanel";
            ShapeControlPanel.Size = new Size(158, 87);
            ShapeControlPanel.TabIndex = 4;
            // 
            // Search_Button
            // 
            Search_Button.Anchor = AnchorStyles.Bottom;
            Search_Button.Location = new Point(285, 22);
            Search_Button.Name = "Search_Button";
            Search_Button.Size = new Size(77, 23);
            Search_Button.TabIndex = 3;
            Search_Button.Text = "Search";
            Search_Button.UseVisualStyleBackColor = true;
            Search_Button.Click += Search_Button_Click;
            // 
            // RemoveShape_Button
            // 
            RemoveShape_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveShape_Button.Location = new Point(260, 336);
            RemoveShape_Button.Name = "RemoveShape_Button";
            RemoveShape_Button.Size = new Size(102, 23);
            RemoveShape_Button.TabIndex = 2;
            RemoveShape_Button.Text = "Remove shape";
            RemoveShape_Button.UseVisualStyleBackColor = true;
            RemoveShape_Button.Click += RemoveShape_Button_Click;
            // 
            // AddShape_Button
            // 
            AddShape_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddShape_Button.Location = new Point(12, 336);
            AddShape_Button.Name = "AddShape_Button";
            AddShape_Button.Size = new Size(102, 23);
            AddShape_Button.TabIndex = 1;
            AddShape_Button.Text = "Add shape";
            AddShape_Button.UseVisualStyleBackColor = true;
            AddShape_Button.Click += AddShape_Button_Click;
            // 
            // Shapes_DataGridView
            // 
            Shapes_DataGridView.AllowUserToAddRows = false;
            Shapes_DataGridView.AllowUserToDeleteRows = false;
            Shapes_DataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Shapes_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Shapes_DataGridView.Columns.AddRange(new DataGridViewColumn[] { Type, Square });
            Shapes_DataGridView.Location = new Point(12, 115);
            Shapes_DataGridView.MultiSelect = false;
            Shapes_DataGridView.Name = "Shapes_DataGridView";
            Shapes_DataGridView.ReadOnly = true;
            Shapes_DataGridView.RowTemplate.Height = 25;
            Shapes_DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Shapes_DataGridView.Size = new Size(350, 215);
            Shapes_DataGridView.TabIndex = 0;
            Shapes_DataGridView.SelectionChanged += Shapes_DataGridView_SelectionChanged;
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
            // EditeShapeButton
            // 
            EditeShapeButton.Anchor = AnchorStyles.Bottom;
            EditeShapeButton.Location = new Point(137, 336);
            EditeShapeButton.Name = "EditeShapeButton";
            EditeShapeButton.Size = new Size(102, 23);
            EditeShapeButton.TabIndex = 5;
            EditeShapeButton.Text = "Edite shape";
            EditeShapeButton.UseVisualStyleBackColor = true;
            EditeShapeButton.Click += EditeShapeButton_Click;
            // 
            // ShapesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 394);
            Controls.Add(groupBox1);
            Name = "ShapesForm";
            Text = "ShapesForm";
            FormClosing += ShapesForm_FormClosing;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Shapes_DataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button RemoveShape_Button;
        private Button AddShape_Button;
        private DataGridView Shapes_DataGridView;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Square;
        private Button Search_Button;
        private Panel ShapeControlPanel;
        private Button EditeShapeButton;
    }
}