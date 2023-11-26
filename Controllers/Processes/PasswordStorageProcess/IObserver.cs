namespace Xrocter.Services.PasswordManagement
{
    // Interface for all observers that need to be notified by the subject.
    public interface IObserver<T>
    {
        // Update method that gets called when the subject's state changes.
        void Update(T state);
    }
}
