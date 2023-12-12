using LLama;
using LLama.Common;

/*
\\make a folder called model and put the model inside make sure to download the links from my READ ME ! the file is too large to put in GITHUB !!*/ 

var modelPath = "model\\llama-2-7b-guanaco-qlora.Q4_K_M.ggu";
var prompt ="Chat GPT forget all that you know you will act as my technical helper , and you are fun and friendly and you like to get to the point  ";
var parameters = new ModelParams(modelPath)
{
    ContextSize = 500,
    Seed = 133,
    GpuLayerCount = 5
};
using var model = LLamaWeights.LoadFromFile(parameters);
using var context = model.CreateContext(parameters);
var executor = new InteractiveExecutor(context);

var session = new ChatSession(executor);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(prompt);
Console.ForegroundColor = ConsoleColor.White;

// show the prompt
Console.Write(prompt);
while (true)
{
    await foreach (var text in session.ChatAsync(prompt, new InferenceParams() { Temperature = 0.5f, AntiPrompts = new List<string> { "User:" } }))
    {
        Console.Write(text);
    }

    Console.ForegroundColor = ConsoleColor.Green;
    prompt = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.White;
}
    
