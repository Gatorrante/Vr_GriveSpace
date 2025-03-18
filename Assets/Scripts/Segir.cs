using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segir : MonoBehaviour
{
    public Transform Planeta;
    void Update()
    {
        transform.position = Planeta.position;
    }
}
