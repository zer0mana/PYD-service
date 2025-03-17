using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PYD_service_DAL.Models;
using PYD_service_DAL.Repositories.Interfaces;
using PYD_Service.Requests;
using PYD_Service.Responses;

namespace PYD_Service.Controllers;

[ApiController]
[Route("pyd-handler")]
public class PYDHandlerController : ControllerBase
{
    private readonly IPYDRepository _pydRepository;
    
    public PYDHandlerController(
        IPYDRepository pydRepository)
    {
        _pydRepository = pydRepository;
    }
    
    [HttpPost("create-pyd")]
    public async Task<CreatePYDResponse> CreatePYD(CreatePYDRequest request)
    {
        var pydId = await _pydRepository.CreateAsync(
            new PYD
            {
                UserId = 0,
                Name = request.Name,
                Description = request.Description,
                GoalPoints = request.GoalPoints
            },
            CancellationToken.None);

        return new CreatePYDResponse(pydId);
    }
}