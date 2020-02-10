using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oficina.Models;
using Oficina.Services.Interfaces;

namespace Oficina.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;
        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        // GET: api/Pessoa
        [HttpGet]
        public IEnumerable<Pessoa> Get()
        {
            return _pessoaService.ListarPessoas();
        }

        // GET: api/Pessoa/5
        [HttpGet("{pessoaId}", Name = "Get")]
        public Pessoa Get(int pessoaId)
        {
            return _pessoaService.BuscarPessoa(pessoaId);
        }

        // POST: api/Pessoa
        [HttpPost]
        public JsonResult Post([FromBody] Pessoa pessoa)
        {
            return new JsonResult(_pessoaService.AdicionarPessoa(pessoa));
        }

        // PUT: api/Pessoa/5
        [HttpPut("{pessoaId}")]
        public JsonResult Put(int pessoaId, [FromBody] Pessoa pessoa)
        {
            return new JsonResult(_pessoaService.AlterarPessoa(pessoaId, pessoa));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{pessoaId}")]
        public JsonResult Delete(int pessoaId)
        {
            return new JsonResult(_pessoaService.ExcluirPessoa(pessoaId));
        }
    }
}
