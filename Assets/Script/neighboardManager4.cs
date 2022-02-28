using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class neighboardManager4 : MonoBehaviour
{
    public List<neighboard> neighboards;

    public Material couleurReussite;
    public Material couleurBase;

    [SerializeField] private GameObject canvasNext;
    [SerializeField] private GameObject canvasButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAllEnable())
        {
            if (checkNeighboards())
            {
                ReussiteFeedBack();
            }
            else ResetProperties();
        }
        else ResetProperties();
    }

    private bool isAllEnable()
    {
        foreach (neighboard voisin in neighboards)
        {
            if (!voisin.gameObject.activeSelf) return false;
        }
        return true;
    }

    private bool checkNeighboards()
    {
        for (int i = 0; i < neighboards.Count; i++)
        {
            if (i == 0)
            {
                 if (!checkGoodNeighboards(neighboards[i], neighboards[neighboards.Count-1], neighboards[i+1])) return false;
            }
            
            else if (i == neighboards.Count - 1)
            {
                if (!checkGoodNeighboards(neighboards[i], neighboards[i-1], neighboards[0])) return false;
            }
            
            else
            {
                if(!checkGoodNeighboards(neighboards[i], neighboards[i-1], neighboards[i+1])) return false;
            }
        }

        return true;
    }
    
    private bool checkGoodNeighboards(neighboard main, neighboard bonVoisinDeGauche, neighboard bonVoisinDeDroite )
    {
        if (main.voisinDeGauche != bonVoisinDeGauche)
        {
            return false;
        }
        if (main.voisinDeDroite != bonVoisinDeDroite)
        {
            return false;
        }
        return true;
    }

    private void ReussiteFeedBack()
    {
        Debug.Log("Yes");
        canvasButton.SetActive(true);
    }

    private void ResetProperties()
    {
    }
    
}
