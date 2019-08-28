using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class EvidencijaRadnogVremena
    {
        public int Id { get; set; }
        public int UposlenikId { get; set; }
        public int? Mjesec { get; set; }
        public int? Godina { get; set; }
        public DateTime? Datum { get; set; }
        public TimeSpan? PocetakRada { get; set; }
        public TimeSpan? ZavrsetakRada { get; set; }
        public TimeSpan? PrekidRada { get; set; }
        public TimeSpan? UkupnoRadnoVrijeme { get; set; }
        public TimeSpan? VrijemeTerenskogRada { get; set; }
        public TimeSpan? VrijemePripravnosti { get; set; }
        public string VrNeprisustvaNaPoslu { get; set; }
        public TimeSpan? OsPodOradVremenu { get; set; }
        public TimeSpan? UkupnoRadnihSati { get; set; }
    }
}
