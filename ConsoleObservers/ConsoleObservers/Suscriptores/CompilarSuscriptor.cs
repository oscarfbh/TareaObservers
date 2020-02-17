using ConsoleObservers.Suscriptores.Interfaces;

namespace ConsoleObservers.Suscriptores
{
    class CompilarSuscriptor : ISuscriptor
    {
        public string EjecutarAccion()
        {
            return "Compilacion de codigo correcta";
        }

        public string EnviarMensajeAgregado()
        {
            return "Se agregó el observador de Compilar";
        }

        public string EnviarMensajeRemovido()
        {
            return "Se quitó el observador de Compilar";
        }
    }
}
