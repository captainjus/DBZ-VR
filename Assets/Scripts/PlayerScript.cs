using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
  public int numLives;
  PlayerScript m;
  // Start is called before the first frame update
  void Start()
  {
    numLives = 3;
    m = GameObject.Find("HeadAnchor").GetComponent<PlayerScript>();
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
    if(numLives == 0)
    {
      restartScene();
    }
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
