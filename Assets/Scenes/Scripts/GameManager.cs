using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int selection = 0;
    float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
    }
    public void updateSelection(int valor)
    {
        selection++;
    }

}
