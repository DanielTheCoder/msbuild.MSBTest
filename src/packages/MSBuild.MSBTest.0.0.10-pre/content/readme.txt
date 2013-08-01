
After installing add the following import to your '<project>/.build/build.targets' file

  <Import Project="$(MSBuildProjectDirectory)\build\MSBTest.targets" />

and comment out the following lines if present:

  <!--<Target Name="Build" />
  <Target Name="Clean" />
  <Target Name="Rebuild" />
  <Target Name="Publish"/>
  <Target Name="GetNativeManifest" />
  <Target Name="GetCopyToOutputDirectoryItems" />
  <Target Name="AfterBuild" AfterTargets="Build" />-->
