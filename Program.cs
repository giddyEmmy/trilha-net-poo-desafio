using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("1122223333", "Modelo1", "123454321", 32);
nokia.InstalarAplicativo("Whatsapp");
nokia.Ligar();

Console.WriteLine("-----");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("3322221111", "Modelo5", "543212345", 120);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
