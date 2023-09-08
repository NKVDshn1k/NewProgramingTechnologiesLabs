using Model;
using System.Runtime.Serialization.Formatters.Binary;

namespace View;

internal static class GeometricShapeRepository
{
    //Путь к файлу со списком фигур
    private const string _dbPath = "GeometricShape.cringe";
    private static readonly BinaryFormatter _formatter = new BinaryFormatter();

    //Считывает файл с фигурами или возвращает новый список
    public static List<GeometricShape> LoadOrCreate()
    {
        if (!File.Exists(_dbPath))
            return new List<GeometricShape>();

        try
        {
            using (FileStream fs = new FileStream(_dbPath, FileMode.OpenOrCreate))
            {
                return (List<GeometricShape>)_formatter.Deserialize(fs);
            }
        }
        catch
        {
            return new List<GeometricShape>();
        }

    }

    //сохраняет список фигур
    public static void Save(List<GeometricShape> shapes)
    {        
        using (FileStream fs = new FileStream(_dbPath, FileMode.OpenOrCreate))
        {
            _formatter.Serialize(fs, shapes);
        }
    }
    //Я безполезный комментарий
}
