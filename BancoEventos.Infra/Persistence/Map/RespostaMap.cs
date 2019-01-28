using BancoEventos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEventos.Infra.Persistence.Map
{
    public class RespostaMap : EntityTypeConfiguration<Resposta>
    {
        public RespostaMap()
        {
            ToTable("TB_RESPOSTA");
            Property(p => p.Codigo).HasColumnType("INT").IsRequired().HasColumnName("ID_RESPOSTA");
            Property(p => p.IdPergunta).HasColumnType("INT").IsRequired().HasColumnName("ID_PERGUNTA");
            Property(p => p.DescricaoResposta).HasMaxLength(200).IsRequired().HasColumnName("RESPOSTA");

            Property(p => p.Correta).HasColumnType("BOOL").IsRequired().HasColumnName("ID_CAMPANHA");
            Property(p => p.Ativa).HasColumnType("BOOL").IsRequired().HasColumnName("ATIVA");
        }

    }
}
