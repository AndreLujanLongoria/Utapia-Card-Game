using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esconder : MonoBehaviour
{
    float tiempo = 0;
    public int tiempoActiva = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (tiempo >= tiempoActiva)
        {
            gameObject.SetActive(true);
        }
        else if (tiempoActiva + 4 < tiempo)
        {
            gameObject.SetActive(false);
        }
        tiempo += Time.deltaTime;    
    }
}
