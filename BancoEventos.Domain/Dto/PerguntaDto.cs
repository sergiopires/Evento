using BancoEventos.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEventos.Domain.Dto
{
    public class PerguntaDto : IEntity<int>
    {
        public int Id { get; set; }
        public string DescricaoPergunta { get; set; }
        public int ValorPonto { get; set; }
    }
}
