using LLama;
using LLama.Common;


var modelPath = "D:\\llama-2-7b-guanaco-qlora.Q4_K_M.gguf";
var prompt = "The chat session has started. In this example, the prompt is printed for better visual result.";
var parameters = new ModelParams(modelPath)
{
    ContextSize = 1024,
    Seed = 1337,
    GpuLayerCount = 5
};
using var model = LLamaWeights.LoadFromFile(parameters);
using var context = model.CreateContext(parameters);
var executor = new InteractiveExecutor(context);

var session = new ChatSession(executor);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("The chat session has started. In this example, the prompt is printed for better visual result.");
Console.ForegroundColor = ConsoleColor.White;

// show the prompt
Console.Write(prompt);
while (true)
{
    await foreach (var text in session.ChatAsync(prompt, new InferenceParams() { Temperature = 0.6f, AntiPrompts = new List<string> { "User:" } }))
    {
        Console.Write(text);
    }

    Console.ForegroundColor = ConsoleColor.Green;
    prompt = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.White;
}
    