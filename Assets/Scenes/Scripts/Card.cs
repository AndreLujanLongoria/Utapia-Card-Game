using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject esconderPrimero;
    public GameObject esconderSegundo;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnMouseDown() //Cuando el mouse esta dentro del objeto lo borras
    {
        gameObject.transform.position = new Vector2(-2, 0);
        gameManager.updateSelection(1);
        esconderPrimero.SetActive(false);
        esconderSegundo.SetActive(true);
    }
}
