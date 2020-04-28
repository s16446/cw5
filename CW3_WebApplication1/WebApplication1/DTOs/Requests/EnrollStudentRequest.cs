using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DTOs.Requests
{
    public class EnrollStudentRequest
    {
        [Required(ErrorMessage = "Musisz podać IndexNumber")]
        public string IndexNumber { get; set; }
        
        [Required(ErrorMessage ="Musisz podać imię")]
        [MaxLength(200)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Musisz podać nazwisko")]
        [MaxLength(200)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Musisz podać datę urodzenia")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Studies { get; set; }
 
    }
}
