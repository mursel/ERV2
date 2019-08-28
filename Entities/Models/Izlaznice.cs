using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Izlaznice
    {
        public long Id { get; set; }
        public int IzdaoId { get; set; }
        public int TipIzlazniceId { get; set; }
        public int UposlenikId { get; set; }
        public DateTime? VrijemeIzlaska { get; set; }
        public DateTime? VrijemePovratka { get; set; }
        public bool? JeZatvorena { get; set; }
        public string Napomena { get; set; }
        public byte[] Qrcode { get; set; }

        public virtual Tipoviizlaznica TipIzlaznice { get; set; }
        public virtual Uposlenici Uposlenik { get; set; }
    }
}
