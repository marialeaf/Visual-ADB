namespace Visual_ADB;

public partial class KeyEventModal : Form
{
    public event Action<string> EventNumberSubmitted;
    
    public KeyEventModal()
    {
        InitializeComponent();
        Text = "Key event";
    }

    private void button2_Click(object sender, EventArgs e)
    {
        string textBoxValue = textBox1.Text;
        EventNumberSubmitted?.Invoke(textBoxValue);
        Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();
    }
}