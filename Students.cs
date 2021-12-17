namespace AdmissionCommittee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Students
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string FIO { get; set; }

        public int id_specialty { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_of_birth { get; set; }

        [Required]
        [StringLength(50)]
        public string age { get; set; }

        public int id_gruppa { get; set; }

        [Required]
        [StringLength(50)]
        public string addres { get; set; }

        [Required]
        [StringLength(50)]
        public string number_phone { get; set; }

        public virtual Gruppa Gruppa { get; set; }

        public virtual Specialty Specialty { get; set; }
    }
}
