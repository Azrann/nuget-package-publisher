using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace PackagePublisher
{
    class Program
    {
        private static void Main(string[] args)
        {
            string directory = null;
            
            string packageConfig = ReadNuGetPackageConfig(directory);
            string myPackages = CopyFileToMyPackages(directory);
            PublishToNuget(packageConfig, myPackages);
            CleanUpFiles(packageConfig, myPackages, directory);
        }

        private static void CleanUpFiles(string version, string projectName, string directory = null)
        {
            if (directory == null)
            {
                directory = Directory.GetCurrentDirectory();
            }

            File.Delete($"{Directory.GetCurrentDirectory()}\\{projectName.Replace("csproj", version)}.nupkg");
            File.Delete($"C:\\SourceCode\\MyPackages\\{projectName.Replace("csproj", version)}.nupkg");
        }

        private static void PublishToNuget(string version, string projectName)
        {
            Process.Start("CMD.exe",
                $"/c C:\\SourceCode\\MyPackages\\nuget.exe push -Source \"Hrplan\" -ApiKey xoez4gds4fovnajajhpeeo26gpevr6o7bf556nbdywmtbus5vanq {projectName.Replace("csproj", version)}.nupkg").WaitForExit();
        }

        private static string CopyFileToMyPackages(string directory = null)
        {
            if (directory == null)
            {
                directory = Directory.GetCurrentDirectory();
            }

            string file = Directory.GetFiles(directory, "*.csproj")[0];
            Process.Start("CMD.exe", $"/c C:\\SourceCode\\nuget.exe pack \"{file}\" -IncludeReferencedProjects -Prop Configuration=Release").WaitForExit();
            Process.Start("CMD.exe", $"/c xcopy /Y \"{directory}\\*.nupkg\" C:\\SourceCode\\MyPackages").WaitForExit();
            return Path.GetFileName(file);
        }

        private static string ReadNuGetPackageConfig(string directory = null)
        {
            if (directory == null)
            {
                directory = Directory.GetCurrentDirectory();
            }

            string[] files = Directory.GetFiles(directory, "*.nuspec");
            string input = File.ReadAllText(files[0]);
            Version version1 = new Version(Regex.Match(input, "<version>(.*?)</version>").Value.Replace("<version>", "").Replace("</version>", ""));
            Version version2 = new Version(version1.Major, version1.Minor, version1.Build + 1);
            string contents = input.Replace(version1.ToString(), version2.ToString());
            File.WriteAllText(files[0], contents);
            return version2.ToString();
        }
    }
}
