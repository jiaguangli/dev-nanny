using System.Diagnostics;

namespace Dev.Core;

public static class ProcessHelper
{
    private static Dictionary<string, int> ProcessDic { get; set; } = [];
    /// <summary>
    /// kill process by path
    /// </summary>
    /// <param name="path"></param>
    public static void Kill(string path)
    {
        if (!ProcessDic.TryGetValue(path, out var pid)) return;
        KillById(pid);
    }

    /// <summary>
    /// kill process by pid
    /// </summary>
    /// <param name="pid"></param>
    public static void KillById(int pid)
    {
        Process.GetProcessById(pid).Kill(true);

        var dic = ProcessDic.Where(x => x.Value == pid);
        foreach (var key in dic.Select(x=>x.Key))
        {
            ProcessDic.Remove(key);
        }
    }


    /// <summary>
    /// kill all Process
    /// </summary>
    public static void KillAll()
    {
        foreach (var process in ProcessDic)
        {
            KillById(process.Value);
        }
    }

    /// <summary>
    /// Start a process
    /// </summary>
    /// <param name="startInfo"></param>
    /// <returns></returns>
    public static int Run(ProcessStartInfo startInfo)
    {
        var processes= Process.GetProcessesByName(Path.GetFileNameWithoutExtension(startInfo.FileName));

        var process = processes.FirstOrDefault();

        if (process == null)
        {
            process ??= new Process
            {
                StartInfo = startInfo
            };
            process.Start();
        }
        // 获取进程ID
        ProcessDic[startInfo.FileName] = process.Id;

        return process.Id;
    }
}