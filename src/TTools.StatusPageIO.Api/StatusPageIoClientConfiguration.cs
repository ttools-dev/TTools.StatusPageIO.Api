namespace TTools.StatusPageIO.Api;

public class StatusPageIoClientConfiguration
{
    /// <summary>
    /// The base URI of the status page
    /// e.g. https://discordstatus.com or https://www.githubstatus.com
    /// </summary>
    public Uri StatusPageBaseUri { get; set; } = null!;
}
