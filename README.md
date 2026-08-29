# ExamplePlugin

ExamplePlugin 是用于演示 URA 插件契约的最小插件模板。当前实现注册一个 `IPlugin`，初始化时不读取输入、不产生输出，也不添加运行时行为。

仓库通过 Git submodule 固定 URA Host 源码。克隆后在仓库根执行：

```powershell
git -c core.longpaths=true submodule update --init --recursive
dotnet build .\ExamplePlugin.csproj -c Release -m:1 -p:RuntimeIdentifier=win-x64 -p:SelfContained=false -p:PlatformTarget=AnyCPU -p:DeployUraPluginToLocalAppDataOnBuild=false
```
