using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{

  public GameObject NewSaibaman;
    private GameObject saibaPrefab;
    private float nextSpawnTime;
    [SerializeField]
    private float spawnDelay = 10;

    public AudioClip spawn_sound;
    public AudioClip saiba_death;

  //the enemy script will most likely be the follow player script
  // Start is called before the first frame update
  private void Awake()
  {
    //    var saibamen = Resources.Load <SaibamenFollowScript> ("Resource/saibaman(final)");
    //    saibaPrefab = (saibamen as SaibamenFollowScript).gameObject;
    saibaPrefab = NewSaibaman;
  }


  // Update is called once per frame
  void Update()
    {
      if (ShouldSpawn())
      {
        Spawn();
      }
    }

  private void Spawn()
  {
    nextSpawnTime = Time.time + spawnDelay;
    var objectCreated = Instantiate(saibaPrefab, transform.position, transform.rotation);
    //objectCreated.AddComponent<SaibamenFollowScript>();
        AudioSource.PlayClipAtPoint(spawn_sound, this.transform.position, 1f);
        objectCreated.AddComponent<TakeDamage>().death_sound = saiba_death;

  }

    private bool ShouldSpawn()
  {
    return Time.time >= nextSpawnTime;
  }

}
