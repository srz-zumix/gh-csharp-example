using System.Net;
using Cocona;

public class Program
{
    static void Main(string[] args)
    {
        var builder = CoconaApp.CreateBuilder(args, options =>
        {
            options.EnableShellCompletionSupport = true;
        });
        var app = builder.Build();
        app.AddSubCommand("say", x =>
        {
            x.AddCommand("hello", (string name="world") => Console.WriteLine($"Hello {name}"));
            x.AddCommand("goodbye", (string name="world") => Console.WriteLine($"Goodbye {name}"));
        });
        app.Run();
    }
}
