using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neighboard : MonoBehaviour
{
    [SerializeField]private neighboardDetector detecteurGauche;
    [SerializeField]private neighboardDetector detecteurDroite;
    
    [Header("RealTime Value")]
    public neighboard voisinDeDroite;
    public neighboard voisinDeGauche;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        voisinDeDroite = detecteurDroite.info;
        voisinDeGauche = detecteurGauche.info;
    }

    private void OnDisable()
    {
        detecteurGauche.info = null;
        detecteurDroite.info = null;
    }
}
