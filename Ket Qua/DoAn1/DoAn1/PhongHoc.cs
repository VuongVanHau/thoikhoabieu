//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn1
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhongHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhongHoc()
        {
            this.ThoiKhoaBieux = new HashSet<ThoiKhoaBieu>();
        }
    
        public int MaPH { get; set; }
        public string TenPH { get; set; }
        public Nullable<int> DungLuong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThoiKhoaBieu> ThoiKhoaBieux { get; set; }
    }
}