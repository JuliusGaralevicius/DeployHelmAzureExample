using Microsoft.AspNetCore.Mvc;

namespace AzureTest.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResponseController : ControllerBase
    {

        public ResponseController()
        {
        }

        [HttpGet(Name = "Chatas")]
        public IActionResult Chatas()
        {
            return Ok(AnswersDatabase.Answers.OrderByDescending(x=>x.CreatedAt));
        }

        [HttpGet(Name = "TotalAnswers")]
        [Route("Total")]
        public IActionResult TotalAnswers()
        {
            return Ok(AnswersDatabase.Answers.Count);
        }

        [HttpPost(Name = "Atsakymas")]
        public IActionResult Atsakymas(PostAnswerRequest request)
        {
            AnswersDatabase.Answers.Add(new Answer { CreatedAt = DateTimeOffset.UtcNow, Text = request.Answer });
            return Ok();
        }
    }
}