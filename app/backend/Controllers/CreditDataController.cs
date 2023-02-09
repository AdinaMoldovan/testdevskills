using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("credit-data")]
    public class CreditDataController : Controller
    {
        [HttpGet]
        [Route("{ssn}")]
        public object Get(string ssn)
        {
            return new
            {
                first_name = "Emma",
                last_name= "Gautrey",
                address= "09 Westend Terrace",
                assessed_income= 60668,
                complaints= true
            };
        }
    }
}
