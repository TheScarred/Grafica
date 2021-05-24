using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Vector3 startPos;
    Quaternion startRot;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        startRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;

        transform.position = new Vector3(startPos.x, startPos.y + Mathf.Sin(Time.time) / 10, startPos.z);
        transform.Rotate(Vector3.up * dt * 100);
    }
}
