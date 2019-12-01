using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VegetaFirePattern : MonoBehaviour
{
    public GameObject VegetaBlast;
    public GameObject Vegeta;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FirePattern());

    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator FirePattern()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            Instantiate(VegetaBlast, Vegeta.transform.position, Vegeta.transform.rotation);

            yield return new WaitForSeconds(2f);
            Instantiate(VegetaBlast, Vegeta.transform.position, Vegeta.transform.rotation);

            yield return new WaitForSeconds(5f);
            Instantiate(VegetaBlast, Vegeta.transform.position, Vegeta.transform.rotation);
        }
    }
}
