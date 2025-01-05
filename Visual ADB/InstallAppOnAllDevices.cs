namespace Visual_ADB;

public partial class InstallAppOnAllDevices : Form
{
    public event Action<string>? InstallAppOnAllDevicesPathSubmitted;

    public InstallAppOnAllDevices()
    {
        InitializeComponent();
        Text = "Install app on all devices";
    }


    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string textBoxValue = textBox1.Text;
        InstallAppOnAllDevicesPathSubmitted?.Invoke(textBoxValue);
        Close();
    }
}