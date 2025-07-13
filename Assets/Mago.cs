using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mago : Personaje
{
    public override void Atacar()
    {
        Debug.Log($"{Nombre} lanza un hechizo mgico");
        base.Atacar();
    }
}
