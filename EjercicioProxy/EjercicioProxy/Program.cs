using System;

namespace EjercicioProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Coche coche = new Coche();
        
            Console.WriteLine("Inserte llave:");
            Proxy proxy = new Proxy(coche);
            cliente.CodigoCliente(proxy);            

            Console.ReadLine();
        }
    }
}
