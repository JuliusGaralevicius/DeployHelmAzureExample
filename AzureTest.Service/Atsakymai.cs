namespace AzureTest.Service
{
    public static class AnswersDatabase
    {
        public static List<Answer> Answers { get; set; } = new();
    }

    public class Answer
    {
        public DateTimeOffset CreatedAt { get; set; }
        public string Text { get; set; } = "?";
    }
}
