using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Eliminar", 10f);
    }
    public void Eliminar()
    {
        Destroy(gameObject);
    }
}
