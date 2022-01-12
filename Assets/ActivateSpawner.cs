using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSpawner : MonoBehaviour
{
    public AIsponer spawnerToActivate1;
    public AIsponer spawnerToActivate2;
    bool spawnerIsActivated;
    // Start is called before the first frame update
    void Start()
    {
        spawnerToActivate1.enabled = false;
        spawnerToActivate2.enabled = false;
        spawnerIsActivated = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && spawnerIsActivated == false)
        {
            spawnerToActivate1.enabled = true;
            spawnerToActivate2.enabled = true;
            spawnerIsActivated = true;
        }
    }
}
