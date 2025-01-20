using DesafioPOO.Models;



Nokia meuNokia = new Nokia("12345", "Nokia X80", "400288922", "20GB");
meuNokia.InstalarAplicativo("Zapzap");
Console.WriteLine(meuNokia.Config());
meuNokia.Ligar();


Iphone meuIphone = new Iphone("54321", "iPhone 18", "123456789012345", "128GB");
meuIphone.InstalarAplicativo("Instagram");
Console.WriteLine(meuIphone.Config());
meuIphone.ReceberLigacao();



