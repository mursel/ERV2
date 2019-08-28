using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Uposlenici
    {
        public Uposlenici()
        {
            Izlaznice = new HashSet<Izlaznice>();
        }

        public int Id { get; set; }
        public int KompanijaId { get; set; }
        public int SektorId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public bool? IsIzdavac { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsZastitar { get; set; }
        public bool? IsUposlenik { get; set; }
        public bool? IsSefSluzbe { get; set; }
        public bool? IsDirektor { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual Kompanije Kompanija { get; set; }
        public virtual Sektori Sektor { get; set; }
        public virtual ICollection<Izlaznice> Izlaznice { get; set; }
    }
}
