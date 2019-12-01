using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaibamanSounds : MonoBehaviour
{
    public AudioClip spawn_sound;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(spawn_sound, this.transform.position, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
