using Model;
using System.Runtime.Serialization.Formatters.Binary;

namespace View;

internal static class GeometricShapeRepository
{
    private const string _dbPath = "GeometricShape.cringe";
    private static readonly BinaryFormatter _formatter = new BinaryFormatter();
    public static List<GeometricShape> LoadOrCreate()
    {
        if (!File.Exists(_dbPath))
            return new List<GeometricShape>();

        using (FileStream fs = new FileStream(_dbPath, FileMode.OpenOrCreate))
        {
            return (List<GeometricShape>)_formatter.Deserialize(fs);
        }
    }

    public static void Save(List<GeometricShape> shapes)
    {        
        using (FileStream fs = new FileStream(_dbPath, FileMode.OpenOrCreate))
        {
            _formatter.Serialize(fs, shapes);
        }
    }
}
