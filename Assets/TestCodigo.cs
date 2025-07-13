using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCodigo : MonoBehaviour
{
    void Start()
    {
        Mago mago = new Mago();
        mago.Nombre = "Merlín";
        mago.Atacar(); 
    }
}
