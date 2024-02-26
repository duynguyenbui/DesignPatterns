// See https://aka.ms/new-console-template for more information
// =============== Secret Name = Policy ===============
ExportContext ctx = new ExportContext(new ExportPNG());
ctx.CreateArchive("Mushroom");
ctx.SetStrategy(new ExportJPG());
ctx.CreateArchive("Mushroom");
ctx.SetStrategy(new ExportPDF());
ctx.CreateArchive("Mushroom");
Console.Read();

public class ExportContext
{
    private IExport Export;

    public ExportContext(IExport Export)
    {
        this.Export = Export;
    }
    public void SetStrategy(IExport Export)
    {
        this.Export = Export;
    }
    public void CreateArchive(string fileName)
    {
        Export.ExportFile(fileName);
    }
}   

public interface IExport
{
    void ExportFile(string fileName);
}  

public class ExportJPG : IExport
{
    public void ExportFile(string fileName)
    {
        Console.WriteLine("Export file: '" + fileName
                                           + ".JPG' successfully");
    }
}
    
public class ExportPDF : IExport
{
    public void ExportFile(string fileName)
    {
        Console.WriteLine("Export file: '" + fileName
                                           + ".PDF' successfully");
    }
}
    
public class ExportPNG : IExport
{
    public void ExportFile(string fileName)
    {
        Console.WriteLine("Export file: '" + fileName
                                           + ".PNG' successfully");
    }
}
