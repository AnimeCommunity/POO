using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerrero : Personaje
{
    public override void Atacar()
    {
        Debug.Log($"{Nombre} realiza un ataque poderoso con espada");
        base.Atacar();
    }
}
