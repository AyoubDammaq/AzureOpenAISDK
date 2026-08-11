using Azure;
using Azure.AI.OpenAI;
using OpenAI.Chat;

string endpoint = "https://<your-resource>.openai.azure.com/";
string apiKey = "<your-api-key>";
string deploymentName = "<your-deployment-name>";

var client = new AzureOpenAIClient(
    new Uri(endpoint),
    new AzureKeyCredential(apiKey));

ChatClient chatClient = client.GetChatClient(deploymentName);

var messages = new List<ChatMessage>
{
    new SystemChatMessage(
        "You are a senior .NET engineer. Explain concepts clearly to junior developers."),

    new UserChatMessage(
        "Explain Dependency Injection in ASP.NET Core.")
};

ChatCompletion completion = chatClient.CompleteChat(
    messages,
    new ChatCompletionOptions
    {
        Temperature = 0.2f,
        MaxOutputTokenCount = 300
    });

Console.WriteLine("Assistant:");
Console.WriteLine(completion.Content[0].Text);