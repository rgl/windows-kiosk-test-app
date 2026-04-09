using System.Diagnostics;

namespace WindowsKioskTestApp;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        if (Environment.UserName.Contains("kiosk", StringComparison.InvariantCultureIgnoreCase))
        {
            FormBorderStyle = FormBorderStyle.None;
        }
    }

    // see https://learn.microsoft.com/en-us/windows/configuration/shell-launcher/configure?tabs=powershell1%2Cps#shell-launcher-startup-and-exit-behavior
    private void Exit(int exitCode)
    {
        Environment.ExitCode = exitCode;
        Close();
    }

    private static void Start(string path)
    {
        try
        {
            Process.Start(path);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}");
        }
    }

    private void ExitRestartShellButton_Click(object sender, EventArgs e)
    {
        // 0: Restart the shell.
        Exit(0);
    }

    private void ExitDoNothingButton_Click(object sender, EventArgs e)
    {
        // 1: Do nothing.
        Exit(1);
    }

    private void ExitShutdownDeviceButton_Click(object sender, EventArgs e)
    {
        // 255: Shut down the device.
        Exit(255);
    }

    private void ExitRestartDeviceButton_Click(object sender, EventArgs e)
    {
        // -1: Restart the device.
        Exit(-1);
    }

    private void StartCalculatorButton_Click(object sender, EventArgs e)
    {
        Start("C:\\Windows\\System32\\calc.exe");
    }

    private void StartCommandPromptButton_Click(object sender, EventArgs e)
    {
        Start("C:\\Windows\\System32\\cmd.exe");
    }

    private void StartWindowsPowerShellButton_Click(object sender, EventArgs e)
    {
        Start("C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe");
    }

    private void StartPowerShellButton_Click(object sender, EventArgs e)
    {
        Start("C:\\Program Files\\PowerShell\\7\\pwsh.exe");
    }

    private void StartRegistryEditorButton_Click(object sender, EventArgs e)
    {
        Start("C:\\Windows\\regedit.exe");
    }

    private void StartFileExplorerButton_Click(object sender, EventArgs e)
    {
        Start("C:\\Windows\\explorer.exe");
    }
}
