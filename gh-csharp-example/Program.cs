using System.Net;
using Cocona;

public class Program
{
    static void Main(string[] args)
    {
        CoconaApp.Run<Program>(args, options =>
        {
            options.EnableShellCompletionSupport = true;
        });
    }
    
    public void Hello(string name)
    {
        Console.WriteLine($"Hello {name}");
    }
}