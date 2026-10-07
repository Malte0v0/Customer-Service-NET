namespace CustomerService.Models;

public class Customer {
  public long Id { get; set; }
  public required string FirstName { get; set; }
  public required string LastName { get; set; }
  public required string Phone { get; set; }
  public required string Email { get; set; }
}
