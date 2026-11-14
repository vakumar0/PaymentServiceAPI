using Microsoft.AspNetCore.Mvc;

namespace PaymentServiceAPI.Controllers;

[ApiController]
[Route("api/v1/payment")]
public class PaymentController : ControllerBase
{
    [Route("{userid}")]
    [HttpGet]
    public IActionResult GetPayment([FromRoute] int userid)
    {
        string response = "Payment details of user:" + userid;
        return Ok(response);
    }
}
