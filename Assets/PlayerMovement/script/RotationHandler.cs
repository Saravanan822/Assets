using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotationHandler : InputHandler
{
    public static Vector2 RotationVector;
    int pointerId;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        if (!onMouseDown && eventData.position.x > Screen.width / 2)
        {
            onMouseDown = true;
            pointerId = eventData.pointerId;
        }
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        if (onMouseDown)
        {
            onMouseDown = false;
            RotationVector = Vector2.zero;
        }
    }
    public override void OnDrag(PointerEventData eventData)
    {
        if(onMouseDown && eventData.pointerId == pointerId )
        {
            RotationVector = eventData.delta; 
        }
        
    }

}
