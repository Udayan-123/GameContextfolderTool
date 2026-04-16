using System.Text;

namespace GameContextfolderTool; // <--- CHANGE THIS to match your project name!

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnGenerate_Click(object sender, EventArgs e)
    {
        string folderPath = txtPath.Text.Trim();

        // 1. Check if the path is empty or doesn't exist
        if (string.IsNullOrEmpty(folderPath) || !Directory.Exists(folderPath))
        {
            MessageBox.Show("Please paste a valid folder path first.");
            return;
        }

        // 2. Start building the visual tree
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Structure for: {folderPath}");
        sb.AppendLine("==========================================");

        try
        {
            // Start the recursive "digging" process
            BuildTree(folderPath, sb, 0);

            // 3. Show the result in the big text box
            txtOutput.Text = sb.ToString();

            // 4. Automatically copy to clipboard for your AI
            Clipboard.SetText(sb.ToString());

            MessageBox.Show("Structure copied to clipboard!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    // This is the logic that goes into sub-folders, and sub-sub-folders
    private void BuildTree(string currentPath, StringBuilder sb, int indentLevel)
    {
        string indent = new string(' ', indentLevel * 4);
        DirectoryInfo directoryInfo = new DirectoryInfo(currentPath);

        // List all files in the current folder
        foreach (var file in directoryInfo.GetFiles())
        {
            sb.AppendLine($"{indent}📄 {file.Name}");
        }

        // List all folders and "dig" into them
        foreach (var subDir in directoryInfo.GetDirectories())
        {
            sb.AppendLine($"{indent}📁 {subDir.Name.ToUpper()}");

            // This calls the same function again to look inside the new folder
            BuildTree(subDir.FullName, sb, indentLevel + 1);
        }
    }
}