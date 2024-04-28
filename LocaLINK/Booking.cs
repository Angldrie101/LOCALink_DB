//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocaLINK
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            this.BookingDetails = new HashSet<BookingDetails>();
        }
    
        public int booking_id { get; set; }
        public string customer_id { get; set; }
        public Nullable<int> service { get; set; }
        public Nullable<System.DateTime> booking_date { get; set; }
        public string location { get; set; }
        public Nullable<decimal> total_price { get; set; }
        public Nullable<int> status { get; set; }
        public string contact { get; set; }
    
        public virtual Services Services { get; set; }
        public virtual Status Status1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingDetails> BookingDetails { get; set; }
    }
}
