using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrackingWebSite.Models
{
    public class ViewLogin
    {
        [DisplayName("Username")]
        [DataType(DataType.Text)]
        [Required]
        public string Username { get; set; }
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
    }
}