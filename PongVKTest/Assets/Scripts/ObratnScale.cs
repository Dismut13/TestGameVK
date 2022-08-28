using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObratnScale : MonoBehaviour
{
    public GameObject Scal;
    public GameObject Protiv;
    public string colTag;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == colTag)
        {
            Scal.transform.localScale -= new Vector3(0.05f, 0.3f, 0f);
            Protiv.transform.localScale += new Vector3(0.07f, 0.4f, 0f);
            Destroy(gameObject);
        }
    }
}
