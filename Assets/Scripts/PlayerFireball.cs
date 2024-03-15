using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireball : MonoBehaviour
{
    public float life = 3f;
    
    private void Update()
    {
        Destroy(gameObject, life);
    }
    void OnTriggerEnter(Collider collision)
    { 
        ReactiveTarget target = collision.GetComponent<ReactiveTarget>();

        if (target != null)
        {
            target.ReactToHit();
            Destroy(this.gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }

    }
        



}
