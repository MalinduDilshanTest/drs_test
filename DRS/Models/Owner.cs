using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DRS.Models
{
    public class Owner
    {
        public int owner_id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is Required")]
        public string owner_firstname { get; set; }
        [Display(Name = "Middle Name")]
        public string owner_middlename { get; set; }
        [Display(Name = "Last Name")]
        public string owner_lastname { get; set; }
        [Display(Name = "NIC no")]
        [Required(ErrorMessage = "NIC no is Required")]
        public string owner_nic { get; set; }
        [Display(Name = "Resident Address")]
        [Required(ErrorMessage = "Address is Required")]
        public string owner_address { get; set; }
        [Display(Name = "Telephone no")]
        [Required(ErrorMessage = "Telephone no is Required")]
        public string owner_tele { get; set; }
        public DateTime owner_created_date { get; set; }
        public string owner_created_by { get; set; }
        public DateTime owner_last_modified_date { get; set; }
        public string owner_last_modified_by { get; set; }
        public int owner_status { get; set; }
    }
}