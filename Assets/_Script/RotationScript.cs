using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    public Transform myTransform;
    public float degX, degY, degZ;
    // Start is called before the first frame update
    void Start()
    {
        //myTransform = GetComponent<Transform>();
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        myTransform.Rotate(degX, degY, degZ);
    }
}
