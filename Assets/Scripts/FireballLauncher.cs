using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballLauncher : MonoBehaviour
{
    public Transform FireballSpawnPoint;
    public GameObject FireballSpawnPointPrefab;
    public float FireballSpeed = 10f;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var Fireball = Instantiate(FireballSpawnPointPrefab, FireballSpawnPoint.position, FireballSpawnPoint.rotation);
            Fireball.GetComponent<Rigidbody>().velocity = FireballSpawnPoint.forward * FireballSpeed;
        }

    }
}
