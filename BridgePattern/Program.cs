/*
 * Giả sử bạn có class Shape và 2 subclass là Hình tròn và Hình vuông.
 * Sau đó, do nhu cầu phát sinh, bạn muốn kết hợp thêm màu sắc vào là Đỏ và Xanh.
 * Tuy nhiên thì bạn đã có hai subclass rồi, nên muốn thêm màu sắc thì bạn phải tạo 4 subclass là Hình vuông Xanh, Hình vuông Đỏ, Hình Tròn Xanh, Hình Tròn đỏ.
 * Nếu ta thêm một màu hoặc một hình nữa thì sẽ phải tạo thêm lớp kế thừa.
 * Trong lớp Shape có một thuộc tính là Color, Color thì có thể thêm các màu kế thừa như Xanh Đỏ Tím Vàng tùy ý.
 * Khi đó muốn Hình Chữ Nhật Đỏ ta chỉ cần Hình Chữ Nhật có thuộc tính Màu là đỏ thôi,
 * tương tự với các hình khác mà không cần phải kế thừa nhiều.
 */
Console.WriteLine("Tao doi tuong");
var blue_color = new Blue();
var red_color = new Red();
Square blue_square = new Square { color = blue_color };
Square red_square = new Square { color = red_color };
Circle blue_circle = new Circle { color = blue_color };
Circle red_circle = new Circle { color = red_color };

Console.WriteLine($"Mau hinh chu nhat xanh: {blue_square.GetColor()}");
Console.WriteLine($"Mau hinh chu nhat do: {red_square.GetColor()}");
Console.WriteLine($"Mau hinh tron xanh: {blue_circle.GetColor()}");
Console.WriteLine($"Mau hinh tron do: {red_circle.GetColor()}");

interface Color
{
    string GetColor();
}

class Blue : Color
{
    public string GetColor()
    {
        return "Blue";
    }
}

class Red : Color
{
    public string GetColor()
    {
        return "Red";
    }
}

abstract class Shape
{
    public Color color { get; set; }

    public string GetColor()
    {
        return color.GetColor();
    }
}

class Square : Shape;

class Circle : Shape;