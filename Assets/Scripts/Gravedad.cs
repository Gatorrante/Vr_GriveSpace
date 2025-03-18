using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravedad : MonoBehaviour
{
    public float intencidad;

    private Vector3 pullForce;
    
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Astronomos"))
        {
            transform.parent.gameObject.GetComponent<OrbitasPlanetas>().PlanetaAtraido = other.gameObject.transform.parent.gameObject;
            transform.parent.gameObject.GetComponent<OrbitasPlanetas>().Gravedad = true;
        }
    }
}
