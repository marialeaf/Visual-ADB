namespace Visual_ADB;

public partial class RemoveAppWithoutDataModal : Form
{
    public event Action<string>? RemoveAppWithoutDataNameSubmitted;
    
    public RemoveAppWithoutDataModal()
    {
        InitializeComponent();
        Text = "Remove app without data";
    }
    
    private void button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string textBoxValue = textBox1.Text;
        RemoveAppWithoutDataNameSubmitted?.Invoke(textBoxValue);
        this.Close();
    }
}