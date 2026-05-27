using Google.GenAI;

namespace ScreenSoundBackend.Helpers.AI;

internal class GenerateContentSimpleText
{

    private const string MODEL = "gemini-3.5-flash";
    private static readonly string GEMINI_API_KEY = DotNetEnv.Env.GetString("GEMINI_API_KEY");

    public static async Task<string> Call(string prompt)
    {

        var client = new Client(apiKey: GEMINI_API_KEY);
        var response = await client.Models.GenerateContentAsync(
          model: MODEL, contents: prompt
        );
        return response.Candidates?[0]?.Content?.Parts?[0]?.Text ?? "No content returned.";
    }
}