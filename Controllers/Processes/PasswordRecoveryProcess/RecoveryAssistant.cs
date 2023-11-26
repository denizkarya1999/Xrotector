using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Xrocter.Controllers.Processes.PasswordRecoveryProcess
{
    // Abstract class RecoveryAssistant serves as a base for implementing password recovery mechanisms.
    public abstract class RecoveryAssistant
    {
        // Public property to store the security question.
        public string Question { get; private set; }

        // Protected property to store the hashed version of the answer.
        protected string AnswerHash { get; private set; }

        // Constructor for the RecoveryAssistant class.
        // It takes a security question and its corresponding answer, then hashes the answer.
        protected RecoveryAssistant(string question, string answer)
        {
            Question = question;
            AnswerHash = HashAnswer(answer);
        }

        // Method to validate a provided answer against the stored hashed answer.
        // Returns true if the hash of the provided answer matches the stored hash.
        protected bool ValidateAnswer(string providedAnswer)
        {
            return HashAnswer(providedAnswer) == AnswerHash;
        }

        // Abstract method that must be implemented in derived classes.
        // It defines how password recovery is handled when a user provides an answer.
        public abstract Task<bool> RecoverPasswordAsync(string providedAnswer);

        // Private method to hash an answer using SHA256.
        // Converts the answer string to a byte array, hashes it, and returns the hash as a hex string.
        private string HashAnswer(string answer)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(answer));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLowerInvariant();
            }
        }
    }
}
