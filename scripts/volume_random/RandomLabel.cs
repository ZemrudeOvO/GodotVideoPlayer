using Godot;
using System;

public partial class RandomLabel : Label
{
	[Export]
	Button button;

	public override void _Ready()
	{
		button.Pressed += ChangeLabel;
	}

	public void ChangeLabel()
	{
		Text = $"Current Volume Level: {Volume.volume}%";
	}
}
