using UnityEngine;

public class OrbitasCometas : MonoBehaviour
{
    public GameObject Sol;

    private float Radio = 60f, velocidadAngular = 0.5f;
    private float posX = 0, posY, posZ, angle = 0f;
    private bool Activar = false, diriguirse = true;
    private Vector3 iniciar;
    private  int TipoOrbita;

    public float Div1, Div2;

    void Awake()
    {
        Div1 = Random.Range(1.5f, 1.9f);
        Div2 = Random.Range(2.1f, 2.4f);
        Sol = GameObject.FindWithTag("Sun");
        TipoOrbita = Random.Range(0,4);
        posY = Random.Range(0.8f, 2.05f);
    }
    void Start()
    {
        Inicio(TipoOrbita);
        Orbita(TipoOrbita);
        Invoke("Destruir", 40);
    }
    void Update()
    {
        if (Activar)
        {
            Orbita(TipoOrbita);
            transform.position = new Vector3(posX, posY, posZ);
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
            for (int i = 0; i < 2; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
    public void Orbita(int valor) 
    {
        switch (valor)
        {
            case 0:
                posX = Sol.transform.position.x + Mathf.Cos(angle) * Radio / Div1;
                posZ = Sol.transform.position.z + Mathf.Sin(angle) * Radio / Div2;
                iniciar = new Vector3(posX, posY, posZ);
                return;
            case 1:
                posZ = Sol.transform.position.z + Mathf.Cos(angle) * Radio / Div1;
                posY = Sol.transform.position.y + Mathf.Sin(angle) * Radio / Div2;
                iniciar = new Vector3(posX, posY, posZ);
                return;
            case 2:
                posX = Sol.transform.position.x + Mathf.Cos(angle) * Radio / -Div1;
                posZ = Sol.transform.position.z + Mathf.Sin(angle) * Radio / Div2;
                iniciar = new Vector3(posX, posY, posZ);
                return;
            case 3:
                posZ = Sol.transform.position.z + Mathf.Cos(angle) * Radio / -Div2;
                posY = Sol.transform.position.y + Mathf.Sin(angle) * Radio / Div1;
                iniciar = new Vector3(posX, posY, posZ);
                return;
        }
    }
    public void Inicio(int valor)
    {
        switch (valor)
        {
            case 0:
                transform.position = new Vector3(19.6f, posY, 5.6f);
                return;
            case 1:
                transform.position = new Vector3(0, posY, 25.2f);
                return;
            case 2:
                transform.position = new Vector3(-19.6f, posY, 5.6f);
                return;
            case 3:
                transform.position = new Vector3(0, posY, -14);
                return;
        }
    }
    public void Destruir()
    {
        Destroy(gameObject);
    }
}
