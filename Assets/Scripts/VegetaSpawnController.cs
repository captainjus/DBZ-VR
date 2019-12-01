using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VegetaSpawnController : MonoBehaviour
{
    public GameObject Vegeta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Vegeta.activeSelf)
        {
            StartCoroutine(VegetaRespawnTimer());
        }
        else
        {
        }
    }

    IEnumerator VegetaRespawnTimer()
    {
        yield return new WaitForSeconds(10);
        Vegeta.SetActive(true);
    }
}
