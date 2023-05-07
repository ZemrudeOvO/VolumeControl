using Godot;
using System;

public partial class MuteCheckbox : CheckBox
{
    public override void _Ready()
    {
        this.Toggled += (bool isPressed) => AudioServer.SetBusMute(0, isPressed);
    }
}
