using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawn : MonoBehaviour
{
    public GameObject enviorment;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        enviorment.SetActive(false);

    }
}
