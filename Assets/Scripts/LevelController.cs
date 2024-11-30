using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public Transform spawnPoint;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<HealthController>().Dead += Respawn;
    }

    private void Respawn()
    {
        player.transform.position = spawnPoint.position;
    }
}
