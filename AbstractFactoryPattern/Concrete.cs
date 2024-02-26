namespace AbstractFactoryPattern;

class LoaiGioFactory : MonAnFactory
{
    public HuTieu LayToHuTieu()
    {
        return new HuTieuGio();
    }

    public My LayToMy()
    {
        return new MyGio();
    }
}

class LoaiNacFactory : MonAnFactory
{
    public HuTieu LayToHuTieu()
    {
        return new HuTieuNac();
    }

    public My LayToMy()
    {
        return new MyNac();
    }
}