using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"12345", model:"Modelo 1", imei: "121212", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"64323", model:"Modelo 3", imei: "548523", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Youtube");