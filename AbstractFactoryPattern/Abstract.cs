namespace AbstractFactoryPattern;

interface MonAnFactory
{
    HuTieu LayToHuTieu();
    My LayToMy();
}

interface HuTieu
{
    string GetModelDetails();
}

interface My
{
    string GetModelDetails();
}