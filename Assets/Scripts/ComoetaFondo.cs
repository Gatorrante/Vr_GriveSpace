using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComoetaFondo : MonoBehaviour
{
    private GameObject pivote;
    private float aparecer;
    private float contador;

    public int orbita;
    public GameObject Estela;
    public GameObject Look;



    void Awake()
    {
        pivote = GameObject.FindGameObjectWithTag("Sun");
        aparecer = Random.Range(20, 60.5f);
    }

    void Update()
    {
        contador += Time.deltaTime;
        Estela.transform.LookAt(Look.transform.position);
        Orbita(orbita);
        if (contador >= aparecer)
        {
            for (int i = 0; i < 3; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
            if (contador >= aparecer + 5)
            {
                for (int i = 0; i < 3; i++)
                {
                    transform.GetChild(i).gameObject.SetActive(false);
                }
                aparecer = Random.Range(20, 60.5f);
                contador = 0;
            }
        }
    }

    public void Orbita(int valor)
    {
        switch (valor)
        {
            case 0:
                transform.RotateAround(pivote.transform.position, Vector3.up, 10 * Time.deltaTime);
                return;
            case 1:
                transform.RotateAround(pivote.transform.position, Vector3.right, 10 * Time.deltaTime);
                return;
            case 2:
                transform.RotateAround(pivote.transform.position, new Vector3(45, 45, 0), 10 * Time.deltaTime);
                return;
            case 3:
                transform.RotateAround(pivote.transform.position, new Vector3(45, -45, 0), 10 * Time.deltaTime);
                return;
        }
    }
}
