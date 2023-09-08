using Model;

namespace View
{
    public partial class ShapesForm : Form
    {
        private List<GeometricShape> _items = new List<GeometricShape>();
        private ShapeControl _shapeControl = new ShapeControl();

        private int SelectedIndex =>
            Shapes_DataGridView.SelectedRows[0].Index;

        public ShapesForm()
        {
            InitializeComponent();

            _items = GeometricShapeRepository.LoadOrCreate();

            ShapeControlPanel.Controls.Add(_shapeControl);
            _shapeControl.IsReadOnly = true;

            foreach (var item in _items)
                Add(item);
        }

        private void Add(GeometricShape item) =>
            Shapes_DataGridView.Rows
                    .Add(item.TypeName, item.CountSquare().ToString(".##"));

        private void EditeSelected(GeometricShape item)
        {
            Shapes_DataGridView.Rows[SelectedIndex].Cells[0].Value = item.TypeName;
            Shapes_DataGridView.Rows[SelectedIndex].Cells[1].Value = item.CountSquare().ToString(".##");
        }



        private void RemoveShape_Button_Click(object sender, EventArgs e) =>
            Shapes_DataGridView.Rows.RemoveAt(SelectedIndex);

        private void AddShape_Button_Click(object sender, EventArgs e)
        {
            var addForm = new AddEditeShapeForm();

            if (addForm.ShowDialog() != DialogResult.OK)
                return;

            Add(addForm.ToAdd);
            _items.Add(addForm.ToAdd);
        }

        private void Search_Button_Click(object sender, EventArgs e) =>
            new SearchForm(_items).ShowDialog();

        private void ShapesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GeometricShapeRepository.Save(_items);
        }

        private void Shapes_DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int i = Shapes_DataGridView.SelectedRows[0].Index;
            _shapeControl.Object = _items[i];
        }

        private void EditeShapeButton_Click(object sender, EventArgs e)
        {
            var editeForm = new AddEditeShapeForm(_items[SelectedIndex]);

            if (editeForm.ShowDialog() != DialogResult.OK)
                return;

            EditeSelected(editeForm.ToAdd);
            _items[SelectedIndex] = editeForm.ToAdd;
            _shapeControl.Object = editeForm.ToAdd;
        }
    }
}