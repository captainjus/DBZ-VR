using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiBlastAI : MonoBehaviour
{
    public GameObject Player;
    public AudioClip KiClash;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("HeadAnchor");
        Debug.Log(this.gameObject.name);
        if (this.gameObject.name != "VegetaBlast (1)")
        {
            this.transform.LookAt(Player.transform);
            this.GetComponent<Rigidbody>().AddForce(this.transform.forward * 300);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name != "VegetaBlast (1)")
            StartCoroutine(SelfDestroy());

        HurtPlayer();
    }

    IEnumerator SelfDestroy()
    {
        yield return new WaitForSeconds(6);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Attack")
        {
            AudioSource.PlayClipAtPoint(KiClash, this.transform.position);
            //Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag == "Player")
        {

        }
    }

    private void HurtPlayer()
    {
        float dist = Vector3.Distance(this.gameObject.transform.position, Player.transform.position);
        if (dist <= 1f)
        {
            Player.GetComponent<PlayerScript>().LoseLife();
            AudioSource.PlayClipAtPoint(KiClash, this.transform.position);
            Destroy(this.gameObject);
        }
    }
}
