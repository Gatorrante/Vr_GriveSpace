using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Nuevo Planeta", menuName = "Planeta")]
public class Planetas : ScriptableObject
{
    public string PlanetaName;

    public int PlanetaPosicion;

    public Vector3 Orbita;

    public GameObject PrefabPlaneta;

    public float velocidad;

    public Sprite ImagenPlaneta;
}
