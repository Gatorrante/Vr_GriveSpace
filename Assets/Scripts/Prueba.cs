using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using static Unity.Mathematics.math;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public int valor;
    private GameObject PlanetaAct;

    void Awake()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
}

