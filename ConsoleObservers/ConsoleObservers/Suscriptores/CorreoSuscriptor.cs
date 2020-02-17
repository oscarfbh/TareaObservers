using ConsoleObservers.Suscriptores.Interfaces;

namespace ConsoleObservers.Suscriptores
{
    class CorreoSuscriptor : ISuscriptor
    {
        public string EjecutarAccion()
        {
            return "Correo enviado";
        }

        public string EnviarMensajeAgregado()
        {
            return "Se agregó el observador de envío de correo";
        }

        public string EnviarMensajeRemovido()
        {
            return "Se quitó el observador de envío de correo";
        }
    }
}
