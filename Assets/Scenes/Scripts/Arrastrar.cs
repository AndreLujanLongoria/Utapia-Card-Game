using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Arrastrar : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    //Transform pointOfReturn = null;
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Empiezo a arrastrar");
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
        Debug.Log("Estoy arrastradno");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("termine de arrastrar");
    }
}
