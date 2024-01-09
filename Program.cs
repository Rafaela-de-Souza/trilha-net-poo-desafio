using DesafioPOO.Models;
class Program
{
    static void Main()
    {
        // Teste Nokia
        Nokia nokia = new Nokia(numero:"9999-8888", modelo:"Nokia Modelo", imei:"IMEI999", memoria:16);
        nokia.Ligar();
        //nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Galeria");

        Console.WriteLine(); 

        // Teste iPhone
        Iphone iphone = new Iphone(numero:"90000-111", modelo:"iPhone Modelo", imei:"IMEI000", memoria:64);
        /// iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("AppiPhone");
    }
}
