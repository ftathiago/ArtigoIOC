using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class NotificadorBlueTooth : IObserver
    {
        public void Update(ObjetoDTO objeto)
        {
            if (objeto.Estado == 1)
            {
                Console.WriteLine("Faz de conta que eu mandei os dados por bluetooth");
                return;
            }
            Console.WriteLine("Se você informar um Estado = 1, vou enviar uma notificação para o seu bluetooth");
        }
    }
}
