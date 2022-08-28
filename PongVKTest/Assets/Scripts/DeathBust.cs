using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBust : MonoBehaviour
{
    public GameObject Sca;
    public GameObject Prot;
    public string coTag;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == coTag)
        {
            Sca.transform.localScale += new Vector3(0.07f, 0.4f, 0f);
            Prot.transform.localScale -= new Vector3(0.05f, 0.3f, 0f);
            Destroy(gameObject);
        }
    }
}
