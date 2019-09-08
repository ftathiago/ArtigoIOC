using System;

namespace Observer
{
    class Cliente
    {
        public Cliente(ISubject subject)
        {
            _subject = subject;
        }

        public void Executar()
        {
            Console.WriteLine("Informe o nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe o número para o estado:");
            var stringEstado = Console.ReadLine();
            if (!int.TryParse(stringEstado, out var estado))
                Console.Write("Você não digitou um número!");

            var objeto = new ObjetoDTO
            {
                Nome = nome,
                Estado = estado
            };
            _subject.Notificar(objeto);
        }
        private ISubject _subject;
    }
}
