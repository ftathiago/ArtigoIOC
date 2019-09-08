using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var notificadorConsole = new NotificadorConsole();
            var notificadorBlueTooth = new NotificadorBlueTooth();

            var subject = new Subject();
            subject.Adicionar(notificadorConsole);
            subject.Adicionar(notificadorBlueTooth);

            var cliente = new Cliente(subject);
            cliente.Executar();

            Console.WriteLine();
            Console.WriteLine("Vamos executar sem o bluetooth");
            Console.WriteLine();
            subject.Remover(notificadorBlueTooth);
            cliente.Executar();

            Console.ReadLine();
        }
    }
}
