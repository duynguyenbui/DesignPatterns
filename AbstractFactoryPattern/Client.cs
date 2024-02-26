namespace AbstractFactoryPattern;

class Client
{
    HuTieu hutieu;
    My my;
    
    public Client(MonAnFactory factory)
    {
        hutieu = factory.LayToHuTieu();
        my = factory.LayToMy();
    }

    public string GetHuTieuDetails()
    {
        return hutieu.GetModelDetails();
    }

    public string GetMyDetails()
    {
        return my.GetModelDetails();
    }
}