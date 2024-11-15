using NoteApp.Extensions;
using NoteApp.Models;

namespace NoteApp.Services;

/// <summary>
/// Represents save and load project operations
/// </summary>
public static class ProjectManager
{
    /// <summary>
    /// Project file location
    /// </summary>
    public static readonly string PROJECT_LOCATION = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\NoteApp.notes";

    /// <summary>
    /// Load project from file or create new
    /// </summary>
    /// <returns></returns>
    public static Project Load()
    {
        Project noteProject = null!;

        if (File.Exists(PROJECT_LOCATION))
            try
            {
                var json = File.ReadAllText(PROJECT_LOCATION);
                noteProject = json.FromJson<Project>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while loading project from file {PROJECT_LOCATION}: {ex.Message}");
                throw;
            }

        return noteProject ?? new();
    }

    /// <summary>
    /// Save project to file
    /// </summary>
    /// <param name="project"></param>
    /// <returns></returns>
    public static void Save(Project project)
    {
        ArgumentNullException.ThrowIfNull(project, nameof(project));

        try
        {
            File.WriteAllText(PROJECT_LOCATION, project.ToJson());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred while saving project to file {PROJECT_LOCATION}: {ex.Message}");
            throw;
        }
    }
}
