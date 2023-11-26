using System;

namespace Xrocter.Services.PasswordManagement
{
    // Observer that reacts to changes in password strength.
    public class PasswordStrengthObserver : IObserver<string>
    {
        private ConcreteSubject<string> _subject;
        private string _name;

        // Constructor to attach this observer to a subject.
        public PasswordStrengthObserver(ConcreteSubject<string> subject, string name)
        {
            _subject = subject;
            _name = name;
            _subject.Attach(this);
            MessageBox.Show("Your password is weak, please create a master password.");
        }

        // Update method called when the observed subject changes its state.
        public void Update(string state)
        {
        }
    }
}
