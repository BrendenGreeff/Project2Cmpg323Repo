using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCmpg323.Models
{
    public class ImagesModels
    {
        [Key]
        public int Images_ID { get; set; }
        public string Images_Name { get; set; }
        public byte[] Images_Path { get; set; }
        public string Images_Username { get; set; }

    }
}
