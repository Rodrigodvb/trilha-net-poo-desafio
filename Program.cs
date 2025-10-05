using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main()
    {
        //Instanciando Nokia
        Smartphone nokia = new Nokia("91234-5678", "Nokia POCO X7", "IMEI23549", 512);
        Console.WriteLine($"Nokia - Modelo: {nokia.Modelo}, Memória: {nokia.Memoria}GB");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        //Instanciando Iphone
        Smartphone iphone = new Iphone("99876-5432", "iPhone 17 Pro Max", "IMEI64117", 256);
        Console.WriteLine($"iPhone - Modelo: {iphone.Modelo}, Memória: {iphone.Memoria}GB");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");
    }
}