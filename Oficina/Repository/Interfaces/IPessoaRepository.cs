using Oficina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina.Repository.Interfaces
{
    public interface IPessoaRepository
    {
        int AdicionarPessoa(Pessoa pessoa);
        IEnumerable<Pessoa> ListarPessoas();
        Pessoa BuscarPessoa(int pessoaId);
        int AlterarPessoa(int pessoaId, Pessoa pessoa);
        int ExcluirPessoa(int pessoaId);
    }
}
