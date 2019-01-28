using BancoEventos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEventos.Infra.Persistence.Map
{
    public class PerguntaMap : EntityTypeConfiguration<Pergunta>
    {

        public PerguntaMap()
        {
            ToTable("TB_PERGUNTA");
            Property(p => p.Codigo).IsRequired().HasColumnName("ID_PERGUNTA");
            Property(p => p.DescricaoPergunta).IsRequired().HasColumnName("DESCRICAO_PERGUNTA");
            Property(p => p.ValorPonto).IsRequired().HasColumnName("VALOR_PONTO");
         
        }

    }
}
