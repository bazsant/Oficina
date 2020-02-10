using Oficina.Models;
using Oficina.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly IDapperRepository _dapperRepository;

        public PessoaRepository(IDapperRepository dapperRepository)
        {
            _dapperRepository = dapperRepository;
        }

        public int AdicionarPessoa(Pessoa pessoa)
        {
            var sql = @"
                INSERT INTO [dbo].[Pessoa]
	                ([Nome]
	                ,[CpfCnpj]
	                ,[Email])
                VALUES
	                (@Nome
	                ,@CpfCnpj
	                ,@Email)";

            return _dapperRepository.Execute(sql, new
            {
                pessoa.Nome,
                pessoa.CpfCnpj,
                pessoa.Email
            });
        }

    }
}
