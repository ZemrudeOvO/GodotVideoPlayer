using Godot;
using System;

public partial class VolumeRandomWindow : Window
{
	public override void _Ready()
	{
		this.Position = DisplayServer.ScreenGetSize(-1) / 2 - this.Size / 2;

		CloseRequested += () => this.Hide();
	}
}
