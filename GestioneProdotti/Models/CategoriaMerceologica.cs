//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestioneProdotti.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CategoriaMerceologica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CategoriaMerceologica()
        {
            this.Prodotto = new HashSet<Prodotto>();
        }
    
        public string Codice { get; set; }
        public string Descrizione { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prodotto> Prodotto { get; set; }
    }
}
