using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiBlastFireOther : MonoBehaviour
{
    public GameObject KiBlast;
    public GameObject Controller;
    public AudioClip KiBlastSound;

    // Start is called before the first frame update
    void Start()
    {

        //KiBlast.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("mouse 1"))
        {
            Fire();
        }
        if (Input.GetKeyDown("joystick button 14"))
        {
            Fire();
        }
    }

    void Fire()
    {
        var kiblast = Instantiate(KiBlast, Controller.transform.position, Controller.transform.rotation);
        kiblast.AddComponent<KiBlastDie>();
        kiblast.GetComponent<Rigidbody>().AddForce(kiblast.transform.forward * 500);
        AudioSource.PlayClipAtPoint(KiBlastSound, Controller.transform.position, .1f);
    }
}
