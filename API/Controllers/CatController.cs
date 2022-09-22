using Domain;
using Microsoft.AspNetCore.Mvc;
using Application;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class CatController : ControllerBase
{
    private CatService _catService;

    public CatController()
    {
        _catService = new CatService();
    }

    [HttpGet]
    [Route("Cats")]
    public ActionResult<List<Cat>> GetCats()
    {
        return Ok(_catService.GetCats());
        
    }
    
    [HttpDelete]
    [Route("Cat")]
    public IActionResult RemoveCat(Cat cat)
    {
        _catService.RemoveCat(cat);
        return Ok();
    }
}