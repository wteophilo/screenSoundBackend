namespace ScreenSoundBackend.Helpers.AI;
internal class GenerateBandSumary
{
    public static string Call(string bandName)
    {
        string prompt = $"Create a very small sumary of the band {bandName}. This text will be used for a music app, so keep it short and concise.";
        return GenerateContentSimpleText.Call(prompt).GetAwaiter().GetResult();
    }
}