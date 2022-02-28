using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neighboardDetector : MonoBehaviour
{
    public neighboard info;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (info && !info.gameObject.activeSelf)
        {
            info = null;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        neighboard target;
        other.TryGetComponent<neighboard>(out target);
        if (target)
        {
            info = target;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        neighboard target;
        other.TryGetComponent<neighboard>(out target);
        if (target == info)
        {
            info = null;
        }
    }
    
}
