namespace TemplateMethodPattern;

public abstract class DataMiner
{
    public string File { get; set; }
    public string RawData { get; set; }

    public virtual void OpenFile(string path)
    {
        Console.WriteLine("Opening file ::: {0}", path);
    }

    public virtual void CloseFile()
    {
        Console.WriteLine($"Closing file");
    }

    public abstract void ExtractData();
    public abstract void ParseData();

    public void Mine(string path)
    {
        OpenFile(path);
        ExtractData();
        ParseData();
        CloseFile();
    }
}