using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public AudioClip death_sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if(other.tag == "Attack")
        {
            this.GetComponent<SaibamenFollowScript>().enabled = false;
            AudioSource.PlayClipAtPoint(death_sound, this.transform.position, 1f);
            Destroy(other.gameObject);
            StartCoroutine(DieWait());
        }
    }

    IEnumerator DieWait()
    {
        yield return new WaitForSeconds(death_sound.length);
        Destroy(this.gameObject);
    }
}
