using BancoEventos.Domain.Entities.Common;
using System;

namespace BancoEventos.Domain
{
    public class Participacao : IEntity<int>
    {
        public int Id { get; set; }
        public int IdParticipante { get; set; }
        public int QtdParticipacaoPermitida { get; set; }
        public int QtdParticipacaoExecutada { get; set; }
        public DateTime DataParticipacao { get; set; }
    }
}
