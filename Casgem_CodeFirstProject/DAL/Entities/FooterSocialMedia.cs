using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class FooterSocialMedia
    {
        [Key]
        public int FooterSocialMediaID { get; set; }
        public string FooterSocialMediaName { get; set; }
        public string FooterSocialMediaUrl { get; set; }
        public string FooterSocialMediaIcon { get; set; }
    }
}