param($installPath, $toolsPath, $package, $project)

$getTargetFrameworkMoniker = [Microsoft.VisualStudio.Project.VisualC.VCProjectEngine.VCProjectShim].GetMethod("get_TargetFrameworkMoniker")
$targetFrameworkVersion = (New-Object System.Runtime.Versioning.FrameworkName $getTargetFrameworkMoniker.Invoke($project.Object, $null)).Version

$fwPath = "portable-net45+win+wpa81+MonoAndroid10+MonoTouch10+Xamarin.iOS10"

$assemblyPath = [System.IO.Path]::Combine($toolsPath, "..\..\lib\$fwPath\SocialInsurance.Germany.Messages.Mappings.dll")
$obj = $project.Object
$getRefsMethod = [Microsoft.VisualStudio.Project.VisualC.VCProjectEngine.VCProjectShim].GetMethod("get_References")
$refs = $getRefsMethod.Invoke($obj, $null)
$refs.Add($assemblyPath)
