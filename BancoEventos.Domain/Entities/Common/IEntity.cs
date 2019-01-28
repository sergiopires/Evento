using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEventos.Domain.Entities.Common
{
    public abstract class IEntity<TId>
       where TId : IEquatable<TId>
    {
        public TId Codigo { get; set; }
    }
}
