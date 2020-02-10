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

        public int AlterarPessoa(int pessoaId, Pessoa pessoa)
        {
            var sql = @"
                UPDATE [dbo].[Pessoa]
                SET [Nome] = @Nome
                    ,[CpfCnpj] = @CpfCnpj
                    ,[Email] = @Email
                WHERE Id = @PessoaId";

            return _dapperRepository.Execute(sql, new
            {
                pessoa.Nome,
                pessoa.CpfCnpj,
                pessoa.Email,
                PessoaId = pessoaId
            });
        }

        public Pessoa BuscarPessoa(int pessoaId)
        {
            var sql = @"
                SELECT
                    [Id]
	                ,[Nome]
	                ,[CpfCnpj]
	                ,[Email]
                FROM
                    [dbo].[Pessoa]
                WHERE
                    [Id] = @PessoaId";

            var param = new {
                PessoaId = pessoaId
            };

            return _dapperRepository.Query<Pessoa>(sql, param).FirstOrDefault();
        }

        public int ExcluirPessoa(int pessoaId)
        {
            var sql = @"
                DELETE FROM [dbo].[Pessoa]
                    WHERE Id = @PessoaId";

            return _dapperRepository.Execute(sql, new
            {
                PessoaId = pessoaId
            });
        }

        public IEnumerable<Pessoa> ListarPessoas()
        {
            var sql = @"
                SELECT
                    [Id]
	                ,[Nome]
	                ,[CpfCnpj]
	                ,[Email]
                FROM
                    [dbo].[Pessoa]";

            return _dapperRepository.Query<Pessoa>(sql);
        }
    }
}
