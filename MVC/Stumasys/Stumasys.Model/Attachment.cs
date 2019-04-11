namespace Stumasys.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Data.Entity;

    [Table("Attachment")]
    public partial class Attachment
    {
        //public Attachment()
        //{
        //    Person = new Person();
        //}

        public int AttachmentID { get; set; }

        public int PersonID { get; set; }

        [Required]
        [StringLength(100)]
        public string FileName { get; set; }

        public virtual Person Person { get; set; }

    }
}
