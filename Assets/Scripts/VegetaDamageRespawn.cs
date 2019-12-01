using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VegetaDamageRespawn : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject Vegeta;
    public AudioSource knockout;
    public AudioSource respawn;
    private int damageCounter = 5;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = spawnPoints[(int)Random.Range(0f, 3f)].transform.position;
        respawn.PlayOneShot(respawn.clip);
    }

    private void OnEnable()
    {
        this.transform.position = spawnPoints[(int)Random.Range(0f, 3f)].transform.position;
        respawn.PlayOneShot(respawn.clip);
    }

    // Update is called once per frame
    void Update()
    {

        if (damageCounter == 0)
        {
            if (!knockout.isPlaying)
            {
                knockout.Play();
                StartCoroutine(VoiceWait());
            }
            // do something
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Attack")
        {
            Debug.Log("Vegeta has taken damage!");
            damageCounter--;
            Debug.Log("Vegeta HP at " + damageCounter);
            Destroy(other.gameObject);
        }

    }

    IEnumerator VoiceWait()
    {
        yield return new WaitForSeconds(knockout.clip.length);
        damageCounter = 5;
        this.gameObject.SetActive(false);
    }
}
