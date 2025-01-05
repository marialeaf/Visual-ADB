namespace Visual_ADB;

public partial class RemoveAppModal : Form
{
    public event Action<string> RemoveAppNameSubmitted;

    public RemoveAppModal()
    {
        InitializeComponent();
        this.Text = "Remove app";
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string textBoxValue = textBox1.Text;
        RemoveAppNameSubmitted?.Invoke(textBoxValue);
        this.Close();
    }
}