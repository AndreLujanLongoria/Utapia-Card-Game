using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int selection = 0;
    public GameObject texto1;
    public GameObject texto2;

    public TextMeshProUGUI scoreText;

    bool on = true;
    bool off = false;
    bool change;

    float timer = 0;

    int score = 20;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5)
        {
            texto1.SetActive(off);
            texto2.SetActive(on);

            change = on;
            on = off;
            off = change;

            timer = 0;

            if(on == true)
            {
                scoreText.text = "Score: " + score;
                score += Random.Range(5, 30);
            }
            
        }
    }
    public void updateSelection(int valor)
    {
        selection += valor;
    }


}
