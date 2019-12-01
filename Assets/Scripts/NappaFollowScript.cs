using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NappaFollowScript : MonoBehaviour
{
  public GameObject Player;
  public GameObject Nappa;
  public float movementSpeed = 500f;
  public int numLives = 10;
  public AudioClip greeting_sound;
  public AudioClip death_sound;

    public GameObject spawnController;


  void Start()
  {
    //Player = GameObject.Find("EyeCamera");
        Player = GameObject.Find("HeadAnchor");
        this.GetComponent<AudioSource>().Play();
  }

  void OnEnable()
  {
      //  Player = GameObject.Find("EyeCamera");
        Player = GameObject.Find("HeadAnchor");
    }

  void Update()
  {
    transform.LookAt(Player.transform);
    //    transform.position += transform.forward * movementSpeed * Time.deltaTime;
    Nappa.GetComponent<Rigidbody>().AddForce(Nappa.transform.forward * movementSpeed);
    checkDeath();
        checkKill();
  }

  private void OnTriggerEnter(Collider other)
  {
    Debug.Log(other.gameObject.tag);
    if (other.tag == "Attack")
    {
      numLives--;
      Destroy(other.gameObject);

    }
  }

  private void checkDeath()
  {
    if(numLives <= 0)
    {
      this.GetComponent<NappaFollowScript>().enabled = false;
      AudioSource.PlayClipAtPoint(death_sound, this.transform.position, 1f);
      Nappa.GetComponent<Rigidbody>().useGravity = true;
      numLives = 10;
      spawnController.GetComponent<NappaRespawn>().enabled = true;
    }
  }

    private void checkKill()
    {
        float dist = Vector3.Distance(Player.transform.position, this.gameObject.transform.position);
        if(dist <= 1f)
        {
            Player.GetComponent<PlayerScript>().LoseLife();
        }
    }
}
