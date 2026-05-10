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
        customCommandTextBox = new TextBox();
        startLabel = new Label();
        exitLabel = new Label();
        customCommandHelpPictureBox = new PictureBox();
        customCommandHelpLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)customCommandHelpPictureBox).BeginInit();
        SuspendLayout();
        // 
        // exitRestartShellButton
        // 
        exitRestartShellButton.Location = new Point(57, 115);
        exitRestartShellButton.Name = "exitRestartShellButton";
        exitRestartShellButton.Size = new Size(115, 33);
        exitRestartShellButton.TabIndex = 9;
        exitRestartShellButton.Text = "0 (restart the shell)";
        exitRestartShellButton.UseVisualStyleBackColor = true;
        exitRestartShellButton.Click += ExitRestartShellButton_Click;
        // 
        // exitRestartDeviceButton
        // 
        exitRestartDeviceButton.Location = new Point(442, 115);
        exitRestartDeviceButton.Name = "exitRestartDeviceButton";
        exitRestartDeviceButton.Size = new Size(131, 33);
        exitRestartDeviceButton.TabIndex = 12;
        exitRestartDeviceButton.Text = "-1 (restart the device)";
        exitRestartDeviceButton.UseVisualStyleBackColor = true;
        exitRestartDeviceButton.Click += ExitRestartDeviceButton_Click;
        // 
        // exitShutdownDeviceButton
        // 
        exitShutdownDeviceButton.Location = new Point(279, 115);
        exitShutdownDeviceButton.Name = "exitShutdownDeviceButton";
        exitShutdownDeviceButton.Size = new Size(157, 33);
        exitShutdownDeviceButton.TabIndex = 11;
        exitShutdownDeviceButton.Text = "255 (shut down the device)";
        exitShutdownDeviceButton.UseVisualStyleBackColor = true;
        exitShutdownDeviceButton.Click += ExitShutdownDeviceButton_Click;
        // 
        // exitDoNothingButton
        // 
        exitDoNothingButton.Location = new Point(178, 115);
        exitDoNothingButton.Name = "exitDoNothingButton";
        exitDoNothingButton.Size = new Size(97, 33);
        exitDoNothingButton.TabIndex = 10;
        exitDoNothingButton.Text = "1 (do nothing)";
        exitDoNothingButton.UseVisualStyleBackColor = true;
        exitDoNothingButton.Click += ExitDoNothingButton_Click;
        // 
        // startCalculatorButton
        // 
        startCalculatorButton.Location = new Point(58, 18);
        startCalculatorButton.Name = "startCalculatorButton";
        startCalculatorButton.Size = new Size(73, 33);
        startCalculatorButton.TabIndex = 1;
        startCalculatorButton.Text = "Calculator";
        startCalculatorButton.UseVisualStyleBackColor = true;
        startCalculatorButton.Click += StartCalculatorButton_Click;
        // 
        // startCommandPromptButton
        // 
        startCommandPromptButton.Location = new Point(409, 18);
        startCommandPromptButton.Name = "startCommandPromptButton";
        startCommandPromptButton.Size = new Size(126, 33);
        startCommandPromptButton.TabIndex = 5;
        startCommandPromptButton.Text = "Command Prompt";
        startCommandPromptButton.UseVisualStyleBackColor = true;
        startCommandPromptButton.Click += StartCommandPromptButton_Click;
        // 
        // startWindowsPowerShellButton
        // 
        startWindowsPowerShellButton.Location = new Point(541, 18);
        startWindowsPowerShellButton.Name = "startWindowsPowerShellButton";
        startWindowsPowerShellButton.Size = new Size(135, 33);
        startWindowsPowerShellButton.TabIndex = 6;
        startWindowsPowerShellButton.Text = "Windows PowerShell";
        startWindowsPowerShellButton.UseVisualStyleBackColor = true;
        startWindowsPowerShellButton.Click += StartWindowsPowerShellButton_Click;
        // 
        // startPowerShellButton
        // 
        startPowerShellButton.Location = new Point(330, 18);
        startPowerShellButton.Name = "startPowerShellButton";
        startPowerShellButton.Size = new Size(73, 33);
        startPowerShellButton.TabIndex = 4;
        startPowerShellButton.Text = "PowerShell";
        startPowerShellButton.UseVisualStyleBackColor = true;
        startPowerShellButton.Click += StartPowerShellButton_Click;
        // 
        // startRegistryEditorButton
        // 
        startRegistryEditorButton.Location = new Point(137, 18);
        startRegistryEditorButton.Name = "startRegistryEditorButton";
        startRegistryEditorButton.Size = new Size(98, 33);
        startRegistryEditorButton.TabIndex = 2;
        startRegistryEditorButton.Text = "Registry Editor";
        startRegistryEditorButton.UseVisualStyleBackColor = true;
        startRegistryEditorButton.Click += StartRegistryEditorButton_Click;
        // 
        // startFileExplorerButton
        // 
        startFileExplorerButton.Location = new Point(241, 18);
        startFileExplorerButton.Name = "startFileExplorerButton";
        startFileExplorerButton.Size = new Size(83, 33);
        startFileExplorerButton.TabIndex = 3;
        startFileExplorerButton.Text = "File Explorer";
        startFileExplorerButton.UseVisualStyleBackColor = true;
        startFileExplorerButton.Click += StartFileExplorerButton_Click;
        // 
        // customCommandTextBox
        // 
        customCommandTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        customCommandTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        customCommandTextBox.Location = new Point(58, 57);
        customCommandTextBox.Name = "customCommandTextBox";
        customCommandTextBox.PlaceholderText = "Custom Command Command Line";
        customCommandTextBox.Size = new Size(618, 26);
        customCommandTextBox.TabIndex = 7;
        customCommandTextBox.PreviewKeyDown += CustomCommandTextBox_PreviewKeyDown;
        // 
        // startLabel
        // 
        startLabel.AutoSize = true;
        startLabel.Location = new Point(12, 25);
        startLabel.Name = "startLabel";
        startLabel.Size = new Size(34, 15);
        startLabel.TabIndex = 0;
        startLabel.Text = "Start:";
        // 
        // exitLabel
        // 
        exitLabel.AutoSize = true;
        exitLabel.Location = new Point(11, 124);
        exitLabel.Name = "exitLabel";
        exitLabel.Size = new Size(28, 15);
        exitLabel.TabIndex = 8;
        exitLabel.Text = "Exit:";
        // 
        // customCommandHelpPictureBox
        // 
        customCommandHelpPictureBox.Location = new Point(58, 85);
        customCommandHelpPictureBox.Name = "customCommandHelpPictureBox";
        customCommandHelpPictureBox.Size = new Size(21, 24);
        customCommandHelpPictureBox.TabIndex = 13;
        customCommandHelpPictureBox.TabStop = false;
        // 
        // customCommandHelpLabel
        // 
        customCommandHelpLabel.AutoSize = true;
        customCommandHelpLabel.Location = new Point(85, 86);
        customCommandHelpLabel.Name = "customCommandHelpLabel";
        customCommandHelpLabel.Size = new Size(468, 15);
        customCommandHelpLabel.TabIndex = 14;
        customCommandHelpLabel.Text = "Press Enter to execute with CreateProcess. Press Ctrl+Enter to execute with ShellExecute.";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(695, 199);
        Controls.Add(customCommandHelpLabel);
        Controls.Add(customCommandHelpPictureBox);
        Controls.Add(exitLabel);
        Controls.Add(startLabel);
        Controls.Add(customCommandTextBox);
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
        ((System.ComponentModel.ISupportInitialize)customCommandHelpPictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
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
    private TextBox customCommandTextBox;
    private Label startLabel;
    private Label exitLabel;
    private PictureBox customCommandHelpPictureBox;
    private Label customCommandHelpLabel;
}
