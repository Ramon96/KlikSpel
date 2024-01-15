using Godot;
using System;

public partial class KlikKnop : Button
{
	private int klikAantal = 0;
	private Label klikAantalLabel;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		klikAantalLabel = GetNode<Label>("../KlikAantalLabel");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	
	private void _on_pressed()
	{
		klikAantal++;
		klikAantalLabel.Text = klikAantal.ToString();
		GD.Print("Aantal kliks: " + klikAantal);
	}
}
