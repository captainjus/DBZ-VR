using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spirtbomb : MonoBehaviour
{

    public GameObject spirtBomb;
    public GameObject Controller;
    public AudioClip KiBlastSound;
    public AudioClip Energy;
    public int x = 0;

    // Start is called before the first frame update
    void Start()
    {

        spirtBomb.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("mouse 0"))
        {
          x++;
          if(x >= 10)
          {
            spirtBomb.SetActive(true);
            x = 0;
            Debug.Log("mouse 0 was pressed");
            Instantiate(spirtBomb, new Vector3(3.4f, 40.78f, -1.5f), Quaternion.identity);

            }
          if(x == 1)
            {
                AudioSource.PlayClipAtPoint(Energy, Controller.transform.position, .1f);
            }
        }
    }

   // void Fire()
    //{
      //  var kiblast = Instantiate(spirtBomb, Controller.transform.position, Controller.transform.rotation);
       // kiblast.AddComponent<KiBlastDie>();
        //kiblast.GetComponent<Rigidbody>().AddForce(kiblast.transform.forward * 500);

    //}
}

