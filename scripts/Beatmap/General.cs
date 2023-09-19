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
    public const string KeyAudioFileName = "AudioFilename";
    public const string KeyAudioLeadIn = "AudioLeadIn";
    public const string KeyPreviewTime = "PreviewTime";
    public const string KeyCountdown = "Countdown";
    public const string KeySampleSet = "SampleSet";
    public const string KeyStackLeniency = "StackLeniency";
    public const string KeyMode = "StackLeniency";
    public const string KeyLetterboxInBreaks = "LetterboxInBreaks";
    public const string KeyUseSkinSprites = "UseSkinSprites";
    public const string KeyOverlayPosition = "OverlayPosition";
    public const string KeySkinPreference = "SkinPreference";
    public const string KeyEpilepsyWarning = "EpilepsyWarning";
    public const string KeyCountdownOffset = "CountdownOffset";
    public const string KeySpecialStyle = "SpecialStyle";
    public const string KeyWidescreenStoryboard = "WidescreenStoryboard";
    public const string KeySamplesMatchPlaybackRate = "SamplesMatchPlaybackRate";

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