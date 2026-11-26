using System.CommandLine;
using System.CommandLine.Help;
using System.Reflection;

namespace WindowsKioskTestApp;

struct CommandLineArguments
{
    public string? LogPath;

    internal static CommandLineArguments Parse(string[] args)
    {
        // TODO this is added by default. besides --version! we "just" need to replace the output with a string builder!
        var helpOption = new HelpOption();

        var logPathOption = new Option<string?>("--log-path")
        {
            Description = "Path where log files should be written. If not provided, file logging is disabled.",
        };

        var description = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>()?.Title ?? "";

        var rootCommand = new RootCommand(description)
        {
            helpOption,
            logPathOption,
        };

        var result = rootCommand.Parse(args);

        if (result.Errors.Count > 0)
        {
            // TODO show/throw errors.
        }

        return new CommandLineArguments
        {
            LogPath = result.GetValue(logPathOption),
        };
    }
}
