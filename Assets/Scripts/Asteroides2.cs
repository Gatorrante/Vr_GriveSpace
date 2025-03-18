using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Asteroides2 : MonoBehaviour
{
    private int Orientacion;
    private float posX, posY, posZ;
    private float velocidad;

    void Awake()
    {
        Orientacion = Random.Range(0,4);
        posX = Random.Range(-14.6f,14.6f);
        posY = Random.Range(0.31f,4);
        posZ = Random.Range(-9, 20.2f);
    }
    void Start()
    {
        Inicio(Orientacion);
        velocidad = Random.Range(0.5f, 1.2f);
        Invoke("Destruir", 35);
    }
    void Update()
    {
        switch (Orientacion)
        {
            case 0:
                transform.position += new Vector3(0,0,velocidad * Time.deltaTime);
                return;
            case 1:
                transform.position += new Vector3(velocidad * Time.deltaTime, 0, 0);
                return;
            case 2:
                transform.position -= new Vector3(0, 0, velocidad * Time.deltaTime);
                return;
            case 3:
                transform.position -= new Vector3(velocidad * Time.deltaTime, 0, 0);
                return;
        }
    }
    public void Inicio(int valor)
    {
        switch (valor)
        {
            case 0:
                transform.position = new Vector3(posX, posY, -10);
                return;
            case 1:
                transform.position = new Vector3(-14.6f, posY, posZ);
                return;
            case 2:
                transform.position = new Vector3(posX, posY, 21.2f);
                return;
            case 3:
                transform.position = new Vector3(14.6f, posY, posZ);
                return;
        }
    }
    public void Destruir()
    {
        Destroy(gameObject);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Astronomos"))
        {
            transform.position = Vector3.MoveTowards(transform.position, other.gameObject.transform.position, 0.4f * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Planeta"))
        {
            Destruir();
        }
    }
}
