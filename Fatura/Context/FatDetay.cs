//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fatura.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class FatDetay
    {
        public int FatNo { get; set; }
        public int UrunId { get; set; }
        public Nullable<int> Miktar { get; set; }
        public Nullable<decimal> Bfiyat { get; set; }
    
        public virtual FatMaster FatMaster { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
