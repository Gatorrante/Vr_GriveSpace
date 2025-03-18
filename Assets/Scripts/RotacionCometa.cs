using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Mathematics.math;
using Unity.Mathematics;
using UnityEngine.XR.OpenXR.Input;

public class RotacionCometa : MonoBehaviour
{
    public GameObject Sol;

    private float Radio, velocidadAngular = 2.5f;
    private float posX, posZ, angle = 0f;
    private bool Activar = false, diriguirse = true;
    private Vector3 iniciar;

    public float Div1, Div2;

    void Awake()
    {
        Radio = UnityEngine.Random.Range(-2.3f, -6.1f);
        Div1 = UnityEngine.Random.Range(1.1f, 1.5f);
        Div2 = UnityEngine.Random.Range(1.5f, 2.1f);
        Sol = GameObject.FindWithTag("Sun");
    }
    void Start()
    {
        posX = Sol.transform.position.x + Mathf.Cos(angle) * Radio / Div2;
        posZ = Sol.transform.position.z + Mathf.Sin(angle) * Radio / Div1;
        iniciar = new Vector3(posX, transform.position.y, posZ);
    }
    void Update()
    {
        if (Activar)
        {
            posX = Sol.transform.position.x + Mathf.Cos(angle) * Radio / Div2;
            posZ = Sol.transform.position.z + Mathf.Sin(angle) * Radio / Div1;
            transform.position = new Vector3(posX, transform.position.y, posZ);
            angle = angle + Time.deltaTime * velocidadAngular;
            if (angle >= 360f)
            {
                angle = 0;
            }
        }
        if (diriguirse)
        {
            transform.position = Vector3.MoveTowards(transform.position, iniciar, 2.5f * Time.deltaTime);
        }
        if (transform.position == iniciar)
        {
            Activar = true;
            diriguirse = false;
        }
    }

}
