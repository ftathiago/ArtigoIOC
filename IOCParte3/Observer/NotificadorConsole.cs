using System;
using System.Collections.Generic;
using System.Text;

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
