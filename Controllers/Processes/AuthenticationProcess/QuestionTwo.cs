namespace Xrocter.Controllers.Processes.AuthenticationProcess
{
    // QuestionTwo class inherits from RecoveryAssistant.
    // It represents a second specific security question for password recovery.
    public class QuestionTwo : RecoveryAssistant
    {
        // Constructor for QuestionTwo.
        // It takes a security question and its corresponding answer, then passes them to the base class.
        public QuestionTwo(string question, string answer) : base(question, answer) {}

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
