using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Practica_1_PreAceleracion.Models
{
    internal class Context : DbContext 
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Posts> Posts { get; set; }

        public DbSet<Comments> Comments { get; set; }
    }
}
