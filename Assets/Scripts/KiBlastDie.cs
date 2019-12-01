using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiBlastDie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(despawn());
    }

    IEnumerator despawn()
    {
        yield return new WaitForSeconds(4);
        Destroy(this.gameObject);
    }
}
