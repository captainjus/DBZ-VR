using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySongButton : MonoBehaviour
{
    int x = 0;
    public AudioClip DragonSoul;
    public AudioClip Ultra;
    public AudioClip Budokai;
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;

       
    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (x == 0)
        {
            GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().clip = DragonSoul;
            GetComponent<AudioSource>().Play();
        }
        if (x == 1)
        {
            GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().clip = Ultra;
            GetComponent<AudioSource>().Play();

        }
        if (x == 2)
        {
            GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().clip = Budokai;
            GetComponent<AudioSource>().Play();

        }
    }
        void OnTriggerExit(Collider other){ 
            x = x + 1;
            if( x > 2)
        {
            x = 0;
        }

        }
    
}
