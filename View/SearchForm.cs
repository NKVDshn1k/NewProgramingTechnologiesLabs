using Model;
using System.Data;

namespace View;

public partial class SearchForm : Form
{
    private List<GeometricShape> _items;
    private bool TypeSearch =>
        Type_CheckBox.Checked;
    private bool SquareSearch =>
        Square_CheckBox.Checked;

    public SearchForm(List<GeometricShape> items)
    {
        InitializeComponent();
        _items = items;
        Reload();
        Type_ComboBox.Items.AddRange(
            new string[]
            {
                typeof(Circle).Name ,
                typeof(Model.Rectangle).Name,
                typeof(Triangle).Name,
            });
    }

    private void Add(GeometricShape item) =>
        Shapes_DataGridView.Rows
            .Add(item.TypeName, item.CountSquare().ToString(".##"));

    private void Reload()
    {
        Shapes_DataGridView.Rows.Clear();
        foreach (var item in _items)
            Add(item);
    }

    private void Search_Button_Click(object sender, EventArgs e)
    {
        if (!TypeSearch && !SquareSearch)
        {
            Reload();
            return;
        }

        Shapes_DataGridView.Rows.Clear();

        IEnumerable<GeometricShape> match = _items;

        if (TypeSearch)
            match = match
                .Where(x => x.TypeName == Type_ComboBox.Text);
        if (SquareSearch)
            match = match
                .Where(x => x.CountSquare() == (double)Square_Numeric.Value);

        foreach (var item in match)
            Add(item);
    }
}
