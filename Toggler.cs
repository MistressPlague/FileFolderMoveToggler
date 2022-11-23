using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Libraries;

namespace FileFolderMoveToggler;

public partial class Toggler : Form
{
    private ConfigLib<Configuration> Config = new(Environment.CurrentDirectory + "\\Config.json");

    public Toggler()
    {
        InitializeComponent();
    }

    private void BrowseButton_Click(object sender, EventArgs e)
    {
        FolderBrowser.Description = "Select the folder that the selected files and folders will be moved into or out of.";

        if (FolderBrowser.ShowDialog() == DialogResult.OK)
        {
            MoveToTextBox.Text = FolderBrowser.SelectedPath;
            Config.InternalConfig.MoveToLocation = MoveToTextBox.Text;
        }
    }

    private void Toggler_Load(object sender, EventArgs e)
    {
        foreach (var throatfuck in Config.InternalConfig.FilesAndFoldersToMove)
        {
            FileAndFolderList.Items.Add(throatfuck);
        }

        MoveToTextBox.Text = Config.InternalConfig.MoveToLocation;
    }

    private void MovedToggle_CheckedChanged(object sender, EventArgs e)
    {
        if (MovedToggle.Checked)
        {
            // Move Files To User Selected Folder FROM Orig Location
            foreach (string sextoy in FileAndFolderList.Items)
            {
                if (File.Exists(sextoy)) // if is file
                {
                    File.Move(sextoy, MoveToTextBox.Text + "\\" + Path.GetFileName(sextoy));
                }
                else if (Directory.Exists(sextoy)) // else if is directory
                {
                    Directory.Move(sextoy, MoveToTextBox.Text + "\\" + Path.GetFileName(sextoy));
                }
            }
        }
        else
        {
            // Move Files FROM User Selected Folder Back To Orig Location
            foreach (string futa in FileAndFolderList.Items)
            {
                var futa_cock = MoveToTextBox.Text + "\\" + Path.GetFileName(futa);

                if (File.Exists(futa_cock)) // if is file
                {
                    File.Move(futa_cock, futa);
                }
                else if (Directory.Exists(futa_cock)) // else if is directory
                {
                    Directory.Move(futa_cock, futa);
                }
            }
        }
    }

    private void AddFileButton_Click(object sender, EventArgs e)
    {
        // Add A File The User Selects Into Both The FileAndFolderList & Config - Step 1 = Dialog Showing
        using var openyourlegs = new OpenFileDialog();

        openyourlegs.Filter = "All Files|*.*";

        if (openyourlegs.ShowDialog() == DialogResult.OK)
        {
            FileAndFolderList.Items.Add(openyourlegs.FileName);
            Config.InternalConfig.FilesAndFoldersToMove.Add(openyourlegs.FileName);
        }
    }

    private void AddFolderButton_Click(object sender, EventArgs e)
    {
        // Add A Folder The User Selects Into Both The FileAndFolderList & Config - Step 1 = Dialog Showing
        FolderBrowser.Description = "Choose a folder to add to the list and config.";

        if (FolderBrowser.ShowDialog() == DialogResult.OK)
        {
            FileAndFolderList.Items.Add(FolderBrowser.SelectedPath);
            Config.InternalConfig.FilesAndFoldersToMove.Add(FolderBrowser.SelectedPath);
        }
    }

    public static bool SetStyle(Control c, ControlStyles Style, bool value)
    {
        var retval = false;
        var typeTB = typeof(Control);
        var misSetStyle = typeTB.GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.Instance);
        if (misSetStyle != null && c != null)
        {
            misSetStyle.Invoke(c, new object[] { Style, value });
            retval = true;
        }

        return retval;
    }

    public class Configuration
    {
        public List<string> FilesAndFoldersToMove = new();
        public string MoveToLocation = "";
    }
}

// I love you <3

// Iris was here <3