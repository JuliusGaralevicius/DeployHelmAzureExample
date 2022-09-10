using Microsoft.AspNetCore.Mvc;

namespace AzureTest.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {

        public ChatController()
        {
        }

        [HttpGet]
        public IActionResult Chatas()
        {
            return Ok(AnswersDatabase.Answers.OrderByDescending(x=>x.CreatedAt));
        }

        [HttpGet]
        [Route("Total")]
        public IActionResult TotalAnswers()
        {
            return Ok(AnswersDatabase.Answers.Count);
        }

        [HttpPost]
        [Route("Answer")]
        public IActionResult Atsakymas(PostAnswerRequest request)
        {
            AnswersDatabase.Answers.Add(new Answer { CreatedAt = DateTimeOffset.UtcNow, Text = request.Answer });
            return Ok();
        }
    }
}