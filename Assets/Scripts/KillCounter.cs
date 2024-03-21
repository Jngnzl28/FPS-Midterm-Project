using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KillCounter : MonoBehaviour
{
    [SerializeField] TMP_Text counterText;
    int kills;

    private void showKills()
    {
        counterText.text = $"Kills: {kills}";
    }
    public void addKills()
    {
        kills += 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        showKills();        
    }
}
