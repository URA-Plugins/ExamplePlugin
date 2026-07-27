using UmamusumeResponseAnalyzer.Plugin;

namespace ExamplePlugin;

public sealed class ExamplePlugin : IPlugin
{
    public string Name => "Example Plugin";

    public string Author => "Umamusume Response Analyzer";

    public string[] Targets => [];

    public void Initialize(IPluginContext context) { }
}
