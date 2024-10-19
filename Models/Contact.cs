using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactManagerT1.Models
{
    public class Contact
    {
        // Primary Key for the Contact table in the database
        public int Id { get; set; }

        // First name of the contact, marked as required (cannot be empty)
        [Required]  // Ensures this field must have a value when creating or editing a contact
        [Display(Name = "First Name")]  // Custom label for displaying the field in views
        public string FirstName { get; set; }

        // Last name of the contact, marked as required (cannot be empty)
        [Required]  // Ensures this field must have a value
        [Display(Name = "Last Name")]  // Custom label for displaying the field in views
        public string LastName { get; set; }

        // Phone number for the contact, marked as required and validated for phone format
        [Required]  // Ensures this field must have a value
        [Phone]  // Ensures the value must be a valid phone number format
        public string Phone { get; set; }

        // Email address for the contact, marked as required and validated for email format
        [Required]  // Ensures this field must have a value
        [EmailAddress]  // Ensures the value must be a valid email address format
        public string Email { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid category.")]
        public int? CategoryId { get; set; }

        public Category? Category { get; set; }

        // Organization field is optional, and will store the organization the contact works for
        public string Organization { get; set; }

        public string Slug =>
        FirstName?.Replace(' ', '-').ToLower() + '-' + LastName?.Replace(' ', '-').ToLower();
    }
}
