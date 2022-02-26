using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTouch : MonoBehaviour
{
    private string buttonName;
    public Camera cam;
    public Material RedButtonMat;
    public Material BlackButtonMat;

    
    void Update()
    {
        //if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        if (Input.GetMouseButtonDown(0))
        {
            //Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            
            RaycastHit Hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out Hit))
            {
                buttonName = Hit.transform.name;
                switch (buttonName)
                {
                    case ("Button1"):
                        Debug.Log("Bite! 1");
                        break;
                    case ("Button2"):
                        Debug.Log("Bite! 2");
                        break;
                    case ("Button3"):
                        Debug.Log("Bite! 3");
                        break;
                    case ("Button4"):
                        Debug.Log("Bite! 4");
                        break;
                    case ("Button5"):
                        Debug.Log("Bite! 5");
                        break;
                    case ("Button6"):
                        Debug.Log("Bite! 6");
                        break;

                }
            }
        }
    }
}
