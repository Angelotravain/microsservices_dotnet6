using restApi.Model;
using System.Collections.Generic;

namespace restApi.Services
{
    public interface IPessoaService
    {
        Pessoa Create(Pessoa person);
        Pessoa FindById(long id);
        List<Pessoa> FindAll();
        Pessoa Update(Pessoa person);
        void Delete(long id);

    }
}
