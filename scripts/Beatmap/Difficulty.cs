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

    public readonly double HpDrainRate;
    public readonly double CircleSize;
    public readonly double OverallDifficulty;
    public readonly double ApproachRate;
    public readonly double SliderMultiplier;
    public readonly double SliderTickRate;

    public Difficulty(double hpDrainRate, double circleSize, double overallDifficulty, double approachRate,
        double sliderMultiplier, double sliderTickRate)
    {
        HpDrainRate = hpDrainRate;
        CircleSize = circleSize;
        OverallDifficulty = overallDifficulty;
        ApproachRate = approachRate;
        SliderMultiplier = sliderMultiplier;
        SliderTickRate = sliderTickRate;
    }
}

public class DifficultyBuilder
{
    private double _hpDrainRate;
    private double _circleSize;
    private double _overallDifficulty;
    private double _approachRate;
    private double _sliderMultiplier;
    private double _sliderTickRate;

    public double HpDrainRate
    {
        set => _hpDrainRate = value;
    }

    public double CircleSize
    {
        set => _circleSize = value;
    }

    public double OverallDifficulty
    {
        set => _overallDifficulty = value;
    }

    public double ApproachRate
    {
        set => _approachRate = value;
    }

    public double SliderMultiplier
    {
        set => _sliderMultiplier = value;
    }

    public double SliderTickRate
    {
        set => _sliderTickRate = value;
    }


    public Difficulty Build()
    {
        return new Difficulty(
            hpDrainRate: _hpDrainRate,
            circleSize: _circleSize,
            overallDifficulty: _overallDifficulty,
            approachRate: _approachRate,
            sliderMultiplier: _sliderMultiplier,
            sliderTickRate: _sliderTickRate
        );
    }
}