﻿using System;
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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Pessoa/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pessoa
        [HttpPost]
        public void Post([FromBody] Pessoa pessoa)
        {
            _pessoaService.AdicionarPessoa(pessoa);
        }

        // PUT: api/Pessoa/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pessoa pessoa)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
