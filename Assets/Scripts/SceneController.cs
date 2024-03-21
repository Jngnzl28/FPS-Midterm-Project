using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;
    [SerializeField] GameObject enemyPrefab;
    private GameObject enemy;
    public int enemycount = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy == null)
        {

            for (int i = 0; i < enemycount; i++)
            {
                enemy = Instantiate(enemyPrefab) as GameObject;
                enemy.transform.position = new Vector3(Random.Range(-80,80), 5, Random.Range(-60,60));
                float angle = Random.Range(0, 100);
                enemy.transform.Rotate(0, angle, 0);
            }
 
        }
    }
}
