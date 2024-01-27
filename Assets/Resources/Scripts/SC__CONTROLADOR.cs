using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SC__CONTROLADOR : MonoBehaviour
{
    public static SC__CONTROLADOR INSTANCE;
    public int ID;
    public Image FOTO2D;
    public SpriteRenderer CHAR;

    public Image CHARHUD;
    public TextMeshProUGUI TXNOMBRE;
    public TextMeshProUGUI TXPROFESION;
    void Start()
    {
        INSTANCE = this;
    }

}
