using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ball : MonoBehaviour
{
    public Wall wall;
    public Vector3 Pos;
    Rigidbody rb;
    bool isActive;
    
    public LineRenderer lineRenderer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lineRenderer.positionCount = 21;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && !isActive)
        {
            isActive = true;
            Throw();
        }
        

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hyu");
        ResetPos();
    }

    public void Throw()
    {
        gameObject.AddComponent<ThrowScript>().lineRenderer = lineRenderer;
    }
    public void ResetPos()
    {
        transform.position = new Vector3 (0, 0.605f, -13.4f);
        Destroy(gameObject.GetComponent<ThrowScript>());
        rb.isKinematic = true;
        isActive = false;

    }


}
