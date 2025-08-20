using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "55999562352", modelo: "Modelo X", imei: "2345233462", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");


Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "55999181734", modelo: "Iphone 16e", imei: "2125678889765", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("GovBR");
