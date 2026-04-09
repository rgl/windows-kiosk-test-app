namespace WindowsKioskTestApp;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        exitRestartShellButton = new Button();
        exitRestartDeviceButton = new Button();
        exitShutdownDeviceButton = new Button();
        exitDoNothingButton = new Button();
        startCalculatorButton = new Button();
        startCommandPromptButton = new Button();
        startWindowsPowerShellButton = new Button();
        startPowerShellButton = new Button();
        startRegistryEditorButton = new Button();
        startFileExplorerButton = new Button();
        SuspendLayout();
        //
        // exitRestartShellButton
        //
        exitRestartShellButton.Location = new Point(12, 12);
        exitRestartShellButton.Name = "exitRestartShellButton";
        exitRestartShellButton.Size = new Size(212, 33);
        exitRestartShellButton.TabIndex = 0;
        exitRestartShellButton.Text = "Exit 0 (restart the shell)";
        exitRestartShellButton.UseVisualStyleBackColor = true;
        exitRestartShellButton.Click += ExitRestartShellButton_Click;
        //
        // exitRestartDeviceButton
        //
        exitRestartDeviceButton.Location = new Point(12, 129);
        exitRestartDeviceButton.Name = "exitRestartDeviceButton";
        exitRestartDeviceButton.Size = new Size(212, 33);
        exitRestartDeviceButton.TabIndex = 3;
        exitRestartDeviceButton.Text = "Exit -1 (restart the device)";
        exitRestartDeviceButton.UseVisualStyleBackColor = true;
        exitRestartDeviceButton.Click += ExitRestartDeviceButton_Click;
        //
        // exitShutdownDeviceButton
        //
        exitShutdownDeviceButton.Location = new Point(12, 90);
        exitShutdownDeviceButton.Name = "exitShutdownDeviceButton";
        exitShutdownDeviceButton.Size = new Size(212, 33);
        exitShutdownDeviceButton.TabIndex = 2;
        exitShutdownDeviceButton.Text = "Exit 255 (shut down the device)";
        exitShutdownDeviceButton.UseVisualStyleBackColor = true;
        exitShutdownDeviceButton.Click += ExitShutdownDeviceButton_Click;
        //
        // exitDoNothingButton
        //
        exitDoNothingButton.Location = new Point(12, 51);
        exitDoNothingButton.Name = "exitDoNothingButton";
        exitDoNothingButton.Size = new Size(212, 33);
        exitDoNothingButton.TabIndex = 1;
        exitDoNothingButton.Text = "Exit 1 (do nothing)";
        exitDoNothingButton.UseVisualStyleBackColor = true;
        exitDoNothingButton.Click += ExitDoNothingButton_Click;
        //
        // startCalculatorButton
        //
        startCalculatorButton.Location = new Point(12, 181);
        startCalculatorButton.Name = "startCalculatorButton";
        startCalculatorButton.Size = new Size(212, 33);
        startCalculatorButton.TabIndex = 4;
        startCalculatorButton.Text = "Start Calculator";
        startCalculatorButton.UseVisualStyleBackColor = true;
        startCalculatorButton.Click += StartCalculatorButton_Click;
        //
        // startCommandPromptButton
        //
        startCommandPromptButton.Location = new Point(12, 220);
        startCommandPromptButton.Name = "startCommandPromptButton";
        startCommandPromptButton.Size = new Size(212, 33);
        startCommandPromptButton.TabIndex = 5;
        startCommandPromptButton.Text = "Start Command Prompt";
        startCommandPromptButton.UseVisualStyleBackColor = true;
        startCommandPromptButton.Click += StartCommandPromptButton_Click;
        //
        // startWindowsPowerShellButton
        //
        startWindowsPowerShellButton.Location = new Point(12, 259);
        startWindowsPowerShellButton.Name = "startWindowsPowerShellButton";
        startWindowsPowerShellButton.Size = new Size(212, 33);
        startWindowsPowerShellButton.TabIndex = 6;
        startWindowsPowerShellButton.Text = "Start Windows PowerShell";
        startWindowsPowerShellButton.UseVisualStyleBackColor = true;
        startWindowsPowerShellButton.Click += StartWindowsPowerShellButton_Click;
        //
        // startPowerShellButton
        //
        startPowerShellButton.Location = new Point(12, 298);
        startPowerShellButton.Name = "startPowerShellButton";
        startPowerShellButton.Size = new Size(212, 33);
        startPowerShellButton.TabIndex = 7;
        startPowerShellButton.Text = "Start PowerShell";
        startPowerShellButton.UseVisualStyleBackColor = true;
        startPowerShellButton.Click += StartPowerShellButton_Click;
        //
        // startRegistryEditorButton
        //
        startRegistryEditorButton.Location = new Point(12, 337);
        startRegistryEditorButton.Name = "startRegistryEditorButton";
        startRegistryEditorButton.Size = new Size(212, 33);
        startRegistryEditorButton.TabIndex = 8;
        startRegistryEditorButton.Text = "Start Registry Editor";
        startRegistryEditorButton.UseVisualStyleBackColor = true;
        startRegistryEditorButton.Click += StartRegistryEditorButton_Click;
        //
        // startFileExplorerButton
        //
        startFileExplorerButton.Location = new Point(12, 376);
        startFileExplorerButton.Name = "startFileExplorerButton";
        startFileExplorerButton.Size = new Size(212, 33);
        startFileExplorerButton.TabIndex = 9;
        startFileExplorerButton.Text = "Start File Explorer";
        startFileExplorerButton.UseVisualStyleBackColor = true;
        startFileExplorerButton.Click += StartFileExplorerButton_Click;
        //
        // MainForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(startFileExplorerButton);
        Controls.Add(startRegistryEditorButton);
        Controls.Add(startPowerShellButton);
        Controls.Add(startWindowsPowerShellButton);
        Controls.Add(startCommandPromptButton);
        Controls.Add(startCalculatorButton);
        Controls.Add(exitDoNothingButton);
        Controls.Add(exitShutdownDeviceButton);
        Controls.Add(exitRestartDeviceButton);
        Controls.Add(exitRestartShellButton);
        Name = "MainForm";
        Text = "Windows Kiosk Test App";
        ResumeLayout(false);
    }

    #endregion

    private Button exitRestartShellButton;
    private Button exitRestartDeviceButton;
    private Button exitShutdownDeviceButton;
    private Button exitDoNothingButton;
    private Button startCalculatorButton;
    private Button startCommandPromptButton;
    private Button startWindowsPowerShellButton;
    private Button startPowerShellButton;
    private Button startRegistryEditorButton;
    private Button startFileExplorerButton;
}
