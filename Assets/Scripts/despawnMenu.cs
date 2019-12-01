using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawnMenu : MonoBehaviour
{
    public GameObject difficulty;
    public GameObject tutorial;
    public GameObject menu;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        difficulty.SetActive(true);
        tutorial.SetActive(false);
        menu.SetActive(false);

    }
}
