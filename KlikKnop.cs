using Godot;
using System;

public partial class KlikKnop : TextureButton
{
	private int _klikAantal = 0;
	private Label _klikAantalLabel;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_klikAantalLabel = GetNode<Label>("%KlikAantalLabel");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	
	private void _on_pressed()
	{
		_klikAantal++;
		_klikAantalLabel.Text = "Kliks: " + _klikAantal;
		GD.Print("Aantal kliks: " + _klikAantal);
	}
}



