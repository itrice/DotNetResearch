namespace iTrice.Research.GitVersion;
public class Logger
{
    public void Log(string text)
    {
        // +semver: major #passed
        // +semver: feature  # not passed
        // +semver: minor 
        // +semver: fix 
        Console.WriteLine(text);
    }
}
