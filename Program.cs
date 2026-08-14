using Google.GenAI;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();

string apiKey = configuration["GEMINI_API_KEY"]
    ?? throw new InvalidOperationException(
        "GEMINI_API_KEY is not configured.");

var client = new Client(apiKey: apiKey);

while (true)
{
    Console.WriteLine("Enter your prompt:");
    string prompt = Console.ReadLine();
    var response = await client.Models.GenerateContentAsync(
        model: "gemini-3.5-flash",
        contents: prompt
    );
    Console.WriteLine("Assistant:");
    Console.WriteLine(response.Text);
}