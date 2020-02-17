using ConsoleObservers.Suscriptores.Interfaces;

namespace ConsoleObservers.Suscriptores
{
    class InstaladorSuscriptor : ISuscriptor
    {
        public string EjecutarAccion()
        {
            return "Versión instalada";
        }

        public string EnviarMensajeAgregado()
        {
            return "Se agregó el observador de Instalador de versión";
        }

        public string EnviarMensajeRemovido()
        {
            return "Se quitó el observador de Instalador de versión";
        }
    }
}
