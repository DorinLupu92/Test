using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Test
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }



        [Required]

        [NotMapped]
        // [RegularExpression(@"^*(.pdf|.PDF)$", ErrorMessage = "Incorrect file format")]
        public HttpPostedFileBase File { get; set; }

        [Required]

        [NotMapped]
        public String PdfPUrl
        {
            get { return ID.ToString() + ".pdf"; }

        }
    }
}