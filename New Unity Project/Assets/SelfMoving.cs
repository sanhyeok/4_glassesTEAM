using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfMoving : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;        //회전속도
    private void Update()
    {
        Orbit_Rotation();
    }

    void Orbit_Rotation()
    {
        transform.Rotate(Vector3.down * speed * Time.deltaTime);
        //transform.Rotate(Vector3 EularAngle)
    }
}
