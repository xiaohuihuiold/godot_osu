using System;
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

    public readonly string? Title;
    public readonly string? TitleUnicode;
    public readonly string? Artist;
    public readonly string? ArtistUnicode;
    public readonly string? Creator;
    public readonly string? Version;
    public readonly string? Source;
    public readonly List<string> Tags;
    public readonly long BeatmapId;
    public readonly long BeatmapSetId;

    public Metadata(string? title, string? titleUnicode, string? artist, string? artistUnicode, string? creator,
        string? version, string? source, List<string> tags, long beatmapId, long beatmapSetId)
    {
        Title = title;
        TitleUnicode = titleUnicode;
        Artist = artist;
        ArtistUnicode = artistUnicode;
        Creator = creator;
        Version = version;
        Source = source;
        Tags = tags;
        BeatmapId = beatmapId;
        BeatmapSetId = beatmapSetId;
    }
}

public class MetadataBuilder
{
    private string? _title = null;
    private string? _titleUnicode = null;
    private string? _artist = null;
    private string? _artistUnicode = null;
    private string? _creator = null;
    private string? _version = null;
    private string? _source = null;
    private List<string> _tags = new();
    private long _beatmapId = 0;
    private long _beatmapSetId = 0;

    public string? Title
    {
        set => _title = value;
    }

    public string? TitleUnicode
    {
        set => _titleUnicode = value;
    }

    public string? Artist
    {
        set => _artist = value;
    }

    public string? ArtistUnicode
    {
        set => _artistUnicode = value;
    }

    public string? Creator
    {
        set => _creator = value;
    }

    public string? Version
    {
        set => _version = value;
    }

    public string? Source
    {
        set => _source = value;
    }

    public List<string> Tags
    {
        set => _tags = value;
    }

    public long BeatmapId
    {
        set => _beatmapId = value;
    }

    public long BeatmapSetId
    {
        set => _beatmapSetId = value;
    }

    public Metadata Build()
    {
        return new Metadata(
            title: _title,
            titleUnicode: _titleUnicode,
            artist: _artist,
            artistUnicode: _artistUnicode,
            creator: _creator,
            version: _version,
            source: _source,
            tags: _tags,
            beatmapId: _beatmapId,
            beatmapSetId: _beatmapSetId
        );
    }
}