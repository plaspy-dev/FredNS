using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Zonas
/// </summary>
public class Zonas
{
    public string Nombre {get; set;}
    public string Tipo { get; set; }
    public string Destino { get; set;}
    public int Id {get;set;}
	public Zonas(int id,string nombre, string tipo, string destino)
	{
        Id = id;
        Nombre = nombre;
        Tipo = tipo;
        Destino = destino;
	}
}
