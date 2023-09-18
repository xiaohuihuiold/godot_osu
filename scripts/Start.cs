using System;
using System.IO;
using Godot;

namespace GodotOsu.scripts;

public partial class Start : Node
{
    private const string OsuPath = "../../osu/temp/temp.osu";

    public override void _Ready()
    {
    }

    public override void _Process(double delta)
    {
    }

    private void _onStartPressed()
    {
        try
        {
            var reader = File.OpenText(OsuPath);
            GD.Print(reader.ReadToEnd());
        }
        catch (FileNotFoundException e)
        {
            GD.PrintErr("文件未找到");
        }
    }
}