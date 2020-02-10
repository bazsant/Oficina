using Oficina.Models;
using Oficina.Repository.Interfaces;
using Oficina.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public int AdicionarPessoa(Pessoa pessoa)
        {
            return _pessoaRepository.AdicionarPessoa(pessoa);
        }

        public int AlterarPessoa(int pessoaId, Pessoa pessoa)
        {
            return _pessoaRepository.AlterarPessoa(pessoaId, pessoa);
        }

        public Pessoa BuscarPessoa(int pessoaId)
        {
            return _pessoaRepository.BuscarPessoa(pessoaId);
        }

        public int ExcluirPessoa(int pessoaId)
        {
            return _pessoaRepository.ExcluirPessoa(pessoaId);
        }

        public IEnumerable<Pessoa> ListarPessoas()
        {
            return _pessoaRepository.ListarPessoas();
        }
    }
}
