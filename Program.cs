using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "1234", modelo: "Modelo 4", imei: "2139012873", memoria: 124);
nokia.Ligar();
nokia.InstalarAplicativo("X/Twitter");


Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "3242", modelo: "modelo 1", imei: "192379123", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");