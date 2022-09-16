using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;

    // Start is called before the first frame update
    void Start()
    {
        objectToActivate.GetComponent<MoveObject>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //objectToActivate.GetComponent<MoveObject>().enabled = true;
    }

    void OnTriggerEnter(){
        //print("true");
        objectToActivate.GetComponent<MoveObject>().enabled = true;
    }

    void OnTriggerExit(){
        objectToActivate.GetComponent<MoveObject>().enabled = true;
    }
}