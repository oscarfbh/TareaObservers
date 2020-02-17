using ConsoleObservers.Suscriptores.Interfaces;

namespace ConsoleObservers.Interfaces
{
    public interface IObserved
    {

        void AddSuscriptor(ISuscriptor suscriptor);

        void RemoveSuscriptor(ISuscriptor suscriptor);

        void NotificarSuscriptores();
    }
}
