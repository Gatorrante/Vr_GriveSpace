using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetaB5 : MonoBehaviour
{
    public string nombre;
    public string masa;
    public string tiempoRotacion;
    public string tiempoTraslacion;
    public string Diametro;
    public bool esHabitable;
    public string TipoAtmosfera;
    private PanelPlanetaB5 panel;
    
    // Start is called before the first frame update
    void Start()
    {
        panel = FindObjectOfType<PanelPlanetaB5>();
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        panel.nombre.text = "Nombre: "+nombre;
        panel.masa.text = "Masa: "+masa;
        panel.Trotacion.text = "Tiempo de rotacion: "+tiempoRotacion;
        panel.Ttraslacion.text = "Tiempo de traslacion: "+tiempoTraslacion;
        panel.Diametro.text = "Diametro: "+Diametro;
        if(esHabitable)
            panel.esHabitable.text = "Es Habitable";
        else
            panel.esHabitable.text = "No Es Habitable";
        panel.TipoAtmosfera.text = "Tipo Atmosfera"+ TipoAtmosfera;
    }
}
