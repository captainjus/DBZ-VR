using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaibamenFollowScript : MonoBehaviour
{
  public GameObject Player;
  public GameObject audioSource;
  public float movementSpeed = 1f;
  public AudioSource flashbang;
  PlayerScript m;

  void Start()
  {
    Player = GameObject.Find("HeadAnchor");
    audioSource = GameObject.Find("flashbang");
    flashbang = audioSource.GetComponent<AudioSource>();
    m = GameObject.Find("HeadAnchor").GetComponent<PlayerScript>();
  }

  void Update()
  {
    transform.LookAt(Player.transform);
    transform.position += transform.forward * movementSpeed * Time.deltaTime;
    hitPlayer();
  }

  void hitPlayer()
  {
    float dist = Vector3.Distance(Player.transform.position, this.transform.position);
    if(dist <= 2f)
    {
      m.LoseLife();
      //      AudioSource.PlayClipAtPoint(flashbang, this.transform.position, .1f);
      flashbang.Play();
      Destroy(this.gameObject);
    }
  }
}

