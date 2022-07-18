namespace iTrice.Research.GitVersion;
public class Logger
{
    public void Log(string text)
    {
        // +semver: major #passed
        // +semver: feature  #no passed
        // +semver: minor #no passed
        // +semver: fix 

        Console.WriteLine(text);
    }
}
