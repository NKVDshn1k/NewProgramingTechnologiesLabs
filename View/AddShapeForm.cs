using Model;

namespace View
{
    public partial class AddShapeForm : Form
    {
        private static readonly Dictionary<string, int> _types = new Dictionary<string, int>()
        {
            { typeof(Circle).Name , 1},
            { typeof(Model.Rectangle).Name, 2},
            { typeof(Triangle).Name, 3}
        };
        private static readonly Random _rnd = new Random();
        private decimal GetRandDecimal(int min, int max) =>
            (decimal)(_rnd.NextDouble() + _rnd.Next(min, max));

        private int _currentType;
        public GeometricShape ToAdd { get; private set; }

        private double Size1 =>
            (double)Size1_Numeric.Value;
        private double Size2 =>
            (double)Size2_Numeric.Value;

        public AddShapeForm()
        {
            InitializeComponent();

            Type_ComboBox.Items.AddRange(_types.Keys.ToArray());
            Type_ComboBox.SelectedIndex = 0;
#if !DEBUG
                CreateRandomData.Visible = false;
#endif


        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_currentType)
                {
                    case 1:
                        ToAdd = new Circle(Size1);
                        break;
                    case 2:
                        ToAdd = new Model.Rectangle(Size1, Size2);
                        break;
                    case 3:
                        ToAdd = new Triangle(Size1, Size2);
                        break;
                }
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
            switch (_currentType)
            {
                case 1:
                    PresetForValues("Radius");
                    break;
                case 2:
                    PresetForValues("Height", "Width");
                    break;
                case 3:
                    PresetForValues("Height", "Footing");
                    break;
            }
        }

        private void PresetForValues(string sizeName1, string sizeName2 = null)
        {
            Size1_Label.Text = sizeName1;
            if (sizeName2 != null)
            {
                Size2_Label.Visible = true;
                Size2_Numeric.Visible = true;
                Size2_Label.Text = sizeName2;
            }
            else
            {
                Size2_Label.Visible = false;
                Size2_Numeric.Visible = false;
            }
        }

        private void CreateRandomData_Click(object sender, EventArgs e)
        {
            Size1_Numeric.Value = GetRandDecimal(1, 100);
            Size2_Numeric.Value = GetRandDecimal(1, 100);
        }
    }
}
