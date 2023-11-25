using System.Collections.Generic;

namespace Xrocter.Services.PasswordManagement
{
    // Interface for the subject that maintains a list of observers and notifies them.
    public interface ISubject<T>
    {
        // Attach an observer to the subject.
        void Attach(IObserver<T> observer);

        // Detach an observer from the subject.
        void Detach(IObserver<T> observer);

        // Notify all attached observers of a state change.
        void NotifyObservers();
    }
}
