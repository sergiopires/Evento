using BancoEventos.Domain.Entities.Common;
using System;

namespace BancoEventos.Domain
{
    public class Quiz : IEntity<int>
    {
        public int Id { get; set; }
        public string DescricaoQuiz { get; set; }
        public DateTime DataQuiz { get; set; }
        public int IdCampanha { get; set; }
        public int PontoCorte { get; set; }
    }
}
