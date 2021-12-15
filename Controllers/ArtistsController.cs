using artistsMc.Models;
using artistsMc.Services;
using Microsoft.AspNetCore.Mvc;

namespace artistsMc.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ArtistsController : ControllerBase
  {
    private readonly ArtistsService _ars;
    public ArtistsController(ArtistsService ars)
    {
      _ars = ars;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Artist>> Get()
    {
      try
      {
        List<Artist> artists = _ars.Get();
        return Ok(artists);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}