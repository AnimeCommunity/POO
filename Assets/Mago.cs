using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mago : Personaje
{
    
    private void Start()
    {
        Nombre = "Aros";
        Atacar();
    }
    
    
    public override void Atacar()
    {
        Debug.Log($"{Nombre} lanza un hechizo mgico");
        base.Atacar();
    }
}
