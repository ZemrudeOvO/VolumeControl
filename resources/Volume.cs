using Godot;
using System;

public partial class Volume : Node
{
    public static uint volume;
}

public interface IChangeVolume
{
    void ChangeVolume();
}