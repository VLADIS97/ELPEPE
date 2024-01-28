using UnityEngine;
[CreateAssetMenu(fileName = "Items Data", menuName = "Items System/Create Items", order = 0)]
public class ITEMS : ScriptableObject
{
    public static ITEMS INSTANCE;

    [Header(("IMAGENES DEL HUD"))]
    public int ID;
    public string NOMBREDELITEM;
    public string INFORMACIONDELITEM;
    public Sprite IMGITEMS;

    public void Awake()
    {
        INSTANCE = this;
    }
}
