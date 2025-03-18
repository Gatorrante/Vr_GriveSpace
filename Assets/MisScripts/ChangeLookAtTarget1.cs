using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLookAtTarget1 : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = this.gameObject;
            Debug.Log ("ChangeLookAtTarget1 target not specified. Defaulting to parent GameObject");
        }
        
    }

    // Update is called once per frame
    void OnMouseDown() 
    {
        LookAtTargetObject.target = target;
        Camera.main.fieldOfView = 60*target.transform.localScale.x;
    }
    
        
}
