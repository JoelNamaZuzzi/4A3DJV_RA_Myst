using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchscreenscript : MonoBehaviour
{
    private string facename;
    public Camera cam;
    
    void Update () {
        //Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began
        if (Input.GetMouseButtonDown(0))
        {
            //Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            
            RaycastHit Hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out Hit))
            {
                facename = Hit.transform.name;
                switch (facename)
                {
                    case ("face1"):
                        Debug.Log("Bite! 1");
                        break;
                    case ("face2"):
                        Debug.Log("Bite! 2");
                        break;
                    case ("face3"):
                        Debug.Log("Bite! 3");
                        break;
                    case ("face4"):
                        Debug.Log("Bite! 4");
                        break;
                    case ("face5"):
                        Debug.Log("Bite! 5");
                        break;
                    case ("face6"):
                        Debug.Log("Bite! 6");
                        break;

                }
            }
        }
    }
}