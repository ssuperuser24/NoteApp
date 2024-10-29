using System.Diagnostics;

namespace NoteAppUI;

public partial class AboutForm : Form
{
    public AboutForm() => InitializeComponent();

    /// <summary>
    /// Click on mail author link
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => ExecLink("mailto:superuser.superuser24@gmail.com");

    /// <summary>
    /// Click on GitHub author link
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GhLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => ExecLink("https://github.com/ssuperuser24/NoteApp");

    /// <summary>
    /// Run process to execute link
    /// </summary>
    /// <param name="link"></param>
    private static void ExecLink(string link)
    {
        if (string.IsNullOrEmpty(link))
            return;

        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = link,
                UseShellExecute = true
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred while starting Process with link '{link}': {ex.Message}");
        }
    }

    /// <summary>
    /// Close on esc key
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected override bool ProcessDialogKey(Keys keyData)
    {
        if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
        {
            Close();
            return true;
        }
        return base.ProcessDialogKey(keyData);
    }
}
