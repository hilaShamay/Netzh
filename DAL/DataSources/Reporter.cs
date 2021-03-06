//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.DataSources
{
    using System;
    using System.Collections.Generic;
    /***
     * this class represent the entity reporter
     ***/
    public partial class Reporter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reporter()
        {
            this.Reports = new HashSet<Report>();
        }
    
        public string ReporterName { get; set; }
        public int ReporterID { get; set; }
        public string ReporterAddress { get; set; }
        public string LatLongAddress { get; set; }//the coordinate of address
        public byte[] ReporterProfilePicture { get; set; }//the picture
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Report> Reports { get; set; }//the reports that the reporter send
    }
}
