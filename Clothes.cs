using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fashion.Data
{
    public class Clothes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CID { get; set; }
        public int Csize { get; set; }
        public string Ctype { get; set; }
        public string CName { get; set; }

        // foreign key connects stores table
        public int SHID { get; set; }
        [ForeignKey("SHID")]
        public string ShoesID { get; set; }
        // foreign key connects shoes table
        public int SID { get; set; }
        [ForeignKey("SID")]
        public string StoreID { get; set; }
    }
}
