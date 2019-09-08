namespace Observer
{
    interface ISubject
    {
        void Adicionar(IObserver observer);
        void Remover(IObserver observer);
        void Notificar(ObjetoDTO objeto);
    }
}
