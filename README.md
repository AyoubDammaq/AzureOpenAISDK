# SampleProject

This repository contains a simple .NET console application that demonstrates how to build an interactive chat client using the Google Gemini API. The application prompts the user for input and uses the `gemini-3.5-flash` model to generate and display a response.

*Note: While the repository is named `AzureOpenAISDK` and includes dependencies for Azure OpenAI, the current implementation exclusively uses the `Google.GenAI` SDK.*

## Features
*   Interactive command-line chat interface.
*   Integration with the Google Gemini API (`gemini-3.5-flash` model).
*   Secure API key management using .NET User Secrets.

## Prerequisites
*   [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) or a later version.
*   A valid Google Gemini API Key. You can obtain one from [Google AI Studio](https://aistudio.google.com/app/apikey).

## Getting Started

### 1. Clone the Repository
```sh
git clone https://github.com/ayoubdammaq/AzureOpenAISDK.git
cd AzureOpenAISDK
```

### 2. Configure API Key
This project uses .NET User Secrets to store your API key securely, preventing it from being checked into source control.

First, initialize user secrets for the project:
```sh
dotnet user-secrets init
```

Next, set your Gemini API key. Replace `YOUR_GEMINI_API_KEY` with your actual key.
```sh
dotnet user-secrets set "GEMINI_API_KEY" "YOUR_GEMINI_API_KEY"
```

### 3. Run the Application
Execute the following command to build and run the project:
```sh
dotnet run
```
Once running, the application will display `Enter your prompt:`. Type your message, press Enter, and the assistant's response will be displayed in the console. The session continues in a loop until you manually close the application.