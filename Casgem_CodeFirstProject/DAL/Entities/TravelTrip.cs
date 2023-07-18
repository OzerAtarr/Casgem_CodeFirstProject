using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class TravelTrip
    {
        [Key]
        public int TravelTripID { get; set; }
        public string TravelTripName { get; set; }
    }
}