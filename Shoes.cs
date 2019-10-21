using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fashion.Data
{
    public class Shoes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public string SHID { get; set; }
        public int SBrand { get; set; }
        public int  Ssize { get; set; }
        public string Scolor { get; set; }
       

     

        
    }
}
