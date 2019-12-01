using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumLivesScript : MonoBehaviour
{

  Image myImageCompnenet;
  public Sprite ThreeHeartImage;
  public Sprite TwoHeartImage;
  public Sprite OneHeartImage;
  public Sprite ZeroHeartImage;

  //change movement to whatever the player collider script is
  PlayerScript m;

  // Start is called before the first frame update
  void Start()
    {
    myImageCompnenet = GetComponent<Image>();
    m = GameObject.Find("HeadAnchor").GetComponent<PlayerScript>();
  }

    // Update is called once per frame
    void Update()
    {
    UpdateLives();
  }
  public void UpdateLives()
  {
    int Lives = m.GetNumLives();
    if (Lives == 0)
    {
      myImageCompnenet.sprite = ZeroHeartImage;
    }
    else if (Lives == 1)
    {
      myImageCompnenet.sprite = OneHeartImage;
    }
    else if (Lives == 2)
    {
      myImageCompnenet.sprite = TwoHeartImage;
    }
    else if (Lives == 3)
    {
      myImageCompnenet.sprite = ThreeHeartImage;
    }
  }
}
