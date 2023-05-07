using Godot;
using System;

public partial class ver_1_Button : Button, IChangeVolume
{
    public override void _Ready()
    {
        this.Pressed += ChangeVolume;
    }

    public void ChangeVolume()
    {
        Volume.volume = GD.Randi() % 101;
    }
}
