# ExamplePlugin

ExamplePlugin 是用于演示 URA 插件契约的最小插件模板。当前实现注册一个 `IPlugin`，初始化时不读取输入、不产生输出，也不添加运行时行为。

仓库通过 `NuGet.Config` 恢复 `UmamusumeResponseAnalyzer` 编译期包。在仓库根执行：

```powershell
dotnet build .\ExamplePlugin.csproj -c Release -m:1 -p:RuntimeIdentifier=win-x64 -p:SelfContained=false -p:PlatformTarget=AnyCPU -p:DeployUraPluginToLocalAppDataOnBuild=false
```

## 验证与发布

在 Windows 仓库根执行 `act workflow_dispatch --artifact-server-path "$env:TEMP/ura-act-artifacts"`。本地与 GitHub 使用同一份 workflow；版本 tag 触发 GitHub Release 发布。环境要求、共用 workflow 本地映射和发布规则见 [URA plugin workflows](https://github.com/URA-Plugins/.github/blob/v1/README.md)。
