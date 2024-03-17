using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    //Buralara tabaklari lavaboya surukleme kodu gelecek, eventmanageri halledemedim :(
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("BeginDrag");
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("CLICK");
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("EndDrag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("CLICK");
    }
}
