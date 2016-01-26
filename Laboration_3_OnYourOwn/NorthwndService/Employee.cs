using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NorthwndService
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        [Required(ErrorMessage = "Only digits")]
        public int EmployeeID { get; set; }

        [DataMember]
        [Required]
        [MinLength(2, ErrorMessage = "Firstname have to be at least two characters")]
        public string FirstName { get; set; }

        [DataMember]
        [MinLength(2, ErrorMessage = "Lastname have to be at least two characters")]
        public string LastName { get; set; }

        [DataMember]
        [Required]
        public string Title { get; set; }

        [DataMember]
        [Required]
        public string Country { get; set; }
    }
}