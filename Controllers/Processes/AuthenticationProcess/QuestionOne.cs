namespace Xrocter.Controllers.Processes.AuthenticationProcess
{
    // QuestionOne class inherits from RecoveryAssistant.
    // It represents a specific security question for password recovery.
    public class QuestionOne : RecoveryAssistant
    {
        // Constructor for QuestionOne.
        // It takes a security question and its corresponding answer, then passes them to the base class.
        public QuestionOne(string question, string answer) : base(question, answer) {}

        // Overrides the RecoverPasswordAsync method from the RecoveryAssistant class.
        // This method checks if the provided answer is correct and returns a boolean result.
        public override Task<bool> RecoverPasswordAsync(string providedAnswer)
        {
            // Calls ValidateAnswer from the base class to check if the provided answer is correct.
            // Returns true if the answer is correct, otherwise false.
            return Task.FromResult(ValidateAnswer(providedAnswer));
        }
    }
}
