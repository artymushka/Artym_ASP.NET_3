namespace WebApplication1
{ 
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class TimeController : ControllerBase
{
    private readonly IService _timeOfDayService;

    public TimeController(IService timeOfDayService)
    {
        _timeOfDayService = timeOfDayService;
    }

    [HttpGet]
    public ActionResult<string> GetTimeOfDay()
    {
        var timeOfDay = _timeOfDayService.GetTimeOfDay();
        return Ok(timeOfDay);
    }
}

}
