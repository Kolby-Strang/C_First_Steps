namespace C_First_Steps.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ComputersController : ControllerBase
{
    private readonly ComputersService _service;

    public ComputersController(ComputersService service) => _service = service;

    [HttpGet]
    public ActionResult<List<Computer>> GetComputers()
    {
        try
        {
            List<Computer> computers = _service.GetComputers();
            return Ok(computers);
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }

    [HttpGet("{computerId}")]
    public ActionResult<Computer> GetComputerById(int computerId)
    {
        try
        {
            Computer computer = _service.GetComputerById(computerId);
            return Ok(computer);
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }
    [HttpPost]
    public ActionResult<Computer> CreateComputer([FromBody] Computer computerData)
    {
        try
        {
            Computer computer = _service.CreateComputer(computerData);
            return Ok(computer);
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }

    [HttpDelete("{computerId}")]
    public ActionResult<string> DeleteComputer(int computerId)
    {
        try
        {
            string message = _service.DeleteComputer(computerId);
            return Ok(message);
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }
}