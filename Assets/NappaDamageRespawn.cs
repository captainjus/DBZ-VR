using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NappaDamageRespawn : MonoBehaviour
{
    public GameObject Nappa;
    public AudioSource respawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Nappa.GetComponent<Rigidbody>().useGravity == true)
        {
            if (!respawn.isPlaying)
            {
                respawn.Play();
                StartCoroutine(NappaDespawn());
            }
        }

        IEnumerator NappaDespawn()
        {
            yield return new WaitForSeconds(respawn.clip.length);
            Nappa.gameObject.SetActive(false);
        }
    }
}
