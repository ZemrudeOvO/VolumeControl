using Godot;
using System;

public partial class ver_1_Label : Label, IChangeVolume
{
    [Export]
    Button button;

    public void ChangeVolume()
    {
        this.Text = $"Current volume: {Volume.volume.ToString()}%";
    }

    public override void _Ready()
    {
        button.Pressed += ChangeVolume;
    }
}
