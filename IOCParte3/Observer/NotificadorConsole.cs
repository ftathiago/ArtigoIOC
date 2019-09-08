using System;

namespace Observer
{
    class NotificadorConsole : IObserver
    {
        public void Update(ObjetoDTO objeto)
        {
            Console.WriteLine($"Notificando no console: Nome {objeto.Nome}; Estado: {objeto.Estado}");
        }
    }
}
