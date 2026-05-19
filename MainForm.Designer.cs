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
        mainTableLayoutPanel = new TableLayoutPanel();
        exitLabel = new Label();
        customCommandTextBox = new TextBox();
        startFlowLayoutPanel = new FlowLayoutPanel();
        startCalculatorButton = new Button();
        startRegistryEditorButton = new Button();
        startFileExplorerButton = new Button();
        startPowerShellButton = new Button();
        startCommandPromptButton = new Button();
        startWindowsPowerShellButton = new Button();
        startLabel = new Label();
        customCommandHelpFlowLayoutPanel = new FlowLayoutPanel();
        customCommandHelpPictureBox = new PictureBox();
        customCommandHelpLabel = new Label();
        exitFlowLayoutPanel = new FlowLayoutPanel();
        exitRestartShellButton = new Button();
        exitDoNothingButton = new Button();
        exitShutdownDeviceButton = new Button();
        exitRestartDeviceButton = new Button();
        mainTableLayoutPanel.SuspendLayout();
        startFlowLayoutPanel.SuspendLayout();
        customCommandHelpFlowLayoutPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)customCommandHelpPictureBox).BeginInit();
        exitFlowLayoutPanel.SuspendLayout();
        SuspendLayout();
        // 
        // mainTableLayoutPanel
        // 
        mainTableLayoutPanel.AutoSize = true;
        mainTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        mainTableLayoutPanel.ColumnCount = 2;
        mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
        mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        mainTableLayoutPanel.Controls.Add(exitLabel, 0, 3);
        mainTableLayoutPanel.Controls.Add(customCommandTextBox, 1, 1);
        mainTableLayoutPanel.Controls.Add(startFlowLayoutPanel, 1, 0);
        mainTableLayoutPanel.Controls.Add(startLabel, 0, 0);
        mainTableLayoutPanel.Controls.Add(customCommandHelpFlowLayoutPanel, 1, 2);
        mainTableLayoutPanel.Controls.Add(exitFlowLayoutPanel, 1, 3);
        mainTableLayoutPanel.Dock = DockStyle.Fill;
        mainTableLayoutPanel.Location = new Point(0, 0);
        mainTableLayoutPanel.Name = "mainTableLayoutPanel";
        mainTableLayoutPanel.Padding = new Padding(5);
        mainTableLayoutPanel.RowCount = 5;
        mainTableLayoutPanel.RowStyles.Add(new RowStyle());
        mainTableLayoutPanel.RowStyles.Add(new RowStyle());
        mainTableLayoutPanel.RowStyles.Add(new RowStyle());
        mainTableLayoutPanel.RowStyles.Add(new RowStyle());
        mainTableLayoutPanel.RowStyles.Add(new RowStyle());
        mainTableLayoutPanel.Size = new Size(748, 424);
        mainTableLayoutPanel.TabIndex = 16;
        // 
        // exitLabel
        // 
        exitLabel.AutoSize = true;
        exitLabel.Dock = DockStyle.Fill;
        exitLabel.Location = new Point(8, 104);
        exitLabel.Name = "exitLabel";
        exitLabel.Size = new Size(34, 45);
        exitLabel.TabIndex = 19;
        exitLabel.Text = "Exit:";
        exitLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // customCommandTextBox
        // 
        customCommandTextBox.Dock = DockStyle.Fill;
        customCommandTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        customCommandTextBox.Location = new Point(48, 47);
        customCommandTextBox.Name = "customCommandTextBox";
        customCommandTextBox.PlaceholderText = "Custom Command Command Line";
        customCommandTextBox.Size = new Size(692, 26);
        customCommandTextBox.TabIndex = 17;
        customCommandTextBox.PreviewKeyDown += CustomCommandTextBox_PreviewKeyDown;
        // 
        // startFlowLayoutPanel
        // 
        startFlowLayoutPanel.AutoSize = true;
        startFlowLayoutPanel.Controls.Add(startCalculatorButton);
        startFlowLayoutPanel.Controls.Add(startRegistryEditorButton);
        startFlowLayoutPanel.Controls.Add(startFileExplorerButton);
        startFlowLayoutPanel.Controls.Add(startPowerShellButton);
        startFlowLayoutPanel.Controls.Add(startCommandPromptButton);
        startFlowLayoutPanel.Controls.Add(startWindowsPowerShellButton);
        startFlowLayoutPanel.Dock = DockStyle.Fill;
        startFlowLayoutPanel.Location = new Point(45, 5);
        startFlowLayoutPanel.Margin = new Padding(0);
        startFlowLayoutPanel.Name = "startFlowLayoutPanel";
        startFlowLayoutPanel.Size = new Size(698, 39);
        startFlowLayoutPanel.TabIndex = 16;
        // 
        // startCalculatorButton
        // 
        startCalculatorButton.AutoSize = true;
        startCalculatorButton.Location = new Point(3, 3);
        startCalculatorButton.Name = "startCalculatorButton";
        startCalculatorButton.Size = new Size(73, 33);
        startCalculatorButton.TabIndex = 2;
        startCalculatorButton.Text = "Calculator";
        startCalculatorButton.UseVisualStyleBackColor = true;
        startCalculatorButton.Click += StartCalculatorButton_Click;
        // 
        // startRegistryEditorButton
        // 
        startRegistryEditorButton.AutoSize = true;
        startRegistryEditorButton.Location = new Point(82, 3);
        startRegistryEditorButton.Name = "startRegistryEditorButton";
        startRegistryEditorButton.Size = new Size(98, 33);
        startRegistryEditorButton.TabIndex = 3;
        startRegistryEditorButton.Text = "Registry Editor";
        startRegistryEditorButton.UseVisualStyleBackColor = true;
        startRegistryEditorButton.Click += StartRegistryEditorButton_Click;
        // 
        // startFileExplorerButton
        // 
        startFileExplorerButton.AutoSize = true;
        startFileExplorerButton.Location = new Point(186, 3);
        startFileExplorerButton.Name = "startFileExplorerButton";
        startFileExplorerButton.Size = new Size(83, 33);
        startFileExplorerButton.TabIndex = 4;
        startFileExplorerButton.Text = "File Explorer";
        startFileExplorerButton.UseVisualStyleBackColor = true;
        startFileExplorerButton.Click += StartFileExplorerButton_Click;
        // 
        // startPowerShellButton
        // 
        startPowerShellButton.AutoSize = true;
        startPowerShellButton.Location = new Point(275, 3);
        startPowerShellButton.Name = "startPowerShellButton";
        startPowerShellButton.Size = new Size(75, 33);
        startPowerShellButton.TabIndex = 5;
        startPowerShellButton.Text = "PowerShell";
        startPowerShellButton.UseVisualStyleBackColor = true;
        startPowerShellButton.Click += StartPowerShellButton_Click;
        // 
        // startCommandPromptButton
        // 
        startCommandPromptButton.AutoSize = true;
        startCommandPromptButton.Location = new Point(356, 3);
        startCommandPromptButton.Name = "startCommandPromptButton";
        startCommandPromptButton.Size = new Size(126, 33);
        startCommandPromptButton.TabIndex = 6;
        startCommandPromptButton.Text = "Command Prompt";
        startCommandPromptButton.UseVisualStyleBackColor = true;
        startCommandPromptButton.Click += StartCommandPromptButton_Click;
        // 
        // startWindowsPowerShellButton
        // 
        startWindowsPowerShellButton.AutoSize = true;
        startWindowsPowerShellButton.Location = new Point(488, 3);
        startWindowsPowerShellButton.Name = "startWindowsPowerShellButton";
        startWindowsPowerShellButton.Size = new Size(135, 33);
        startWindowsPowerShellButton.TabIndex = 7;
        startWindowsPowerShellButton.Text = "Windows PowerShell";
        startWindowsPowerShellButton.UseVisualStyleBackColor = true;
        startWindowsPowerShellButton.Click += StartWindowsPowerShellButton_Click;
        // 
        // startLabel
        // 
        startLabel.AutoSize = true;
        startLabel.Dock = DockStyle.Fill;
        startLabel.Location = new Point(8, 5);
        startLabel.Name = "startLabel";
        startLabel.Size = new Size(34, 39);
        startLabel.TabIndex = 1;
        startLabel.Text = "Start:";
        startLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // customCommandHelpFlowLayoutPanel
        // 
        customCommandHelpFlowLayoutPanel.AutoSize = true;
        customCommandHelpFlowLayoutPanel.Controls.Add(customCommandHelpPictureBox);
        customCommandHelpFlowLayoutPanel.Controls.Add(customCommandHelpLabel);
        customCommandHelpFlowLayoutPanel.Dock = DockStyle.Fill;
        customCommandHelpFlowLayoutPanel.Location = new Point(48, 79);
        customCommandHelpFlowLayoutPanel.Name = "customCommandHelpFlowLayoutPanel";
        customCommandHelpFlowLayoutPanel.Size = new Size(692, 22);
        customCommandHelpFlowLayoutPanel.TabIndex = 18;
        // 
        // customCommandHelpPictureBox
        // 
        customCommandHelpPictureBox.Dock = DockStyle.Left;
        customCommandHelpPictureBox.Location = new Point(3, 3);
        customCommandHelpPictureBox.Name = "customCommandHelpPictureBox";
        customCommandHelpPictureBox.Size = new Size(16, 16);
        customCommandHelpPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
        customCommandHelpPictureBox.TabIndex = 14;
        customCommandHelpPictureBox.TabStop = false;
        // 
        // customCommandHelpLabel
        // 
        customCommandHelpLabel.AutoSize = true;
        customCommandHelpLabel.Dock = DockStyle.Fill;
        customCommandHelpLabel.Location = new Point(22, 0);
        customCommandHelpLabel.Margin = new Padding(0);
        customCommandHelpLabel.Name = "customCommandHelpLabel";
        customCommandHelpLabel.Size = new Size(468, 22);
        customCommandHelpLabel.TabIndex = 15;
        customCommandHelpLabel.Text = "Press Enter to execute with CreateProcess. Press Ctrl+Enter to execute with ShellExecute.";
        customCommandHelpLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // exitFlowLayoutPanel
        // 
        exitFlowLayoutPanel.AutoSize = true;
        exitFlowLayoutPanel.Controls.Add(exitRestartShellButton);
        exitFlowLayoutPanel.Controls.Add(exitDoNothingButton);
        exitFlowLayoutPanel.Controls.Add(exitShutdownDeviceButton);
        exitFlowLayoutPanel.Controls.Add(exitRestartDeviceButton);
        exitFlowLayoutPanel.Location = new Point(48, 107);
        exitFlowLayoutPanel.Name = "exitFlowLayoutPanel";
        exitFlowLayoutPanel.Size = new Size(526, 39);
        exitFlowLayoutPanel.TabIndex = 20;
        // 
        // exitRestartShellButton
        // 
        exitRestartShellButton.AutoSize = true;
        exitRestartShellButton.Location = new Point(3, 3);
        exitRestartShellButton.Name = "exitRestartShellButton";
        exitRestartShellButton.Size = new Size(115, 33);
        exitRestartShellButton.TabIndex = 10;
        exitRestartShellButton.Text = "0 (restart the shell)";
        exitRestartShellButton.UseVisualStyleBackColor = true;
        exitRestartShellButton.Click += ExitRestartShellButton_Click;
        // 
        // exitDoNothingButton
        // 
        exitDoNothingButton.AutoSize = true;
        exitDoNothingButton.Location = new Point(124, 3);
        exitDoNothingButton.Name = "exitDoNothingButton";
        exitDoNothingButton.Size = new Size(97, 33);
        exitDoNothingButton.TabIndex = 11;
        exitDoNothingButton.Text = "1 (do nothing)";
        exitDoNothingButton.UseVisualStyleBackColor = true;
        exitDoNothingButton.Click += ExitDoNothingButton_Click;
        // 
        // exitShutdownDeviceButton
        // 
        exitShutdownDeviceButton.AutoSize = true;
        exitShutdownDeviceButton.Location = new Point(227, 3);
        exitShutdownDeviceButton.Name = "exitShutdownDeviceButton";
        exitShutdownDeviceButton.Size = new Size(159, 33);
        exitShutdownDeviceButton.TabIndex = 12;
        exitShutdownDeviceButton.Text = "255 (shut down the device)";
        exitShutdownDeviceButton.UseVisualStyleBackColor = true;
        exitShutdownDeviceButton.Click += ExitShutdownDeviceButton_Click;
        // 
        // exitRestartDeviceButton
        // 
        exitRestartDeviceButton.AutoSize = true;
        exitRestartDeviceButton.Location = new Point(392, 3);
        exitRestartDeviceButton.Name = "exitRestartDeviceButton";
        exitRestartDeviceButton.Size = new Size(131, 33);
        exitRestartDeviceButton.TabIndex = 13;
        exitRestartDeviceButton.Text = "-1 (restart the device)";
        exitRestartDeviceButton.UseVisualStyleBackColor = true;
        exitRestartDeviceButton.Click += ExitRestartDeviceButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(748, 424);
        Controls.Add(mainTableLayoutPanel);
        Name = "MainForm";
        Text = "Windows Kiosk Test App";
        mainTableLayoutPanel.ResumeLayout(false);
        mainTableLayoutPanel.PerformLayout();
        startFlowLayoutPanel.ResumeLayout(false);
        startFlowLayoutPanel.PerformLayout();
        customCommandHelpFlowLayoutPanel.ResumeLayout(false);
        customCommandHelpFlowLayoutPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)customCommandHelpPictureBox).EndInit();
        exitFlowLayoutPanel.ResumeLayout(false);
        exitFlowLayoutPanel.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TableLayoutPanel mainTableLayoutPanel;
    private FlowLayoutPanel startFlowLayoutPanel;
    private Button startCalculatorButton;
    private Button startRegistryEditorButton;
    private Button startFileExplorerButton;
    private Button startPowerShellButton;
    private Button startCommandPromptButton;
    private Button startWindowsPowerShellButton;
    private Label startLabel;
    private TextBox customCommandTextBox;
    private FlowLayoutPanel customCommandHelpFlowLayoutPanel;
    private PictureBox customCommandHelpPictureBox;
    private Label customCommandHelpLabel;
    private Label exitLabel;
    private FlowLayoutPanel exitFlowLayoutPanel;
    private Button exitRestartShellButton;
    private Button exitDoNothingButton;
    private Button exitShutdownDeviceButton;
    private Button exitRestartDeviceButton;
}
