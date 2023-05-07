using Godot;
using System;

public partial class ver_2_slider : HSlider
{
    [Export]
    Button button;

    public override void _Ready()
    {
        this.Visible = false;
        button.Toggled += (bool isPressed) => this.Visible = isPressed;

        this.Connect("value_changed", new Callable(this, nameof(ChangeValue)));
    }

    void ChangeValue(float value)
    {
        Volume.volume = (uint)value;
    }
}
