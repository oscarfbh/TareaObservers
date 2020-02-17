using ConsoleObservers.Suscriptores.Interfaces;

namespace ConsoleObservers.Suscriptores
{
    class EjecucionSuscriptor : ISuscriptor
    {
        public string EjecutarAccion()
        {
            return "Pruebas unitarias se ejecutaron correctamente.";
        }

        public string EnviarMensajeAgregado()
        {
            return "Se agregó el observador de Ejecución de pruebas unitarias";
        }

        public string EnviarMensajeRemovido()
        {
            return "Se quitó el observador de Ejecución de pruebas unitarias";
        }
    }
}
