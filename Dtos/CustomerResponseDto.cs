namespace CustomerService.Dtos;

public record CustomerResponseDto(long Id, string FirstName, string LastName, string Email, string Phone);