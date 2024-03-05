using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    private int health;


    [SerializeField] TMP_Text healtLabel;
    void Start()
    {
        health = 5;
    }

    public void Hurt(int damage)
    {
        health -= damage;
        healtLabel.text = $"Player Health: {health}";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
