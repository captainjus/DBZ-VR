using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NappaRespawn : MonoBehaviour
{
    public GameObject Nappa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        Debug.Log("Script enabled");
        StartCoroutine(RespawnTimer());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator RespawnTimer()
    {
        yield return new WaitForSeconds(7);
        Nappa.GetComponent<Rigidbody>().useGravity = false;
        Nappa.transform.localPosition = new Vector3(Nappa.transform.localPosition.x, -7.0f, Nappa.transform.localPosition.z);
        Nappa.transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);
        Nappa.GetComponent<NappaFollowScript>().enabled = true;

        this.GetComponent<AudioSource>().Play();
        this.GetComponent<NappaRespawn>().enabled = false;


    }
}
