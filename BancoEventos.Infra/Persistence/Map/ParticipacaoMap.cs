using BancoEventos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEventos.Infra.Persistence.Map
{
    public class ParticipacaoMap : EntityTypeConfiguration<Participacao>
    {
        public ParticipacaoMap()
        {
            ToTable("TB_PARTICIPACAO");

            Property(p => p.Codigo).IsRequired().HasColumnName("ID_PARTICIPANTE");
            Property(p => p.QtdParticipacaoPermitida).IsRequired().HasColumnName("QTD_PARTICIPACAO_PERMITIDA");
            Property(p => p.QtdParticipacaoExecutada).IsRequired().HasColumnName("QTD_PARTICIPACAO_EXECUTADA");
            Property(p => p.DataParticipacao).HasColumnType("DATETIME").HasColumnName("DATA_PARTICIPACAO");
        }

    }
}
