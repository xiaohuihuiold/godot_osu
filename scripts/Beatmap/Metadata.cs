using System.Collections.Generic;

namespace GodotOsu.scripts.Beatmap;

public enum MetadataKeys
{
    Title,
    TitleUnicode,
    Artist,
    ArtistUnicode,
    Creator,
    Version,
    Source,
    Tags,
    BeatmapID,
    BeatmapSetID,
}

public struct Metadata
{
    public const string SectionName = "[Metadata]";

    public string? Title = null;
    public string? TitleUnicode = null;
    public string? Artist = null;
    public string? ArtistUnicode = null;
    public string? Creator = null;
    public string? Version = null;
    public string? Source = null;
    public List<string> Tags = new();
    public long BeatmapId = 0;
    public long BeatmapSetId = 0;

    public Metadata()
    {
    }
}