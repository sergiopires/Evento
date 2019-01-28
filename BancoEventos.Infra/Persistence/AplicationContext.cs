using BancoEventos.Domain;
using BancoEventos.Infra.Persistence.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEventos.Infra.Persistence
{
    public class AplicationContext : DbContext
    {

        public AplicationContext()
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }
        public DbSet<Quiz> Quiz { get; set; }
        public DbSet<Pergunta> Pergunta { get; set; }
        public DbSet<Resposta> Resposta { get; set; }
        public DbSet<Participacao> Participacao { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new QuizMap());
            modelBuilder.Configurations.Add(new PerguntaMap());
            modelBuilder.Configurations.Add(new RespostaMap());
            //modelBuilder.Configurations.Add(new ParticipacaoMap());
        }
    }


}
