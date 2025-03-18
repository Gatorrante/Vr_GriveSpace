using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CambiarRotacion : MonoBehaviour
{
    public TextMeshProUGUI Nombre;
    private GameObject PlanetaAct;

    public void NuevaRotacion(int valor)
    {
        PlanetaAct = GameObject.Find(Nombre.text + "(Clone)");
        PlanetaAct.GetComponent<OrbitasPlanetas>().CambiarOrbita(valor);
    }
}
