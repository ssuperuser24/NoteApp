namespace NoteAppUI;

partial class AboutForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        mailLinkLabel = new LinkLabel();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        ghLinkLabel = new LinkLabel();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label1.Location = new Point(12, 22);
        label1.Name = "label1";
        label1.Size = new Size(136, 38);
        label1.TabIndex = 0;
        label1.Text = "NoteApp";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(20, 60);
        label2.Name = "label2";
        label2.Size = new Size(53, 20);
        label2.TabIndex = 1;
        label2.Text = "v. 1.0.0";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(20, 120);
        label3.Name = "label3";
        label3.Size = new Size(160, 20);
        label3.TabIndex = 1;
        label3.Text = "Author: Sergey Akimov";
        // 
        // mailLinkLabel
        // 
        mailLinkLabel.AutoSize = true;
        mailLinkLabel.Location = new Point(170, 170);
        mailLinkLabel.Name = "mailLinkLabel";
        mailLinkLabel.Size = new Size(238, 20);
        mailLinkLabel.TabIndex = 2;
        mailLinkLabel.TabStop = true;
        mailLinkLabel.Text = "superuser.superuser24@gmail.com";
        mailLinkLabel.LinkClicked += MailLinkLabel_LinkClicked;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(20, 170);
        label4.Name = "label4";
        label4.Size = new Size(143, 20);
        label4.TabIndex = 1;
        label4.Text = "e-mail for feedback:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(20, 209);
        label5.Name = "label5";
        label5.Size = new Size(59, 20);
        label5.TabIndex = 1;
        label5.Text = "GitHub:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(20, 309);
        label6.Name = "label6";
        label6.Size = new Size(161, 20);
        label6.TabIndex = 1;
        label6.Text = "2024 Sergey Akimov ©";
        // 
        // ghLinkLabel
        // 
        ghLinkLabel.AutoSize = true;
        ghLinkLabel.Location = new Point(170, 209);
        ghLinkLabel.Name = "ghLinkLabel";
        ghLinkLabel.Size = new Size(290, 20);
        ghLinkLabel.TabIndex = 2;
        ghLinkLabel.TabStop = true;
        ghLinkLabel.Text = "https://github.com/ssuperuser24/NoteApp";
        ghLinkLabel.LinkClicked += GhLinkLabel_LinkClicked;
        // 
        // AboutForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(473, 340);
        Controls.Add(ghLinkLabel);
        Controls.Add(mailLinkLabel);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AboutForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "About";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private LinkLabel mailLinkLabel;
    private Label label4;
    private Label label5;
    private Label label6;
    private LinkLabel ghLinkLabel;
}