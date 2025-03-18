using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionAnillo : MonoBehaviour
{
    public GameObject pivote;
    public float velocidad;
    void Update()
    {
        transform.RotateAround(pivote.transform.position, Vector3.up, velocidad * Time.deltaTime);
    }
}
