using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRocks : MonoBehaviour
{
    public GameObject rocks;
    public GameObject enviorment;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        rocks.SetActive(true);
        enviorment.SetActive(false);

    }
}
