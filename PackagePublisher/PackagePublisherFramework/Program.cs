using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace PackagePublisherFramework
{
    class Program
    {
        private static void Main(string[] args)
        {
            string directory = null;

            string version = ReadNuGetPackageConfig(directory);
            string myPackages = CopyFileToMyPackages(version, directory);
            PublishToNuget(version, myPackages);
            CleanUpFiles(version, myPackages);
        }

        private static void CleanUpFiles(string version, string projectName)
        {
            File.Delete($"{Directory.GetCurrentDirectory()}\\{projectName.Replace("csproj", version)}.nupkg");
            File.Delete($"C:\\SourceCode\\MyPackages\\{projectName.Replace("csproj", version)}.nupkg");
        }

        private static void PublishToNuget(string version, string projectName)
        {
            Process.Start("CMD.exe",
                $"/c C:\\SourceCode\\MyPackages\\nuget.exe push -Source \"Hrplan\" -ApiKey xoez4gds4fovnajajhpeeo26gpevr6o7bf556nbdywmtbus5vanq {projectName.Replace("csproj", version)}.nupkg").WaitForExit();
        }

        private static string CopyFileToMyPackages(string version,string directory = null)
        {
            if (directory == null)
            {
                directory = Directory.GetCurrentDirectory();
            }
           
            //dotnet pack -c release -o "C:\SourceCode\mentor.telegram.bot\src\Mentor.telegram.bot\Mentor.telegram.bot.sdk" /p:Version=1.0.1
            string file = Directory.GetFiles(directory, "*.csproj")[0];
            Console.WriteLine($"Installing here: \n /c dotnet {directory} pack -c release -o \"{directory}\" /p:Version={version}");
            Process.Start("CMD.exe", $"/c dotnet pack -c release -o \"{directory}\" /p:Version={version}").WaitForExit();
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
