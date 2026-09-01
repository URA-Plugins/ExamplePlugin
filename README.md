# ExamplePlugin

ExamplePlugin 是用于演示 URA 插件契约的最小插件模板。当前实现注册一个 `IPlugin`，初始化时不读取输入、不产生输出，也不添加运行时行为。

仓库通过 `NuGet.Config` 恢复 `UmamusumeResponseAnalyzer` 编译期包。在仓库根执行：

```powershell
dotnet build .\ExamplePlugin.csproj -c Release -m:1 -p:RuntimeIdentifier=win-x64 -p:SelfContained=false -p:PlatformTarget=AnyCPU -p:DeployUraPluginToLocalAppDataOnBuild=false
```
