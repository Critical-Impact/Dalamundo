namespace Dalamud.Game.Command;

/// <summary>
/// This class describes a registered command.
/// </summary>
internal sealed class CommandInfo : ICommandInfo
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CommandInfo"/> class.
    /// Create a new CommandInfo with the provided handler.
    /// </summary>
    /// <param name="handler">The method to call when the command is run.</param>
    public CommandInfo(ICommandInfo.HandlerDelegate handler)
    {
        this.Handler = handler;
    }

    /// <inheritdoc/>
    public ICommandInfo.HandlerDelegate Handler { get; }

    /// <inheritdoc/>
    public string HelpMessage { get; set; } = string.Empty;

    /// <inheritdoc/>
    public bool ShowInHelp { get; set; } = true;
}

/// <summary>
/// Interface representing a registered command.
/// </summary>
public interface ICommandInfo
{
    /// <summary>
    /// The function to be executed when the command is dispatched.
    /// </summary>
    /// <param name="command">The command itself.</param>
    /// <param name="arguments">The arguments supplied to the command, ready for parsing.</param>
    public delegate void HandlerDelegate(string command, string arguments);
    
    /// <summary>
    /// Gets a <see cref="HandlerDelegate"/> which will be called when the command is dispatched.
    /// </summary>
    HandlerDelegate Handler { get; }

    /// <summary>
    /// Gets or sets the help message for this command.
    /// </summary>
    string HelpMessage { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether if this command should be shown in the help output.
    /// </summary>
    bool ShowInHelp { get; set; }
}
