using BancoEventos.Domain.Entities.Common;

namespace BancoEventos.Domain
{
    public class Resposta : IEntity<int>
    {
        public int Id { get; set; }
        public int IdPergunta { get; set; }
        public string DescricaoResposta { get; set; }
        public bool Correta { get; set; }
        public bool Ativa { get; set; }
    }
}
