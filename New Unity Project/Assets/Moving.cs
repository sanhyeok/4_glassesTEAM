using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Planet;       //기준행성
    public float speed;             //회전 속도

    private void Update()
    {
        OrbitAround();
    }

    void OrbitAround()
    {
        transform.RotateAround(Planet.transform.position, Vector3.down, speed * Time.deltaTime);
    }
    // RotateAround(Vector3 point, Vector3 axis, float angle)
}
