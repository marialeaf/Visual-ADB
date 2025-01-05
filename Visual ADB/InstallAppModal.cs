namespace Visual_ADB;

public partial class InstallAppModal : Form
{
    public event Action<string>? InstallAppPathSubmitted;
    
    public InstallAppModal()
    {
        InitializeComponent();
        Text = "Install app";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string textBoxValue = textBox1.Text;
        InstallAppPathSubmitted?.Invoke(textBoxValue);
        Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}