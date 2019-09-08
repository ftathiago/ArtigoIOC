using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface ISubject
    {
        void Adicionar(IObserver observer);
        void Remover(IObserver observer);
        void Notificar(ObjetoDTO objeto);
    }
}
