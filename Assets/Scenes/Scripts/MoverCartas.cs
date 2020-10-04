using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCartas : MonoBehaviour
{
    public float positionX;
    public float positionY;
    public GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

    private void Update()
    {
        if (gameManager.selection == 1)
        {
            gameObject.transform.position = new Vector2(positionX, positionY);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
 
}
