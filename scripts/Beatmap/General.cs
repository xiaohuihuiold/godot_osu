using System;
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

public enum GeneralKeys
{
    AudioFilename,
    AudioLeadIn,
    PreviewTime,
    Countdown,
    SampleSet,
    StackLeniency,
    Mode,
    LetterboxInBreaks,
    UseSkinSprites,
    OverlayPosition,
    SkinPreference,
    EpilepsyWarning,
    CountdownOffset,
    SpecialStyle,
    WidescreenStoryboard,
    SamplesMatchPlaybackRate,
}

public struct General
{
    public const string SectionName = "[General]";

    public readonly List<string> AudioFilename;
    public readonly long AudioLeadIn;
    public readonly long PreviewTime;
    public readonly GeneralCountdown Countdown;
    public readonly GeneralSampleSet SampleSet;
    public readonly double StackLeniency;
    public readonly GeneralGameMode Mode;
    public readonly bool LetterboxInBreaks;
    public readonly bool UseSkinSprites;
    public readonly GeneralOverlayPosition OverlayPosition;
    public readonly List<string> SkinPreference;
    public readonly bool EpilepsyWarning;
    public readonly int CountdownOffset;
    public readonly bool SpecialStyle;
    public readonly bool WidescreenStoryboard;
    public readonly bool SamplesMatchPlaybackRate;

    public General(List<string> audioFilename, long audioLeadIn, long previewTime, GeneralCountdown countdown,
        GeneralSampleSet sampleSet, double stackLeniency, GeneralGameMode mode, bool letterboxInBreaks,
        bool useSkinSprites, GeneralOverlayPosition overlayPosition, List<string> skinPreference, bool epilepsyWarning,
        int countdownOffset, bool specialStyle, bool widescreenStoryboard, bool samplesMatchPlaybackRate)
    {
        AudioFilename = audioFilename;
        AudioLeadIn = audioLeadIn;
        PreviewTime = previewTime;
        Countdown = countdown;
        SampleSet = sampleSet;
        StackLeniency = stackLeniency;
        Mode = mode;
        LetterboxInBreaks = letterboxInBreaks;
        UseSkinSprites = useSkinSprites;
        OverlayPosition = overlayPosition;
        SkinPreference = skinPreference;
        EpilepsyWarning = epilepsyWarning;
        CountdownOffset = countdownOffset;
        SpecialStyle = specialStyle;
        WidescreenStoryboard = widescreenStoryboard;
        SamplesMatchPlaybackRate = samplesMatchPlaybackRate;
    }
}

public class GeneralBuilder
{
    private List<string> _audioFilename = new();
    private long _audioLeadIn = 0;
    private long _previewTime = -1;
    private GeneralCountdown _countdown = GeneralCountdown.None;
    private GeneralSampleSet _sampleSet = GeneralSampleSet.Normal;
    private double _stackLeniency = 0.7;
    private GeneralGameMode _mode = GeneralGameMode.Osu;
    private bool _letterboxInBreaks = false;
    private bool _useSkinSprites = false;
    private GeneralOverlayPosition _overlayPosition = GeneralOverlayPosition.NoChange;
    private List<string> _skinPreference = new();
    private bool _epilepsyWarning = false;
    private int _countdownOffset = 0;
    private bool _specialStyle = false;
    private bool _widescreenStoryboard = false;
    private bool _samplesMatchPlaybackRate = false;

    public List<string> AudioFilename
    {
        set => _audioFilename = value;
    }

    public long AudioLeadIn
    {
        set => _audioLeadIn = value;
    }

    public long PreviewTime
    {
        set => _previewTime = value;
    }

    public GeneralCountdown Countdown
    {
        set => _countdown = value;
    }

    public GeneralSampleSet SampleSet
    {
        set => _sampleSet = value;
    }

    public double StackLeniency
    {
        set => _stackLeniency = value;
    }

    public GeneralGameMode Mode
    {
        set => _mode = value;
    }

    public bool LetterboxInBreaks
    {
        set => _letterboxInBreaks = value;
    }

    public bool UseSkinSprites
    {
        set => _useSkinSprites = value;
    }

    public GeneralOverlayPosition OverlayPosition
    {
        set => _overlayPosition = value;
    }

    public List<string> SkinPreference
    {
        set => _skinPreference = value ?? throw new ArgumentNullException(nameof(value));
    }

    public bool EpilepsyWarning
    {
        set => _epilepsyWarning = value;
    }

    public int CountdownOffset
    {
        set => _countdownOffset = value;
    }

    public bool SpecialStyle
    {
        set => _specialStyle = value;
    }

    public bool WidescreenStoryboard
    {
        set => _widescreenStoryboard = value;
    }

    public bool SamplesMatchPlaybackRate
    {
        set => _samplesMatchPlaybackRate = value;
    }

    public General Build()
    {
        return new General(
            audioFilename: _audioFilename,
            audioLeadIn: _audioLeadIn,
            previewTime: _previewTime,
            countdown: _countdown,
            sampleSet: _sampleSet,
            stackLeniency: _stackLeniency,
            mode: _mode,
            letterboxInBreaks: _letterboxInBreaks,
            useSkinSprites: _useSkinSprites,
            overlayPosition: _overlayPosition,
            skinPreference: _skinPreference,
            epilepsyWarning: _epilepsyWarning,
            countdownOffset: _countdownOffset,
            specialStyle: _specialStyle,
            widescreenStoryboard: _widescreenStoryboard,
            samplesMatchPlaybackRate: _samplesMatchPlaybackRate
        );
    }
}