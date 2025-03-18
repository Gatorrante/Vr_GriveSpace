using UnityEngine;

public class LanzarObjeto : MonoBehaviour
{
    public GameObject Intanciar;
    public int limite;

    void Awake()
    {
        GameObject ObjActual;
        for (int i = 0; i < limite; i++)
        {
            float random = Random.Range(0.05f, 0.11f);
            ObjActual = Instantiate(Intanciar);
            ObjActual.transform.localScale = new Vector3(random, random, random);
        }
        Invoke("Destruir", 0.5f);
    }
    public void Destruir()
    {
        Destroy(gameObject);
    }
}
