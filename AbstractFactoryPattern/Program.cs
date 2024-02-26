// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern;

MonAnFactory loaiNac = new LoaiNacFactory();
Client NacClient = new Client(loaiNac);
MonAnFactory loaiGio = new LoaiGioFactory();
Client GioClient = new Client(loaiGio);

Console.WriteLine("********* HU TIEU **********");
Console.WriteLine(NacClient.GetHuTieuDetails());
Console.WriteLine(GioClient.GetHuTieuDetails());

Console.WriteLine("******* MY **********");
Console.WriteLine(NacClient.GetMyDetails());
Console.WriteLine(GioClient.GetMyDetails());
