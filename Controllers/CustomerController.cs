using CustomerService.Dtos;
using CustomerService.Services;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Controllers;

[ApiController]
[Route("api/customers")]
public class CustomerController: ControllerBase {
  private readonly CustomerManager _customerManager;

  public CustomerController(CustomerManager customerManager)
  {
    _customerManager = customerManager;
  }

  [HttpGet]
  public ActionResult<List<CustomerResponseDto>> GetAll()
  {
    return _customerManager.FindAll();
  }

  [HttpGet("{id}")]
  public ActionResult<CustomerResponseDto> GetById(long id)
  {
    CustomerResponseDto? customer = _customerManager.FindById(id);

    if (customer is null) return NotFound();

    return Ok(customer);
  }

  [HttpPost]
  public ActionResult<CustomerResponseDto> Create(CustomerCreateDto dto)
  {
    CustomerResponseDto created = _customerManager.Create(dto);
    return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
  }

  [HttpDelete("{id}")]
  public IActionResult Delete(long id)
  {
    bool delete = _customerManager.Delete(id);
    if (!delete)
    {
      return NotFound();
    }
    return NoContent();
  }

  [HttpPut("{id}")]
  public ActionResult<CustomerResponseDto> Update(long id, CustomerCreateDto dto)
  {
    CustomerResponseDto? response = this._customerManager.Update(id, dto);
    if (response is null)
    {
      return NotFound();
    }
    return Ok(response);
  }
}