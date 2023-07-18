using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Tour
    {
        [Key]
        public int TourID { get; set; }
        public string Title { get; set; }
        public int AvaliableTour { get; set; }
        public string ImageUrl { get; set; }
    }
}