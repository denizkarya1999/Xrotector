using System.Collections.Generic;

namespace Xrocter.Services.PasswordManagement
{
    // Concrete implementation of the ISubject interface.
    public class ConcreteSubject<T> : ISubject<T>
    {
        private List<IObserver<T>> _observers = new List<IObserver<T>>();
        private T _state;

        // Property representing the state of the subject.
        public T State
        {
            get => _state;
            set
            {
                _state = value;
                NotifyObservers();
            }
        }

        // Attach a new observer to the subject.
        public void Attach(IObserver<T> observer)
        {
            _observers.Add(observer);
            observer.Update(_state); // Initialize observer with current state
        }

        // Detach an observer from the subject.
        public void Detach(IObserver<T> observer)
        {
            _observers.Remove(observer);
        }

        // Notify all observers about the state change.
        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_state);
            }
        }
    }
}
