# MsBuild-MockLibrary

All the magic happens in the MockLibraryRunner.csproj file:

```xml
<Choose>
  <When Condition="'$(Configuration)'=='Debug'">
    <ItemGroup>
      <ProjectReference Include="..\MockLibrary\MockLibrary.csproj">
        <Project>{244665fb-5a3e-4659-bcd1-d9c4f1cc69d6}</Project>
        <Name>MockLibrary</Name>
      </ProjectReference>
    </ItemGroup>
  </When>
  <Otherwise>
    <ItemGroup>
      <ProjectReference Include="..\RealLibrary\RealLibrary.csproj">
        <Project>{d727350d-15bc-4aef-9a6f-892496ff2d9a}</Project>
        <Name>RealLibrary</Name>
      </ProjectReference>
    </ItemGroup>
  </Otherwise>
</Choose>
```

So, in Visual Studio, when you run the example app you should see different output in the console depending on the Build Configuration you've chosen (Debug/Release)
