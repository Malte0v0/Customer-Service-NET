using CustomerService.Dtos;
using CustomerService.Models;

namespace CustomerService.Services;

public class CustomerManager {
  private readonly List<Customer> _customers = new();
  private long _nextId = 1;

  private CustomerResponseDto ToResponse(Customer c) {
    return new CustomerResponseDto(c.Id, c.FirstName, c.LastName, c.Email, c.Phone);
  }

  public CustomerResponseDto? FindById(long id) {
    Customer? customer = this._customers.FirstOrDefault(c => c.Id == id);
    if (customer is null) return null;
    return ToResponse(customer);
  }

  public List<CustomerResponseDto> FindAll() {
    return this._customers.Select(ToResponse).ToList();
  }

  public CustomerResponseDto Create(CustomerCreateDto dto) {
    Customer customer = new Customer{
      Id = this._nextId++,
      FirstName = dto.FirstName,
      LastName = dto.LastName,
      Phone = dto.Phone,
      Email = dto.Email,
    };

    _customers.Add(customer);

    return ToResponse(customer);
  }

  public void Delete(long id)
  {
    int result = _customers.RemoveAll(c => c.Id == id);
  }

  public bool EmailExists(string email) {
    Customer? customer = this._customers.FirstOrDefault(c => c.Email == email);
    if (customer is not null){
      return true;
    }

    return false;
  }
}