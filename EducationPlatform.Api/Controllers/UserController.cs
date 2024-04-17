using EducationPlatform.Application.Models.InputModels;
using EducationPlatform.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _services;

    public UserController(IUserService service)
    {
        _services = service;
    }

    [HttpGet("get-all")]
    public async Task<IActionResult> GetAll()
    {
        var users = await _services.GetAll();

        return Ok(users);
    }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _services.GetById(id);

        if (result.IsFailure)
        {
            return BadRequest(result.Error);
        }

        return Ok(result.Value);
    }

    [HttpPost("create")]
    public async Task<IActionResult> Post(UserInputModel model)
    {
        var result = await _services.CreateUser(model);

        if (result.IsFailure)
        {
            return BadRequest(result.Error);
        }

        return CreatedAtAction(
            nameof(GetById),
            new { id = result.Value },
            model);
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> Put(Guid id, UserInputModel model)
    {
        var result = await _services.UpdateUser(model, id);

        if (result.IsFailure)
        {
            return BadRequest(result.Error);
        }

        return Ok();
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _services.Deleteuser(id);

        if (result.IsFailure)
        {
            return BadRequest(result.Error);
        }

        return Ok();
    }
}
