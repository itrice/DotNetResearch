namespace iTrice.Research.GitVersion;
public class Logger
{
    public void Log(string text)
    {
        // +semver: major #passed
        // +semver: feature 
        Console.WriteLine(text);
    }
}
