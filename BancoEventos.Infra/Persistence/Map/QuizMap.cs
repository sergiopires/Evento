using BancoEventos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEventos.Infra.Persistence.Map
{
    public class QuizMap : EntityTypeConfiguration<Quiz>
    {
        public QuizMap()
        {
            ToTable("TB_QUIZ");
            Property(p => p.Codigo).IsRequired().HasColumnName("ID_QUIZ");
            Property(p => p.DescricaoQuiz).HasMaxLength(200).IsRequired().HasColumnName("DESCRICAO");
            Property(p => p.DataQuiz).HasColumnType("DATETIME").IsRequired().HasColumnName("DT_QUIZ");

            Property(p => p.IdCampanha).IsRequired().HasColumnName("ID_CAMPANHA");
            Property(p => p.PontoCorte).HasColumnType("INT").IsRequired();
             
    }

    }
}
