using System.ComponentModel;

namespace Visual_ADB;

partial class KeyEventModal
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(16, 23);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(148, 23);
        label1.TabIndex = 0;
        label1.Text = "Key event number:";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(127, 23);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(63, 23);
        textBox1.TabIndex = 1;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(277, 23);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 23);
        button1.TabIndex = 2;
        button1.Text = "Cancel";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(196, 23);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(75, 23);
        button2.TabIndex = 3;
        button2.Text = "Send";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // KeyEventModal
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(355, 61);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Controls.Add(label1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximumSize = new System.Drawing.Size(371, 100);
        MinimumSize = new System.Drawing.Size(371, 100);
        Text = "KeyEventModal";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Label label1;

    #endregion
}