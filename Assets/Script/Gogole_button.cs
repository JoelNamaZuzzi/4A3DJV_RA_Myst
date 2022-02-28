using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Gogole_button : MonoBehaviour
{
    [SerializeField]
    private GameObject site_canvas;
    
    [SerializeField]
    private GameObject search_canvas;
    
    [SerializeField]
    private GameObject search_content;
    
    [SerializeField]
    private GameObject open_button;
    
    [SerializeField]
    private GameObject searchField;
    
    [SerializeField]
    private GameObject errorText;
    
    [SerializeField]
    private GameObject image;
    [SerializeField]
    private GameObject image2;
    [SerializeField]
    private GameObject image3;
    [SerializeField]
    private GameObject image4;
    [SerializeField]
    private GameObject image5;
    [SerializeField]
    private GameObject image6;
    

    private string SearchText;

    private int site = 0;
    private int id_image = 0;

    public void Start()
    {
        image.SetActive(false);
        image2.SetActive(false);
        image3.SetActive(false);
        image4.SetActive(false);
        image5.SetActive(false);
        image6.SetActive(false);
        
        site_canvas.SetActive(false);
        search_canvas.SetActive(false);
    }

    public void Update()
    {
        
    }

    public void Close_Window()
    {
        Debug.Log("Quit");
        site_canvas.SetActive(false);
        open_button.SetActive(true);
    }

    public void Search()
    {
        SearchText = searchField.GetComponent<TMP_InputField>().text;
        
        if (SearchText.Equals("test"))
        {
            Debug.Log("ok");
            site_canvas.SetActive(false);
            search_canvas.SetActive(true);
        }
        else
        {
            Debug.LogWarningFormat("ko");
            errorText.SetActive(true);
        }
    }
    
    public void openSite(){
        Debug.Log("Open");
        site_canvas.SetActive(true);
        open_button.SetActive(false);
    }

    public void backButton()
    {
        if (site == 1)
        {
            search_content.SetActive(true);
            site = 0;
            
            if (id_image == 0)
            {
                image.SetActive(false);
            }
        
            if (id_image == 1)
            {
                image2.SetActive(false);
            }
        
            if (id_image == 2)
            {
                image3.SetActive(false);
            }
        
            if (id_image == 3)
            {
                image4.SetActive(false);
            }
        
            if (id_image == 4)
            {
                image5.SetActive(false);
            }
        
            if (id_image == 5)
            {
                image6.SetActive(false);
            }
        }
        else
        {
            site_canvas.SetActive(true);
            search_canvas.SetActive(false);
        }
    }

    public void clickImage(int id)
    {
        site = 1;
        search_content.SetActive(false);

        if (id == 0)
        {
            id_image = id;
            Debug.Log("nop");
            image.SetActive(true);
        }
        
        if (id == 1)
        {
            id_image = id;
            Debug.Log("nop");
            image2.SetActive(true);
        }
        
        if (id == 2)
        {
            id_image = id;
            Debug.Log("nop");
            image3.SetActive(true);
        }
        
        if (id == 3)
        {
            id_image = id;
            Debug.Log("nop");
            image4.SetActive(true);
        }
        
        if (id == 4)
        {
            id_image = id;
            Debug.Log("noice"); 
            image5.SetActive(true);
        }
        
        if (id == 5)
        {
            id_image = id;
            Debug.Log("nop"); 
            image6.SetActive(true);
        }
        
    }
}
