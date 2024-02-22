using Godot;
using System;

public partial class RandomVolume : Button
{
    public override void _Ready()
    {
        Pressed += GenerateRandomVolume;
    }

    void GenerateRandomVolume()
    {
        float v = 0;
        Volume.volume = v;
    }
}
