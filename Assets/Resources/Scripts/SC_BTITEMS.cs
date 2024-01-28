using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_BTITEMS : MonoBehaviour
{
    public ITEMS[] ITEMSX;

    public int IDBOTON;
    public Image IMGBOTON;

    void Start()
    {
       ITEMSX[0] = ITEMSX[IDBOTON];
       IMGBOTON.sprite = ITEMSX[IDBOTON].IMGITEMS;
    }

    

}
