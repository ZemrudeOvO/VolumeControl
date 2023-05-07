using Godot;
using System;

public partial class GenerateCheckBox : GridContainer
{
    CheckBox[] checkBoxes = new CheckBox[100];

    public override void _Ready()
    {
        for (int i = 0; i < 100; i++)
        {
            checkBoxes[i] = new CheckBox();
            AddChild(checkBoxes[i]);
            checkBoxes[i].Text = (i + 1).ToString();
            checkBoxes[i].ButtonGroup = GD.Load<ButtonGroup>("uid://dk8h6mwgh8iyh");
        }

        checkBoxes[99].ButtonPressed = true;
    }

    public override void _Process(double delta)
    {
        for (int i = 0; i < 100; i++)
        {
            if (checkBoxes[i].ButtonPressed)
                Volume.volume = (uint)i;
        }
    }
}