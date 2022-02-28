using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchscreenscript : MonoBehaviour
{
    private string facename;
    public Camera cam;
    
    void Update () {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        //if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            //Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                facename = Hit.transform.name;
                switch (facename)
                {
                    case ("face1"):
                        break;
                    case ("face2"):
                        Handheld.Vibrate();
                        break;
                    case ("face3"):
                        break;
                    case ("face4"):
                        break;
                    case ("face5"):
                        break;
                    case ("face6"):
                        break;

                }
            }
        }
    }
}