using System.Collections.Generic;

namespace GodotOsu.scripts.Beatmap;

public enum GeneralCountdown
{
    None = 0,
    Normal = 1,
    Half = 2,
    Double = 3,
}

public enum GeneralSampleSet
{
    Normal,
    Soft,
    Drum,
}

public enum GeneralGameMode
{
    Osu = 0,
    Taiko = 1,
    Catch = 2,
    Mania = 3,
}

public enum GeneralOverlayPosition
{
    NoChange,
    Below,
    Above,
}

public struct General
{
    public const string SectionName = "[General]";

    public List<string>? AudioFilename = null;
    public long AudioLeadIn = 0;
    public long PreviewTime = -1;
    public GeneralCountdown Countdown = GeneralCountdown.None;
    public GeneralSampleSet SampleSet = GeneralSampleSet.Normal;
    public double StackLeniency = 0.7;
    public GeneralGameMode Mode = GeneralGameMode.Osu;
    public bool LetterboxInBreaks = false;
    public bool UseSkinSprites = false;
    public GeneralOverlayPosition OverlayPosition = GeneralOverlayPosition.NoChange;
    public List<string>? SkinPreference = null;
    public bool EpilepsyWarning = false;
    public int CountdownOffset = 0;
    public bool SpecialStyle = false;
    public bool WidescreenStoryboard = false;
    public bool SamplesMatchPlaybackRate = false;

    public General()
    {
    }
}