using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
var nokia = new Nokia("123456", "Modelo 1", "111111", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone Iphone");
var iphone = new Iphone("987456", "Modelo 2", "222222", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");