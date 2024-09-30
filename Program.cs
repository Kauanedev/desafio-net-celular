using DesafioPOO.Models;

Console.WriteLine("Nokia: ");
Smartphone nokia = new Nokia(numero: "912345678", modelo: "01", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Iphone: ");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "02 pro max", imei: "222222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");

