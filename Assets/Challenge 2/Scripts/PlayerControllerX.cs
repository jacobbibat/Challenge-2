using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnCooldown = 1.6f;
    private float spawnTime = 0.0f;


    // Update is called once per frame
    void Update()
    {
        spawnTime += Time.deltaTime; // When spacebar is pressed and the time between the last spawn is >= cooldown time, Input can be executed
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && spawnTime >= spawnCooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            spawnTime = 0.0f; // Reset's timer to 0 seconds
        }
    }
}
