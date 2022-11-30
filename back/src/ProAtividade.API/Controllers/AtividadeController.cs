using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProAtividade.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtividadeController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "Meu primeiro método get.";
        }


        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Meu primeiro método get com parâmetro {id}";
        }



        [HttpPost]
        public string Post()
        {
            return "Meu primeiro método post.";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "Meu primeiro método put.";
        }

        
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Meu primeiro método delete.";
        }


    }
}