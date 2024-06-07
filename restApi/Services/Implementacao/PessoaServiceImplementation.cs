using restApi.Model;
using System.Collections.Generic;
using System.Threading;

namespace restApi.Services.Implementacao
{
    public class PessoaServiceImplementation : IPessoaService
    {
        public volatile int count;

        public Pessoa Create(Pessoa person)
        {
            return person;
        }

        public void Delete(long id)
        {
        }

        public List<Pessoa> FindAll()
        {
            List<Pessoa> persons = new List<Pessoa>();
            for(int i = 0; i < 8; i++)
            {
                Pessoa person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        private Pessoa MockPerson(int i)
        {
            return new Pessoa
            {
                Id = IncrementAndGet(),
                PrimeiroNome = "Angelo" + i,
                SegundoNome = "Da Silva",
                Endereco = "Paranavaí",
                Genero = "Masculino"
            };
        }

        public Pessoa FindById(long id)
        {
            return new Pessoa {
                Id = IncrementAndGet(),
                PrimeiroNome = "Angelo",
                SegundoNome = "Da Silva",
                Endereco = "Paranavaí",
                Genero = "Masculino"
            };
        }

        public Pessoa Update(Pessoa person)
        {
            return person;
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
