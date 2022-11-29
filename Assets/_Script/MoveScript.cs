using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Transform myTransform;
    public float degX, degY, degZ;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        myTransform.Translate(degX, degY, degZ);
    }
}
