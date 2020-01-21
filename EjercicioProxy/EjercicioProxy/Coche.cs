using EjercicioProxy.Interfaces;
using System;

namespace EjercicioProxy
{
    class Coche : ICoche
    {
        public void EstadoCoche()
        {           
                Console.WriteLine("Coche encendido");           
        }
    }
}
