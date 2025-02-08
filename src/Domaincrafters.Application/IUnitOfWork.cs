namespace Domaincrafters.Application;

/// <summary>
/// Defines a unit of work, which is a set of operations that should be performed as a single transaction.
/// </summary>
public interface IUnitOfWork
{
    /// <summary>
    /// Executes the specified action within a transaction.
    /// </summary>
    /// <param name="action">The action to execute within the transaction. If null, the transaction is simply started and can be completed later.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    public Task Do(Func<Task>? action = null);
}