namespace Visual_ADB;

using System.Diagnostics;
using static System.Diagnostics.Process;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.Text = "Visual ADB v1.0";
    }

    private void Run(string args)
    {
        Process process = new Process();
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            WindowStyle = ProcessWindowStyle.Hidden,
            FileName = "adb.exe",
            Arguments = args
        };
        process.StartInfo = startInfo;
        process.Start();
    }
    
    private void OnKeyEventNumberSubmitted(string text)
    {
        Run($"shell input keyevent {text.Trim()}");
    }
    
    private void rebootFastboot_Click(object sender, EventArgs e)
    {
        Run("reboot fastboot");
    }

    private void rebootRecovery_Click(object sender, EventArgs e)
    {
        Run("reboot recovery");
    }
    
    private void rebootSystem_Click(object sender, EventArgs e)
    {
        Run("reboot");
    }

    private void rebootBootloader_Click(object sender, EventArgs e)
    {
        Run("reboot bootloader");
    }

    private void adbStartServer_Click(object sender, EventArgs e)
    {
        Run("start-server");
    }

    private void adbKillServer_Click(object sender, EventArgs e)
    {
        Run("kill-server");
    }


    private void adbKeyEvent_Click(object sender, EventArgs e)
    {
        KeyEventModal modal = new KeyEventModal();
        modal.EventNumberSubmitted += OnKeyEventNumberSubmitted;
        modal.ShowDialog();
    }

    private void adbShell_Click(object sender, EventArgs e)
    {
        Start("adb.exe", "shell");
    }

    private void OnRemoveAppNameSubmitted(string name)
    {
        Run($"uninstall {name.Trim()}");
    }

    private void OnRemoveAppWithoutDataNameSubmitted(string name)
    {
        Run($"uninstall -k {name.Trim()}");
    }
    private void removeApp_Click(object sender, EventArgs e)
    {
        RemoveAppModal modal = new RemoveAppModal();
        modal.RemoveAppNameSubmitted += OnRemoveAppNameSubmitted;
        modal.ShowDialog();
    }

    private void removeAppWithoutData_Click(object sender, EventArgs e)
    {
        RemoveAppWithoutDataModal modal = new RemoveAppWithoutDataModal();
        modal.RemoveAppWithoutDataNameSubmitted += OnRemoveAppWithoutDataNameSubmitted;
        modal.ShowDialog();
    }

    private void OnInstallAppNameSubmitted(string path)
    {
        Run($"-d install {path.Trim()}");
    }
    
    private void installOnOneDevice_Click(object sender, EventArgs e)
    {
        InstallAppModal modal = new InstallAppModal();
        modal.InstallAppPathSubmitted += OnInstallAppNameSubmitted;
        modal.ShowDialog();
    }

    private void OnInstallAppOnAllDevicesNameSubmitted(string path)
    {
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "adb.exe",
            Arguments = "devices",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using (Process process = Start(psi))
        {
            using (var reader = process.StandardOutput)
            {
                string result = reader.ReadToEnd();
                string[] lines = result.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i < lines.Length; i++)
                {
                    string deviceId = lines[i].Split('\t')[0];
                    ProcessStartInfo installInfo = new ProcessStartInfo
                    {
                        FileName = "adb.exe",
                        Arguments = $"-s {deviceId} install -r \"{path}\"",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (Process installProcess = Start(installInfo))
                    {
                        string installResult = installProcess.StandardOutput.ReadToEnd();
                        installProcess.WaitForExit();
                    }
                }
            }
            process.WaitForExit();
        }
    }

    private void installOnAllDevices_Click(object sender, EventArgs e)
    {
        InstallAppOnAllDevices modal = new InstallAppOnAllDevices();
        modal.InstallAppOnAllDevicesPathSubmitted += OnInstallAppOnAllDevicesNameSubmitted;
        modal.ShowDialog();
    }
}