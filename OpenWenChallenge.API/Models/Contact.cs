using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OpenWebChallenge.API.Models
{
    public class Contact
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        public string FullName => $"{LastName} {FirstName}";

        [Required]
        [MaxLength(50)]
        public string Address { get; set; }
        [Required]
        [MaxLength(50)]
        public string PostalCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }
        [Required]
        [MaxLength(50)]
        public string Country { get; set; }

        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        public string MobilePhoneNumber { get; set; }

        public ICollection<ContactSkill> ContactSkills { get; set; }
    }
}
