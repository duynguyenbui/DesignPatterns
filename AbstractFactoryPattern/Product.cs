namespace AbstractFactoryPattern;

class HuTieuNac : HuTieu
{
    public string GetModelDetails()
    {
        return "HU TIEU NAC cua em day";
    }
}
    
class HuTieuGio : HuTieu
{
    public string GetModelDetails()
    {
        return "HU TIEU GIO cua em day";
    }
}

class MyNac : My
{
    public string GetModelDetails()
    {
        return "MY NAC cua em day";
    }
}
    
class MyGio : My
{
    public string GetModelDetails()
    {
        return "MY GIO cua em day";
    }
}