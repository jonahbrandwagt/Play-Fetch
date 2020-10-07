using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float shootDelay = 250;
    private float delay;
    private bool dogHere;

    // Update is called once per frame
    void Update()
    {
        if (dogHere == true)
        {
            delay++;
            if (delay > shootDelay)
            {
                delay = 0;
                dogHere = false;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                dogHere = true;
            }
        }
    }
}
