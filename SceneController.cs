using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using TMPro;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;
    [SerializeField] GameObject enemyPrefab;
    public GameObject enemy;
    public int enemycount = 10;
    
    void Start()
    {
        if (enemy == null)
        {
            for(int i= 0; i <= enemycount; i++)
            {
                enemy = Instantiate(enemyPrefab) as GameObject;
                enemy.transform.position = new Vector3(Random.Range(0, 20), 5, 0);
                float angle = Random.Range(0, 360);
                enemy.transform.Rotate(0, angle, 0);            
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
