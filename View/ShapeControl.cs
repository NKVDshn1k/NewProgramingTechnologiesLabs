using Model;

namespace View
{
    public partial class ShapeControl : UserControl
    {
        private static readonly Dictionary<string, int> _types = new Dictionary<string, int>()
        {
            { typeof(Circle).Name , 1},
            { typeof(Model.Rectangle).Name, 2},
            { typeof(Triangle).Name, 3}
        };

        private double Size1
        {
            get => (double)Size1_Numeric.Value;
            set => Size1_Numeric.Value = (decimal)value;
        }

        private double Size2
        {
            get => (double)Size2_Numeric.Value;
            set => Size2_Numeric.Value = (decimal)value;
        }

        private int _currentType;
        private static readonly Random _rnd = new Random();
        public GeometricShape Object
        {
            get
            {
                GeometricShape toAdd = null;
                switch (_currentType)
                {
                    case 1:
                        toAdd = new Circle(Size1);
                        break;
                    case 2:
                        toAdd = new Model.Rectangle(Size1, Size2);
                        break;
                    case 3:
                        toAdd = new Triangle(Size1, Size2);
                        break;
                }
                return toAdd;

            }
            set
            {
                _currentType = _types[value.GetType().Name];
                switch (_currentType)
                {
                    case 1:
                        Size1 = ((Circle)value).Radius;
                        PresetForValues("Radius");
                        break;
                    case 2:
                        var rct = (Model.Rectangle)value;
                        Size1 = rct.Height;
                        Size2 = rct.Width;
                        PresetForValues("Height", "Width");
                        break;
                    case 3:
                        var trig = (Triangle)value;
                        Size1 = trig.Height;
                        Size2 = trig.Footing;
                        PresetForValues("Height", "Footing");
                        break;
                }
            }
        }
        public bool IsReadOnly
        {
            get => Size1_Numeric.ReadOnly && Size2_Numeric.ReadOnly;
            set
            {
                Size1_Numeric.ReadOnly = Size2_Numeric.ReadOnly = value;
                if (value)
                    Size1_Numeric.Increment = Size2_Numeric.Increment = 0;
                else
                    Size1_Numeric.Increment = Size2_Numeric.Increment = 1;
#if DEBUG
                CreateRandomData.Visible = !value;
#endif

            }
        }

        public ShapeControl()
        {
            InitializeComponent();

#if !DEBUG
                CreateRandomData.Visible = false;
#endif
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
            Size1 = GetRandDouble(1, 100);
            Size2 = GetRandDouble(1, 100);
        }

        private double GetRandDouble(int min, int max) =>
            (_rnd.NextDouble() + _rnd.Next(min, max));
    }
}
