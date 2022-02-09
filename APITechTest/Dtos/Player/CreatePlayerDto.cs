using System;
using System.ComponentModel.DataAnnotations;

namespace APITechTest.Dtos
{
    public record CreatePlayerDto
    {
        [Required]    // Data annotation that returns 400 error if object required is null
        public string FirstName { get; init; }
        
        [Required]
        public string LastName { get; init; }

        [Required]
        public string Nationality { get; init; }

        [Required]
        public DateTime BirthDate { get; init; }
    }
}