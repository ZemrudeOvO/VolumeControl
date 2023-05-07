using Godot;
using System;

public partial class ver_2_ButtonDisplay : Button
{
    public override void _Ready()
    {
        this.Toggled += (bool isPressed) => this.Text = isPressed ? "=" : "<";
    }
}