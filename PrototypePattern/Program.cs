// See https://aka.ms/new-console-template for more information

Person p1 = new Person();
p1.Age = 42;
p1.BirthDate = Convert.ToDateTime("1977-01-01");
p1.Name = "Jack Daniels";
p1.IdInfo = new IdInfo(666);

// Thực thi shallow copy của P1 và truyền nó cho P2
Person p2 = p1.ShallowCopy();
// Thực thi deep copy của P1 và truyền cho P3
Person p3 = p1.DeepCopy();

// Hiển thị giá trị P1, P2, P3
Console.WriteLine("Original values of p1, p2, p3:");
Console.WriteLine("   p1 instance values: ");
DisplayValues(p1);
Console.WriteLine("   p2 instance values:");
DisplayValues(p2);
Console.WriteLine("   p3 instance values:");
DisplayValues(p3);

// Thay đổi giá trị của thuộc tính P1 và hiển thị giá trị P1, P2, P3
p1.Age = 32;
p1.BirthDate = Convert.ToDateTime("1900-01-01");
p1.Name = "Frank";
p1.IdInfo.IdNumber = 7878;
Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
Console.WriteLine("   p1 instance values: ");
DisplayValues(p1);
Console.WriteLine("   p2 instance values (reference values have changed):");
DisplayValues(p2);
Console.WriteLine("   p3 instance values (everything was kept the same):");
DisplayValues(p3);

void DisplayValues(Person p)
{
    Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
        p.Name, p.Age, p.BirthDate);
    Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
}

public class Person
{
    public int Age;
    public DateTime BirthDate;
    public string Name;
    public IdInfo IdInfo;

    //Các object con bên trong chỉ được copy reference. Nghĩa là chỉ nhân bản được value type.
    public Person ShallowCopy()
    {
        return (Person)this.MemberwiseClone();
    }

    //Các object con bên trong cũng được copy lại toàn bộ các thuộc tính.
    public Person DeepCopy()
    {
        Person clone = (Person)this.MemberwiseClone();
        clone.IdInfo = new IdInfo(IdInfo.IdNumber);
        clone.Name = String.Copy(Name);
        return clone;
    }
}

public class IdInfo
{
    public int IdNumber;

    public IdInfo(int idNumber)
    {
        this.IdNumber = idNumber;
    }
}