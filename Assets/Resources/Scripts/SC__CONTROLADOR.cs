using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SC__CONTROLADOR : MonoBehaviour
{
    public SOSPECHOSO[] SOSPECHOSOX;
    public static SC__CONTROLADOR INSTANCE;
    public int ID ;
    public Image FILLVIDA;

    public SpriteRenderer CHAR;
    public GameObject FACE1;
    public SpriteRenderer CHARFACE1;
    public GameObject FACE2;
    public SpriteRenderer CHARFACE2;
    public GameObject FACE3;
    public SpriteRenderer CHARFACE3;

    public Image CHARHUD;
    public Image HOJAHUD;
    public TextMeshProUGUI TXNOMBRE;
    public TextMeshProUGUI TXPROFESION;

    public TextMeshProUGUI TXPOLICIA;
    public TextMeshProUGUI TXSOSPECHOSO;

    public int DIALOGO;
    public int IDBOTON;
    public GameObject HUDDIALOGO;
    public Animator ANIMHUDGENERAL;
    void Start()
    {
        INSTANCE = this;
    }

    private void Update()
    {
        FILLVIDA.fillAmount = SOSPECHOSOX[ID].CULPABLE / 100F;
        if (SOSPECHOSOX[ID].CULPABLE < 30)
        {
            CHAR.enabled = true;
            FACE1.SetActive(false);
            FACE2.SetActive(false);
            FACE3.SetActive(false);
        }
        if (SOSPECHOSOX[ID].CULPABLE > 30)
        {
            CHAR.enabled = false;
            FACE1.SetActive(true);
            FACE2.SetActive(false);
            FACE3.SetActive(false);
        }
        if (SOSPECHOSOX[ID].CULPABLE > 60)
        {
            CHAR.enabled = false;
            FACE1.SetActive(false);
            FACE2.SetActive(true);
            FACE3.SetActive(false);
        }
        if (SOSPECHOSOX[ID].CULPABLE > 90)
        {
            CHAR.enabled = false;
            FACE1.SetActive(false);
            FACE2.SetActive(false);
            FACE3.SetActive(true);
        }

        
    }

    public void BTPUSHGENERALA()
    {
        IDBOTON = -3;
        if (ID == 0)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "Asi que dime que estabas haciendo ese dia?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Yo fui a animar como costrumbre a la fiesta";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "un uso muy simple me imagino";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                BOTONEXIT();
            }
        }
        if (ID == 1)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "Asi que dime que estabas haciendo ese dia?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Animando la fiesta con bailes de fornite";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "...";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                BOTONEXIT();
            }
        }
        if (ID == 2)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "Asi que dime que estabas haciendo ese dia?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Haciendo mi trabajo que mas";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "...";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                BOTONEXIT();
            }
        }
    }
    public void BTPUSHGENERALB()
    {
        IDBOTON = -2;
        if (ID == 0)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "Donde estabas cuando sucedio el accidente?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Me encontraba en haciendo el espectaculo atras de todos";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "un uso muy simple me imagino";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                BOTONEXIT();
            }
        }
        if (ID == 1)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "Donde estabas cuando sucedio el accidente?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Pues estaba cerca del pastel, creo no es muy facil ver con esto";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "...";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                BOTONEXIT();
            }
        }
        if (ID == 2)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "Donde estabas cuando sucedio el accidente?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Estaba a un costado de los dulces, animando a esos minions";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "...";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                BOTONEXIT();
            }
        }
    }

    public void BTPUSHGENERALC()
    {
        IDBOTON = -1;
        if (ID == 0)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "Que herramientas sueles usar?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Un poco de todo";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "un uso muy simple me imagino";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                BOTONEXIT();
            }
        }
        if (ID == 1)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "Que herramientas sueles usar?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Apenas puedo respirar con esto, asi que nada supongo";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "...";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                BOTONEXIT();
            }
        }
        if (ID == 2)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "Que herramientas sueles usar?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Mis herramientas magicas, todo me sirve";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "...";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                BOTONEXIT();
            }
        }
    }

    public void BTPUSHA()
    {
        IDBOTON = 0;
        if (ID == 0)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "Asi que dime que es lo que haces usualmente con esta botella";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "La uso para mojar a las personas";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "un uso muy simple me imagino";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                BOTONEXIT();
            }
        }
        if (ID == 1)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "Asi que dime que es lo que haces usualmente con esta botella";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Crees que tengo las manos para siquiera tomar algo";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "...";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                BOTONEXIT();
            }
        }
        if (ID == 2)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "Asi que dime que es lo que haces usualmente con esta botella";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Eso no es mio, no se que tratas de probar";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "...";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                BOTONEXIT();
            }
        }
    }
    public void BOTONNEXTPUSH()
    {
        DIALOGO++;

        if (IDBOTON == -3)
        {
            BTPUSHGENERALA();
        }
        if (IDBOTON == -2)
        {
            BTPUSHGENERALB();
        }
        if (IDBOTON == -1)
        {
            BTPUSHGENERALC();
        }
        if (IDBOTON == 0)
        {
            BTPUSHA();
        }
    }

    public void BOTONEXIT()
    {
        IDBOTON = -4;
        DIALOGO = 0;
        HUDDIALOGO.SetActive(false);
        ANIMHUDGENERAL.Play("IN");
    }
}
