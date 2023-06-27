using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiArte.Models
{
    public class Arte
    {
            public int Id { get; set; }
            public string Titulo { get; set; }
            public string Categoria { get; set; }
            public string Artista { get; set; } = string.Empty;
            public int Data { get; set; }
            public string Descricao { get; set; }

            public string Localizacao { get; set; }

    }
}