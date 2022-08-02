using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_PreAceleracion.Models
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public List<Posts> Publication { get; set; }

        public List<Comments> Comment { get; set; }
    }
}
