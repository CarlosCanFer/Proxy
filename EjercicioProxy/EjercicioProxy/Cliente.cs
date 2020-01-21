using EjercicioProxy.Interfaces;

namespace EjercicioProxy
{
    public class Cliente
    {
        public void CodigoCliente(ICoche coche)
        {
            coche.EstadoCoche();
        }
    }
}
