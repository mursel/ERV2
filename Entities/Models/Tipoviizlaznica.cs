using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tipoviizlaznica
    {
        public Tipoviizlaznica()
        {
            Izlaznice = new HashSet<Izlaznice>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Izlaznice> Izlaznice { get; set; }
    }
}
