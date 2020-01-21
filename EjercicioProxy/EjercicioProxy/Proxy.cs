using EjercicioProxy.Interfaces;
using System;

namespace EjercicioProxy
{
    class Proxy : ICoche
    {
        private Coche _Coche;

        public Proxy(Coche coche) {
            this._Coche = coche;
        }
        public void EstadoCoche()
        {
            string _cllave = Console.ReadLine();
            if (this.ComprobarAcceso(_cllave))
            {
                this._Coche = new Coche();
                this._Coche.EstadoCoche();

                this.DarAcceso();
            }
            else {
                Console.WriteLine("Acceso denegado");
            }
        }

        public bool ComprobarAcceso(string _cllave)
        {
            if (_cllave == "123")
            {
                Console.WriteLine("llave Correcta");
                return true;
            }          

            return false;
        }
        public void DarAcceso()
        {
            Console.WriteLine("Motor encendido.");
        }
    }
}
