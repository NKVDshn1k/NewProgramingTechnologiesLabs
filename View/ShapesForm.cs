using Model;

namespace View
{
    public partial class ShapesForm : Form
    {
        private List<GeometricShape> _items = new List<GeometricShape>();
        public ShapesForm()
        {
            InitializeComponent();

            _items = GeometricShapeRepository.LoadOrCreate();

            Reload();
        }

        private void Add(GeometricShape item) =>
            Shapes_DataGridView.Rows
                    .Add(item.TypeName, item.CountSquare().ToString(".##"));

        private void Reload()
        {
            foreach (var item in _items)
                Add(item);
        }

        private void RemoveShape_Button_Click(object sender, EventArgs e)
        {
            int i = Shapes_DataGridView.SelectedRows[0].Index;
            Shapes_DataGridView.Rows.RemoveAt(i);
        }

        private void AddShape_Button_Click(object sender, EventArgs e)
        {
            var addForm = new AddShapeForm();

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
    }
}