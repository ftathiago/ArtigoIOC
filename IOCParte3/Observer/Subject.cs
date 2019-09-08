using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Subject : ISubject
    {
        public Subject()
        {
            _observers = new List<IObserver>();
        }
        public void Adicionar(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Notificar(ObjetoDTO objeto)
        {
            foreach (var observer in _observers)
            {
                observer.Update(objeto);
            };
        }

        public void Remover(IObserver observer)
        {
            _observers.Remove(observer);
        }

        private List<IObserver> _observers;
    }
}
