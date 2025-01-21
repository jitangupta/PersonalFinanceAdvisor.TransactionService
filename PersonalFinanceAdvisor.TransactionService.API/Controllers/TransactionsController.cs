using Microsoft.AspNetCore.Mvc;

namespace PersonalFinanceAdvisor.TransactionService.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Transaction service is up & running");
        }
    }
}
