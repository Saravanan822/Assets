using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Ball ball;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("touch " + Input.touchCount);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hyu");
        //ball.ResetPos();
    }
    private void OnMouseDown()
    {
        //Debug.Log("ihhjh 1 " + Input.touches[0].position);

        //var pos1 = Camera.main.ScreenPointToRay(Input.touches[0].position);
        //RaycastHit hit;
        //if (Physics.Raycast(pos1, out hit)) {
            //ball.Pos = hit.point;
            //ball.Throw();
            //Debug.Log("ihhjh " + hit.point);

        //}
        
    }
}
