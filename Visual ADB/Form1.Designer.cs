namespace Visual_ADB;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        rebootRecovery = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        panel1 = new System.Windows.Forms.Panel();
        rebootFastboot = new System.Windows.Forms.Button();
        adbShell = new System.Windows.Forms.Button();
        adbKeyEvent = new System.Windows.Forms.Button();
        adbKillServer = new System.Windows.Forms.Button();
        adbStartServer = new System.Windows.Forms.Button();
        label5 = new System.Windows.Forms.Label();
        removeAppWithoutData = new System.Windows.Forms.Button();
        removeApp = new System.Windows.Forms.Button();
        label4 = new System.Windows.Forms.Label();
        installOnAllDevices = new System.Windows.Forms.Button();
        installOnOneDevice = new System.Windows.Forms.Button();
        label3 = new System.Windows.Forms.Label();
        rebootBootloader = new System.Windows.Forms.Button();
        rebootSystem = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(119, 8);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 3;
        label1.Text = "Reboot to...";
        // 
        // rebootRecovery
        // 
        rebootRecovery.Location = new System.Drawing.Point(80, 34);
        rebootRecovery.Name = "rebootRecovery";
        rebootRecovery.Size = new System.Drawing.Size(75, 23);
        rebootRecovery.TabIndex = 4;
        rebootRecovery.Text = "Recovery";
        rebootRecovery.UseVisualStyleBackColor = true;
        rebootRecovery.Click += rebootRecovery_Click;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 12F);
        label2.Location = new System.Drawing.Point(11, 8);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(136, 23);
        label2.TabIndex = 2;
        label2.Text = "ADB Commands";
        // 
        // panel1
        // 
        panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panel1.Controls.Add(rebootFastboot);
        panel1.Controls.Add(adbShell);
        panel1.Controls.Add(adbKeyEvent);
        panel1.Controls.Add(adbKillServer);
        panel1.Controls.Add(adbStartServer);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(removeAppWithoutData);
        panel1.Controls.Add(removeApp);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(installOnAllDevices);
        panel1.Controls.Add(installOnOneDevice);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(rebootBootloader);
        panel1.Controls.Add(rebootSystem);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(rebootRecovery);
        panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        panel1.Location = new System.Drawing.Point(11, 34);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(320, 282);
        panel1.TabIndex = 5;
        // 
        // rebootFastboot
        // 
        rebootFastboot.Location = new System.Drawing.Point(-1, 34);
        rebootFastboot.Name = "rebootFastboot";
        rebootFastboot.Size = new System.Drawing.Size(75, 23);
        rebootFastboot.TabIndex = 18;
        rebootFastboot.Text = "Fastboot";
        rebootFastboot.UseVisualStyleBackColor = true;
        rebootFastboot.Click += rebootFastboot_Click;
        // 
        // adbShell
        // 
        adbShell.Location = new System.Drawing.Point(244, 247);
        adbShell.Name = "adbShell";
        adbShell.Size = new System.Drawing.Size(75, 23);
        adbShell.TabIndex = 17;
        adbShell.Text = "Shell";
        adbShell.UseVisualStyleBackColor = true;
        adbShell.Click += adbShell_Click;
        // 
        // adbKeyEvent
        // 
        adbKeyEvent.Location = new System.Drawing.Point(161, 247);
        adbKeyEvent.Name = "adbKeyEvent";
        adbKeyEvent.Size = new System.Drawing.Size(75, 23);
        adbKeyEvent.TabIndex = 16;
        adbKeyEvent.Text = "Key event";
        adbKeyEvent.UseVisualStyleBackColor = true;
        adbKeyEvent.Click += adbKeyEvent_Click;
        // 
        // adbKillServer
        // 
        adbKillServer.Location = new System.Drawing.Point(80, 247);
        adbKillServer.Name = "adbKillServer";
        adbKillServer.Size = new System.Drawing.Size(75, 23);
        adbKillServer.TabIndex = 15;
        adbKillServer.Text = "Kill server";
        adbKillServer.UseVisualStyleBackColor = true;
        adbKillServer.Click += adbKillServer_Click;
        // 
        // adbStartServer
        // 
        adbStartServer.Location = new System.Drawing.Point(-1, 247);
        adbStartServer.Name = "adbStartServer";
        adbStartServer.Size = new System.Drawing.Size(75, 23);
        adbStartServer.TabIndex = 14;
        adbStartServer.Text = "Start server";
        adbStartServer.UseVisualStyleBackColor = true;
        adbStartServer.Click += adbStartServer_Click;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(119, 223);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(100, 23);
        label5.TabIndex = 13;
        label5.Text = "Advanced";
        // 
        // removeAppWithoutData
        // 
        removeAppWithoutData.Location = new System.Drawing.Point(45, 187);
        removeAppWithoutData.Name = "removeAppWithoutData";
        removeAppWithoutData.Size = new System.Drawing.Size(229, 23);
        removeAppWithoutData.TabIndex = 12;
        removeAppWithoutData.Text = "Remove without deleting data";
        removeAppWithoutData.UseVisualStyleBackColor = true;
        removeAppWithoutData.Click += removeAppWithoutData_Click;
        // 
        // removeApp
        // 
        removeApp.Location = new System.Drawing.Point(119, 158);
        removeApp.Name = "removeApp";
        removeApp.Size = new System.Drawing.Size(75, 23);
        removeApp.TabIndex = 11;
        removeApp.Text = "Remove";
        removeApp.UseVisualStyleBackColor = true;
        removeApp.Click += removeApp_Click;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(119, 132);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 23);
        label4.TabIndex = 10;
        label4.Text = "Remove app";
        // 
        // installOnAllDevices
        // 
        installOnAllDevices.Location = new System.Drawing.Point(152, 95);
        installOnAllDevices.Name = "installOnAllDevices";
        installOnAllDevices.Size = new System.Drawing.Size(101, 23);
        installOnAllDevices.TabIndex = 9;
        installOnAllDevices.Text = "On all devices";
        installOnAllDevices.UseVisualStyleBackColor = true;
        installOnAllDevices.Click += installOnAllDevices_Click;
        // 
        // installOnOneDevice
        // 
        installOnOneDevice.Location = new System.Drawing.Point(45, 95);
        installOnOneDevice.Name = "installOnOneDevice";
        installOnOneDevice.Size = new System.Drawing.Size(101, 23);
        installOnOneDevice.TabIndex = 8;
        installOnOneDevice.Text = "On one device";
        installOnOneDevice.UseVisualStyleBackColor = true;
        installOnOneDevice.Click += installOnOneDevice_Click;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(119, 69);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 7;
        label3.Text = "Install app";
        // 
        // rebootBootloader
        // 
        rebootBootloader.Location = new System.Drawing.Point(242, 34);
        rebootBootloader.Name = "rebootBootloader";
        rebootBootloader.Size = new System.Drawing.Size(75, 23);
        rebootBootloader.TabIndex = 6;
        rebootBootloader.Text = "Bootloader";
        rebootBootloader.UseVisualStyleBackColor = true;
        rebootBootloader.Click += rebootBootloader_Click;
        // 
        // rebootSystem
        // 
        rebootSystem.Location = new System.Drawing.Point(161, 34);
        rebootSystem.Name = "rebootSystem";
        rebootSystem.Size = new System.Drawing.Size(75, 23);
        rebootSystem.TabIndex = 5;
        rebootSystem.Text = "System";
        rebootSystem.UseVisualStyleBackColor = true;
        rebootSystem.Click += rebootSystem_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(339, 325);
        Controls.Add(label2);
        Controls.Add(panel1);
        Location = new System.Drawing.Point(15, 15);
        MaximumSize = new System.Drawing.Size(355, 364);
        MinimumSize = new System.Drawing.Size(355, 364);
        Text = "Form1";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button rebootFastboot;

    private System.Windows.Forms.Button adbShell;

    private System.Windows.Forms.Button adbKeyEvent;

    private System.Windows.Forms.Button adbKillServer;

    private System.Windows.Forms.Button adbStartServer;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Button removeAppWithoutData;

    private System.Windows.Forms.Button removeApp;

    private System.Windows.Forms.Button installOnAllDevices;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Button installOnOneDevice;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Button rebootSystem;
    private System.Windows.Forms.Button rebootBootloader;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Button rebootRecovery;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}