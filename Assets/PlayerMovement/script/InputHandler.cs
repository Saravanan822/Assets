using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputHandler : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IDragHandler
{
    public bool onMouseDown;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("khnhj base");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("khnhj ");
    }

    public virtual void OnPointerUp(PointerEventData eventData)
    {
    }

    public virtual void OnDrag(PointerEventData eventData)
    {
    }
}
