using ConsoleObservers.Suscriptores;
using ConsoleObservers.Suscriptores.Interfaces;
using System;

namespace ConsoleObservers
{
    class DevOps
    {
        static void Main(string[] args)
        {
            ObserverDevOps observer = new ObserverDevOps();
            ISuscriptor compilador = new CompilarSuscriptor();
            ISuscriptor correo = new CorreoSuscriptor();
            ISuscriptor ejecutor = new EjecucionSuscriptor();
            ISuscriptor instalador = new InstaladorSuscriptor();
            while (true)
            {
                Console.WriteLine("1. Subir código");
                Console.WriteLine("2. Compilar");
                Console.WriteLine("3. Ejecución de pruebas unitarias");
                Console.WriteLine("4. Instalar versión");
                Console.WriteLine("5. Correo de notificación");
                Console.WriteLine("6. Quitar compilar");
                Console.WriteLine("7. Quitar ejecución de pruebas unitarias");
                Console.WriteLine("8. Quitar instalar versión");
                Console.WriteLine("9. Quitar correo de notificación");
                Console.WriteLine("exit o quit para salir");
                Console.Write("introducir acción:");
                string line = Console.ReadLine();
                if (line.ToLower() == "exit" || line.ToLower() == "quit") // Check string
                {
                    break;
                }

                bool parsed = int.TryParse(line, out int option);
                if (parsed && (option > 0 && option < 10))
                {
                    switch (option)
                    {
                        case 2:
                            observer.AddSuscriptor(compilador);
                            break;
                        case 3:
                            observer.AddSuscriptor(ejecutor);
                            break;
                        case 4:
                            observer.AddSuscriptor(instalador);
                            break;
                        case 5:
                            observer.AddSuscriptor(correo);
                            break;
                        case 6:
                            observer.RemoveSuscriptor(compilador);
                            break;
                        case 7:
                            observer.RemoveSuscriptor(ejecutor);
                            break;
                        case 8:
                            observer.RemoveSuscriptor(instalador);
                            break;
                        case 9:
                            observer.RemoveSuscriptor(correo);
                            break;
                        default:
                            observer.SubirCodigo();
                            break;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Seleccione sólo alguna de las opciones disponibles");
                }
            }
        }
    }
}
