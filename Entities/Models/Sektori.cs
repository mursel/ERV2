using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Sektori
    {
        public Sektori()
        {
            Uposlenici = new HashSet<Uposlenici>();
        }

        public int Id { get; set; }
        public int KompanijaId { get; set; }
        public string Naziv { get; set; }

        public virtual Kompanije Kompanija { get; set; }
        public virtual ICollection<Uposlenici> Uposlenici { get; set; }
    }
}
