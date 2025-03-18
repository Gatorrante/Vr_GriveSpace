using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CrearPlaneta : MonoBehaviour
{
    public Planetas Planeta;

    private GameObject Spawn;
    private GameObject PanelRotacion;
    private GameObject PanelPrin;
    private GameObject Mano;

    void Awake()
    {
        Mano = GameObject.FindGameObjectWithTag("Mano"); 
        Spawn = GameObject.FindGameObjectWithTag("Spawn");
        PanelPrin = GameObject.FindGameObjectWithTag("Panel");
        PanelRotacion = GameObject.FindGameObjectWithTag("Rotacion");
    }

    public void Crearplaneta()
    {
        GameObject PlanetaAct = Instantiate(Planeta.PrefabPlaneta);
        PlanetaAct.transform.position = Mano.transform.position;
        
    }
    public void NuevoPlaneta()
    {
        PanelPrin.SetActive(true);
        PanelRotacion.SetActive(false);
    }
}
