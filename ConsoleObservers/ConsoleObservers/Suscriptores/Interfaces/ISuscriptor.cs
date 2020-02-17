namespace ConsoleObservers.Suscriptores.Interfaces
{
    public interface ISuscriptor
    {
        string EjecutarAccion();

        string EnviarMensajeAgregado();

        string EnviarMensajeRemovido();
    }
}
