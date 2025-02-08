namespace Domaincrafters.Application;

/// <summary>
/// Defines an output port that presents the output of a use case.
/// </summary>
/// <typeparam name="Output">The type of the output to present.</typeparam>
public interface IOutputPort<in Output>
{
    /// <summary>
    /// Presents the specified output.
    /// </summary>
    /// <param name="output">The output to present.</param>
    public void Present(Output output);
}