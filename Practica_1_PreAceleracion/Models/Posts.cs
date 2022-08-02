using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_PreAceleracion.Models
{
    internal class Posts
    {
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Content { get; set; }

        public Usuario Usuario { get; set; }
    }
}
