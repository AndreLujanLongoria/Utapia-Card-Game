using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoController : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    float m_Timer;
    public CanvasGroup texto; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_Timer += Time.deltaTime;
        texto.alpha = 1;
    }
}
