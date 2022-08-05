namespace iTrice.Research.GitVersion;
public class Logger
{
    public void Log(string text)
    {
        // +semver: major #passed
        // +semver: breaking #no passed
        // +semver: feature # passed
        // +semver: minor # passed
        // +semver: fix  #passed 
       //...

        Console.WriteLine(text);
    }
}
