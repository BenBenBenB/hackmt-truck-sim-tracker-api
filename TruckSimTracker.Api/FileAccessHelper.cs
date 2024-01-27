namespace TruckSimTracker.Server;
public class FileAccessHelper
{
    public static string GetLocalFilePath(string filename)
    {
        var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        return System.IO.Path.Combine(appData, filename);
    }
}