namespace ICT3101_Calculator;

public class FileReader : IFileReader
{
    public String[] Read(string path)
    {
        return File.ReadAllLines(path);
    }
}