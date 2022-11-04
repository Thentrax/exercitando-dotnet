using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _13__Primeira_API.Entities;

namespace _13__Primeira_API.Context
{
   public class AgendaContext : DbContext //Herdando de Dbcontext do Entity Framework
   {
      public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) //Construtor que pega as opções da base
      {

      }

      public DbSet<Contato> Contatos { get; set; } //Diz que essa classe pertence ao banco, na hora da migration ela vai ser considerada.
   }
}