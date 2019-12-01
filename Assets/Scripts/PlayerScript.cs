using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
  public int numLives;
  PlayerScript m;
  public GameObject audioSource;
  public AudioSource gameOver;
  // Start is called before the first frame update
  void Start()
  {
    numLives = 3;
    m = GameObject.Find("HeadAnchor").GetComponent<PlayerScript>();
    audioSource = GameObject.Find("gameover");
    gameOver = audioSource.GetComponent<AudioSource>();
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEnter(Collider other)
  {
    if (other.tag != "Safe")
    {
      LoseLife();
    }
  }

  void OnCollisionEnter(Collider other)
  {
    if (other.tag != "Safe")
    {
      LoseLife();
    }
  }
  public void LoseLife()
  {
    numLives--;
        if (numLives == 0)
        {
            if (!gameOver.isPlaying)
            {
                gameOver.Play();
                StartCoroutine(GameOverSound());

            }
        }
    
  }

    IEnumerator GameOverSound()
    {
        yield return new WaitForSeconds(gameOver.clip.length);
        restartScene();
    }

  public int GetNumLives()
  {
    return numLives;
  }

  public void restartScene()
  {
    Scene scene = SceneManager.GetActiveScene();
    SceneManager.LoadScene(scene.name);
  }
}
