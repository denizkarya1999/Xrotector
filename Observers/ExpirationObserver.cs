using System;

namespace Xrocter.Services.PasswordManagement
{
    // Observer that monitors changes related to password expiration.
    public class ExpirationObserver : IObserver<string>
    {
        private ConcreteSubject<string> _subject;
        private string _name;

        // Constructor to attach this observer to a subject.
        public ExpirationObserver(ConcreteSubject<string> subject, string name)
        {
            _subject = subject;
            _name = name;
            _subject.Attach(this);
        }

        // Update method called when the observed subject changes its state.
        public void Update(string state)
        {
            Console.WriteLine($"{_name}: ExpirationObserver - State has changed to {state}");
            // Additional logic for expiration tracking can be implemented here.
        }
    }
}
