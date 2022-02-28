using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTouch : MonoBehaviour
{
    private string buttonName;
    public Camera cam;
    public Material RedButtonMat;
    public Material BlackButtonMat;
    public Material IndiceMat;
    
    private int score = 0;
    private bool b1=false;
    private bool b2=false;
    private bool b3=false;
    private bool b4=false;
    private bool b5=false;
    private bool b6=false;

    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;

    public GameObject Indice;

    public AudioClip btnClic;
    public AudioClip Suceed;

    [SerializeField] private GameObject canvas;
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        //if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            //Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                buttonName = Hit.transform.name;
                switch (buttonName)
                {
                    case ("Button1"):
                        Debug.Log("bite");
                        b1=ARButtonClick(Hit, 5, b1);
                        AudioSource.PlayClipAtPoint(btnClic, Hit.transform.position);
                        Light1.SetActive(!Light1.activeSelf);
                        break;
                    case ("Button2"):
                        b2=ARButtonClick(Hit, 10, b2);
                        AudioSource.PlayClipAtPoint(btnClic, Hit.transform.position);
                        Light1.SetActive(!Light1.activeSelf);
                        Light3.SetActive(!Light3.activeSelf);
                        break;
                    case ("Button3"):
                        b3=ARButtonClick(Hit, 15, b3);
                        AudioSource.PlayClipAtPoint(btnClic, Hit.transform.position);
                        Light2.SetActive(!Light2.activeSelf);
                        Light3.SetActive(!Light3.activeSelf);
                        break;
                    case ("Button4"):
                        b4=ARButtonClick(Hit, 20, b4);
                        AudioSource.PlayClipAtPoint(btnClic, Hit.transform.position);
                        Light1.SetActive(!Light1.activeSelf);
                        Light2.SetActive(!Light2.activeSelf);
                        break;
                    case ("Button5"):
                        b5=ARButtonClick(Hit, 25, b5);
                        AudioSource.PlayClipAtPoint(btnClic, Hit.transform.position);
                        Light2.SetActive(!Light2.activeSelf);
                        break;
                    case ("Button6"):
                        b6=ARButtonClick(Hit, 30, b6);
                        AudioSource.PlayClipAtPoint(btnClic, Hit.transform.position);
                        Light3.SetActive(!Light3.activeSelf);
                        break;
                }
                
                if(Light1.activeSelf && Light2.activeSelf && Light3.activeSelf)
                {
                    Indice.GetComponent<Renderer>().material = IndiceMat;
                    AudioSource.PlayClipAtPoint(Suceed, Indice.transform.position);
                    canvas.SetActive(true);
                }
                
                
            }
        }
    }

    private bool ARButtonClick(RaycastHit button, int val, bool bt)
    {
        if (bt == true)
        {
            button.transform.gameObject.GetComponent<Renderer>().material = BlackButtonMat;
            score -= val;
            return false;
        }
        else
        {
            button.transform.gameObject.GetComponent<Renderer>().material = RedButtonMat;
            score += val;
            return true;
        }
    }
}
