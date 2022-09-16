using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] float degreesPerSecond = 20;

    // Start is called before the first frame update
    void Start()
    {
        //totalMoveDistance = 10f;
        //startingLocation = gameObject.transform.position;
        //enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (this.transform.rotation.eulerAngles.x == 90)
        //    enabled = false;
        transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);
    }
}

