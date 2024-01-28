using UnityEngine;
[CreateAssetMenu(fileName = "Sospechoso Data", menuName = "Sospechoso System/Create Sospechoso", order = 0)]
public class SOSPECHOSO : ScriptableObject
{
    public static SOSPECHOSO INSTANCE;

    [Header(("IMAGENES DEL HUD"))]
    public int ID;
    public string NOMBREDELSOSPECHOSO;
    public string PROFESIONDELSOSPECHOSO;
    public string INFORMACIONDELSOSPECHOSO;
    public int CULPABLE;
    public Sprite SOSPECHOSOHUD;
    public Sprite SOSPECHOSOHOJA;
    public Sprite CHARNEUTRAL;
    public Sprite FACE1;
    public Sprite FACE2;
    public Sprite FACE3;

    public void Awake()
    {
        INSTANCE = this;
    }
}