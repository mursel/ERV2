using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Kompanije
    {
        public Kompanije()
        {
            Sektori = new HashSet<Sektori>();
            Uposlenici = new HashSet<Uposlenici>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Sektori> Sektori { get; set; }
        public virtual ICollection<Uposlenici> Uposlenici { get; set; }
    }
}
