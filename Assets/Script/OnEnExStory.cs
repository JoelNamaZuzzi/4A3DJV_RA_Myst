using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnExStory : MonoBehaviour
{
    public GameObject TalkyWaky;
    void EnterTalky()
    {
        TalkyWaky.SetActive(true);
    }

    void ExitTalky()
    {
        TalkyWaky.SetActive(false);
    }
}
