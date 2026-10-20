using System.ComponentModel.DataAnnotations;

namespace CustomerService.Dtos;

public record CustomerCreateDto(
  [Required] string FirstName,
  [Required] string LastName,
  [EmailAddress] string Email,
  [Phone] string Phone
);