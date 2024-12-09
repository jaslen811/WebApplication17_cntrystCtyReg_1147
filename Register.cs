using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication17_cntrystCtyReg_1147.Models
{
    public class Register
    {
        public int Id { get; set; }
        [Required]
        public  string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public Gendertype Gender { get; set; }
        [Required]
        public Boolean IsSubsscribe { get; set; }
        [Display(Name="City")]
        public int CityId { get; set; }
        public City City { get; set; }
        public string Email { get; set; }
        [NotMapped]
        [Display(Name ="Country")]
        public int CountryId { get; set; }
        [NotMapped]
        [Display(Name = "state")]

        public int StateId { get; set; }
    }
}