using DinoMax.Scripts.Cartas.Enums;
using Godot;

namespace DinoMax.Scripts.Cartas;

[GlobalClass]
public partial class Carta : Resource
{
	[Export] public string Nombre {get; set;}
	[Export] public int Costo {get; set;}
	[Export] public TipoDeCarta Tipo {get; set;}
}
