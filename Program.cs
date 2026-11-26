using Serilog;
using Serilog.Events;

namespace WindowsKioskTestApp;

static partial class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        var arguments = CommandLineArguments.Parse(args);

        SetupLogging(arguments.LogPath);

        try
        {
            Log.Information("Application starting up");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.ThreadException += (sender, e) =>
            {
                try
                {
                    Log.Error(e.Exception, "Unhandled thread exception");
                    MessageBox.Show(
                        e.Exception.Message,
                        $"{Application.ProductName} unhandled thread exception",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                try
                {
                    if (e.ExceptionObject is Exception ex)
                    {
                        Log.Fatal(ex, "Unhandled AppDomain exception");
                        MessageBox.Show(
                            $"A fatal error occurred: {ex.Message}",
                            $"{Application.ProductName} unhandled app domain exception",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                    }
                }
                finally
                {
                    Application.Exit();
                }
            };

            Application.Run(new MainForm());
        }
        catch (Exception ex)
        {
            try
            {
                Log.Fatal(ex, "Application failed to start");
                MessageBox.Show(
                    ex.Message,
                    $"{Application.ProductName} failed to start",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            finally
            {
                Application.Exit();
            }
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }

    static void SetupLogging(string? logPath)
    {
        if (string.IsNullOrEmpty(logPath))
        {
            return;
        }

        var loggerConfiguration = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .MinimumLevel.Override("System", LogEventLevel.Warning)
            .Enrich.FromLogContext()
            .Enrich.WithProperty("Application", Application.ProductName)
            .Enrich.WithProperty("ApplicationVersion", Application.ProductVersion)
            .Enrich.WithProperty("MachineName", Environment.MachineName)
            .Enrich.WithProperty("ProcessId", Environment.ProcessId)
            .WriteTo.Debug();

        var logDirectoryPath = Path.GetDirectoryName(logPath);

        if (!string.IsNullOrEmpty(logDirectoryPath) && !Directory.Exists(logDirectoryPath))
        {
            Directory.CreateDirectory(logDirectoryPath);
        }

        loggerConfiguration = loggerConfiguration.WriteTo.File(
            path: logPath,
            rollingInterval: RollingInterval.Day,
            rollOnFileSizeLimit: true,
            fileSizeLimitBytes: 10 * 1024 * 1024,   // 10 MB
            retainedFileCountLimit: 3,
            outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
        );

        Log.Logger = loggerConfiguration.CreateLogger();
    }
}