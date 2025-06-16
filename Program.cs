using DesafioPOO.Models;

Smartphone celularNokia = new Nokia("99666-6669", "Nokia 2", "123321", 32);
Smartphone celularIphone = new Iphone("96999-9996", "Iphone X", "321123", 64);

Console.WriteLine("Nokia: ");
celularNokia.Ligar();
celularNokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n--------------------------------------------------------------------------------\n");

Console.WriteLine("Iphone: ");
celularIphone.ReceberLigacao();
celularIphone.InstalarAplicativo("Whatsapp");