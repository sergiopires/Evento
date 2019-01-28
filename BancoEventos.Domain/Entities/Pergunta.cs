using BancoEventos.Domain.Entities.Common;

namespace BancoEventos.Domain
{
    public class Pergunta : IEntity<int>
    {
        public int Id { get; set; }
        public string DescricaoPergunta { get; set; }
        public int ValorPonto { get; set; }
    }
}
