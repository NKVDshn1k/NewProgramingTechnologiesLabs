using Model;

namespace View
{
    public partial class AddEditeShapeForm : Form
    {
        private static readonly Dictionary<string, int> _types = new Dictionary<string, int>()
        {
            { typeof(Circle).Name , 1},
            { typeof(Model.Rectangle).Name, 2},
            { typeof(Triangle).Name, 3}
        };

        private ShapeControl _shapeControl = new ShapeControl();

        private int _currentType;
        public GeometricShape ToAdd { get; private set; }

        public AddEditeShapeForm(GeometricShape shape = null)
        {
            InitializeComponent();

            Type_ComboBox.Items.AddRange(_types.Keys.ToArray());
            Type_ComboBox.SelectedIndex = 0;

            ShapeControlPanel.Controls.Add(_shapeControl);

            if (shape != null )
            {
                _shapeControl.Object = shape;
                Type_ComboBox.Visible = false;
            }
            else
            {
                _shapeControl.Object = CtorById(_currentType);
            }

        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            try
            {
                ToAdd = _shapeControl.Object;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void Cancel_Button_Click(object sender, EventArgs e) =>
            DialogResult = DialogResult.Cancel;

        private void Type_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentType = _types[Type_ComboBox.Text];
            _shapeControl.Object = CtorById(_currentType);
        }

        private GeometricShape CtorById(int id) =>
            id switch
            {
                1 => new Circle(),
                2 => new Model.Rectangle(),
                3 => new Triangle()
            };
    }
}
