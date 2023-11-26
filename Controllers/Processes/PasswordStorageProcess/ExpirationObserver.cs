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
            MessageBox.Show("At least one of your items are about to expire or not initialized. Please renew or add your item(s).");
        }

        // Update method called when the observed subject changes its state.
        public void Update(string state)
        {
        }
    }
}
