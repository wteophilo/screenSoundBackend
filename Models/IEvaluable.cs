namespace ScreenSoundBackend.Models;

interface IEvaluable
{
    public void AddEvaluation(Evaluate evaluation);

    public double Average { get; }
}