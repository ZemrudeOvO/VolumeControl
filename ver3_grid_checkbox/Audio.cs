using Godot;
using System;

public partial class Audio : AudioStreamPlayer
{
    public override void _Process(double delta)
    {
        this.VolumeDb = Mathf.Remap(Volume.volume, 0.0f, 100.0f, -50.0f, 0.0f);
    }
}
