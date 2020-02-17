using ConsoleObservers.Interfaces;
using ConsoleObservers.Suscriptores.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleObservers
{
    public class ObserverDevOps: IObserved
    {
        private List<ISuscriptor> Suscriptores { get; set; }

        public ObserverDevOps()
        {
            Suscriptores = new List<ISuscriptor>();
        }

        public void AddSuscriptor(ISuscriptor suscriptor)
        {
            if (!Suscriptores.Contains(suscriptor))
            {
                Suscriptores.Add(suscriptor);
                Console.WriteLine(suscriptor.EnviarMensajeAgregado());
                Console.WriteLine();
            }
        }

        public void RemoveSuscriptor(ISuscriptor suscriptor)
        {
            if (Suscriptores.Contains(suscriptor))
            {
                Suscriptores.Remove(suscriptor);
                Console.WriteLine(suscriptor.EnviarMensajeRemovido());
                Console.WriteLine();
            }
        }

        public void NotificarSuscriptores()
        {
            foreach (ISuscriptor suscriptor in Suscriptores)
            {
                Console.WriteLine(suscriptor.EjecutarAccion());
            }
        }

        public void SubirCodigo()
        {

            Console.WriteLine("Subiendo version de codigo 1.1");
            NotificarSuscriptores();
            Console.WriteLine();
        }
    }
}
