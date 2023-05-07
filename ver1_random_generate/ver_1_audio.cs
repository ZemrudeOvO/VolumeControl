using Godot;
using System;

public partial class ver_1_audio : AudioStreamPlayer, IChangeVolume
{
    [Export]
    Button button;

    public override void _Ready()
    {
        button.Pressed += ChangeVolume;
    }

    public void ChangeVolume()
    {
        this.VolumeDb = Mathf.Remap((float)Volume.volume, 0f, 100f, -50f, 0f);
        AudioServer.SetBusMute(0, Volume.volume == 0);
    }
}
