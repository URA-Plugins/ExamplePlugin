# ExamplePlugin

ExamplePlugin 是用于演示 URA 插件契约的最小插件模板。当前实现注册一个 `IPlugin`，初始化时不读取输入、不产生输出，也不添加运行时行为。

项目依赖 URA Host 源码中的插件接口。构建时通过 `UraHostProjectPath` 指定宿主项目，并关闭 manifest、打包和本机部署副作用：

```powershell
dotnet build .\ExamplePlugin.csproj -p:UraHostProjectPath="<ura-host-project>" -p:GenerateUraPluginManifestOnBuild=false -p:PackageUraPluginOnBuild=false -p:DeployUraPluginToLocalAppDataOnBuild=false
```
