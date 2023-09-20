using System;
using System.Collections.Generic;

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
    private double _hpDrainRate = 0.0;
    private double _circleSize = 0.0;
    private double _overallDifficulty = 0.0;
    private double _approachRate = 0.0;
    private double _sliderMultiplier = 0.0;
    private double _sliderTickRate = 0.0;

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