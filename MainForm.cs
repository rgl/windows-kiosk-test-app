using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

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

        var helpIconBitmap = new Bitmap(16, 16);
        using (var g = Graphics.FromImage(helpIconBitmap))
        {
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawIcon(SystemIcons.Information, new Rectangle(0, 0, helpIconBitmap.Size.Width, helpIconBitmap.Size.Height));
        }
        customCommandHelpPictureBox.Image = helpIconBitmap;
        customCommandHelpPictureBox.Size = helpIconBitmap.Size;
    }

    // see https://learn.microsoft.com/en-us/windows/configuration/shell-launcher/configure?tabs=powershell1%2Cps#shell-launcher-startup-and-exit-behavior
    private void Exit(int exitCode)
    {
        Environment.ExitCode = exitCode;
        Close();
    }

    private static void Start(string fileName)
    {
        Start(new ProcessStartInfo(fileName));
    }

    private static void Start(ProcessStartInfo pi)
    {
        var fileName = pi.FileName;

        try
        {
            Process.Start(pi);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to start {fileName}: {ex.Message}", "Failed to start", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    private void CustomCommandTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            var args = SplitCommandLine(customCommandTextBox.Text);

            Start(new ProcessStartInfo(args[0], args.Skip(1)) { UseShellExecute = e.Control });
        }
    }

    [LibraryImport("shell32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    private static partial IntPtr CommandLineToArgvW(string lpCmdLine, out int pNumArgs);

    private static string[] SplitCommandLine(string commandLine)
    {
        IntPtr argv = CommandLineToArgvW(commandLine, out int argc);
        if (argv == IntPtr.Zero)
        {
            throw new Win32Exception();
        }

        try
        {
            var args = new string[argc];
            for (int i = 0; i < argc; i++)
            {
                IntPtr p = Marshal.ReadIntPtr(argv, i * IntPtr.Size);
                args[i] = Marshal.PtrToStringUni(p) ?? "";
            }
            return args;
        }
        finally
        {
            Marshal.FreeHGlobal(argv);
        }
    }
}
