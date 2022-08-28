using System.Collections;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float Spee;

    void FixedUpdate()
    {
        transform.Rotate(new Vector3 (0, 0, 45) * Spee * Time.deltaTime);
    }
}
