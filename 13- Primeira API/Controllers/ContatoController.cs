using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _13__Primeira_API.Entities;
using Microsoft.AspNetCore.Mvc;
using _13__Primeira_API.Context;

namespace _13__Primeira_API.Controllers
{
    [ApiController] //Importar Controller
    [Route("[controller]")] //Declarar rota
    public class ContatoController : ControllerBase //Herdando da classe ControllerBase do Entity Framework
    {
      private readonly AgendaContext _context; //declarando contexto

      public ContatoController(AgendaContext context) //Criando construtor para pegar o contexto de AgendaContext
      {
        _context = context; //Atribuindo contexto de AgendaContext com a da classe
      }
      [HttpPost] //Dizendo que o método é post
      public IActionResult Create(Contato contato) //Método que será feito
        {
            _context.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ReadById), new {id = contato.ID}, contato);
        }

        [HttpGet("{id}")] //Pegar por id (get)
        public IActionResult ReadById(int id)
        {
            var contato = _context.Contatos.Find(id);
            if (contato != null)
            {
                return Ok(contato);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("ObterPorNome")] //Pegar por nome
        public IActionResult ReadByName(string nome)
        {
            var contato = _context.Contatos.Where(x => x.Nome.Contains(nome));
            if (contato != null)
            {
                return Ok(contato);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{id}")] //Atualizar
        public IActionResult Update(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);
            if (contatoBanco == null)
            {
               return NotFound();
            }

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Status = contato.Status;

           _context.Contatos.Update(contatoBanco);
           _context.SaveChanges();

           return Ok(contatoBanco);
        }

        [HttpDelete("{id}")] //Deletar
        public IActionResult Delete(int id)
        {
           var contatoBanco = _context.Contatos.Find(id);
           if (contatoBanco == null)
            {
               return NotFound();
            }
            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();

            return NoContent();
        }


    }
}