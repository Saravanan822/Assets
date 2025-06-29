using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ThrowScript : MonoBehaviour
{

    public Vector3 targetPosition;
    Vector3 startPos;
    Rigidbody rb;
    public float t = 2f;

    bool canThrow;
    bool isLineAvaliable;
    public LineRenderer lineRenderer;
    Vector3 wallHIt;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.Lerp(transform.position,targetPosition,Time.deltaTime);

        if (Input.touchCount > 0) canThrow = true;
        else canThrow = false;

        if (canThrow)
        {
            var pos1 = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;
            if (Physics.Raycast(pos1, out hit))
            {
                lineRenderer.gameObject.SetActive(true);
                wallHIt = hit.point;
                isLineAvaliable = true;
                UpdateLinePos();
                //ball.Pos = hit.point;
                //ball.Throw();
                Debug.Log("ihhjh " + hit.point);

            }
            else
            {
                lineRenderer.gameObject.SetActive(false);
                isLineAvaliable = false;
            }
        }
        else
        {
            if (isLineAvaliable) {
                rb = GetComponent<Rigidbody>();
                rb.isKinematic = false;

                var velocity1 = (wallHIt - (transform.position + (Physics.gravity * 0.5f * (t * t)))) / t;

                rb.AddForce(velocity1, ForceMode.Impulse);
                lineRenderer.gameObject.SetActive(false);
                isLineAvaliable = false;
            }
        }
    }

    public void UpdateLinePos()
    {
        var vel = (wallHIt - (transform.position + (Physics.gravity * 0.5f * (t * t)))) / t;
        for (int i = 0; i <= 20; i++)
        {
            var pos = (transform.position + (vel *  (i / 10f))  +(Physics.gravity * 0.5f * ((i / 10f) * (i / 10f))));
            lineRenderer.SetPosition(i, pos);
        }
    }
}
