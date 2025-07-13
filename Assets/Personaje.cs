using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    // Encapsulacion con campos privados y propiedades publicas
    private string nombre;
    private int fuerza;
    private int defensa;
    private int vida;
    private int agilidad;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Fuerza { get => fuerza; set => fuerza = value; }
    public int Defensa { get => defensa; set => defensa = value; }
    public int Vida { get => vida; set => vida = value; }
    public int Agilidad { get => agilidad; set => agilidad = value; }

    // Abstraccion: metodo de alto nivel que oculta los detalles internos

    public virtual void Atacar()
    {
        int daño = CalcularDaño();
        Debug.Log($"{Nombre} ataca e inflige {daño} de daño");
    }

    protected int CalcularDaño()
    {
        int bonus = agilidad > 5 ? 2 : 0;
        return fuerza + bonus;
    }
}
