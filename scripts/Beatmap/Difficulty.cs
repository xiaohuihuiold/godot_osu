namespace GodotOsu.scripts.Beatmap;

public enum DifficultyKeys
{
    HPDrainRate,
    CircleSize,
    OverallDifficulty,
    ApproachRate,
    SliderMultiplier,
    SliderTickRate,
}

public struct Difficulty
{
    public const string SectionName = "[Difficulty]";
    public double HpDrainRate = 0.0;
    public double CircleSize = 0.0;
    public double OverallDifficulty = 0.0;
    public double ApproachRate = 0.0;
    public double SliderMultiplier = 0.0;
    public double SliderTickRate = 0.0;

    public Difficulty()
    {
    }
}