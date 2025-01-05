using System.ComponentModel;

namespace Visual_ADB;

partial class InstallAppModal
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
        label1.Location = new System.Drawing.Point(40, 13);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(194, 40);
        label1.TabIndex = 0;
        label1.Text = "Absoulte path to app(example: C:/apps/app.apk):";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(9, 56);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(250, 23);
        textBox1.TabIndex = 1;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(9, 85);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 23);
        button1.TabIndex = 2;
        button1.Text = "Install";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(184, 85);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(75, 23);
        button2.TabIndex = 3;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // InstallAppModal
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(265, 117);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Controls.Add(label1);
        MaximumSize = new System.Drawing.Size(281, 156);
        MinimumSize = new System.Drawing.Size(281, 156);
        Text = "InstallAppModal";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    #endregion
}