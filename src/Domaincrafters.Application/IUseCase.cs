namespace Domaincrafters.Application;

/// <summary>
/// Defines a use case that performs a specific action in the application.
/// </summary>
/// <typeparam name="Input">The type of the input to the use case.</typeparam>
/// <typeparam name="Output">The type of the output from the use case.</typeparam>
public interface IUseCase<in Input, out Output>
{
    /// <summary>
    /// Executes the use case with the specified input.
    /// </summary>
    /// <param name="input">The input to the use case.</param>
    /// <returns>The output from the use case.</returns>
    public Output Execute(Input input);
}