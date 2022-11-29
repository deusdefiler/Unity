using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslationScript : MonoBehaviour
{
    public Transform myTransform;
    public float MaxDistX, MaxDistY, MaxDistZ;
    public float speedX, speedY, speedZ;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        if (myTransform.position.x > MaxDistX || myTransform.position.x < -MaxDistX) speedX *= -1;
        if (myTransform.position.y > MaxDistY || myTransform.position.y < -MaxDistY) speedY *= -1;
        if (myTransform.position.z > MaxDistZ || myTransform.position.z < -MaxDistZ) speedZ *= -1;
        myTransform.Translate(speedX = dt, speedY = dt, speedZ = dt);
    }
}
