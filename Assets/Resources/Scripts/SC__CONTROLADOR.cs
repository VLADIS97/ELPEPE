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
        SOSPECHOSOX[0].CULPABLE = 0;
        SOSPECHOSOX[1].CULPABLE = 0;
        SOSPECHOSOX[2].CULPABLE = 0;
    }

    private void Update()
    {
        FILLVIDA.fillAmount = SOSPECHOSOX[ID].CULPABLE / 100F;
        if (SOSPECHOSOX[ID].CULPABLE < 28)
        {
            CHAR.enabled = true;
            FACE1.SetActive(false);
            FACE2.SetActive(false);
            FACE3.SetActive(false);
        }
        if (SOSPECHOSOX[ID].CULPABLE > 29)
        {
            CHAR.enabled = false;
            FACE1.SetActive(true);
            FACE2.SetActive(false);
            FACE3.SetActive(false);
        }
        if (SOSPECHOSOX[ID].CULPABLE > 59)
        {
            CHAR.enabled = false;
            FACE1.SetActive(false);
            FACE2.SetActive(true);
            FACE3.SetActive(false);
        }
        if (SOSPECHOSOX[ID].CULPABLE >89)
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
        string general = "¿Donde estabas en el incidente?";
        if (ID == 0)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = ""+general;
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Señor detective, ya se lo dije a los policías, yo no fui, debe creerme por favor, necesito dar otros 2 shows a las 5 y a las 7";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Solo responda la pregunta";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Esta bien pero espero no demore demasiado, me encontraba haciendo mis payasadas, rociando con agua a los invitados de la fiesta.";
            }
            if (DIALOGO == 4)
            {
                BOTONEXIT();
            }
        }
        if (ID == 1)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "" + general;
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
                TXPOLICIA.text = "" + general;
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
        string general = "¿Cuando te diste cuenta de que del suceso?";
        if (ID == 0)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = ""+general;
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "fue justo despues de que rompiera la piñata con los niños";
            }
            if (DIALOGO == 2)
            {
                BOTONEXIT();
            }

        }
        if (ID == 1)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "" + general;
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
                TXPOLICIA.text = "" + general;
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
        string general = "¿¿Cual es su relacion con el pequeño Timmy??";
        if (ID == 0)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = ""+general;
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Señor detective porfavor, llegare tarde";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Solo responda";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "por favor creame solo soy un payaso que no hace daño a nadie, solo me contratan para hacer payasadas, ya sabe, unos chistes malos por aqui, pollos de hule por aca,etc.";
            }
            if (DIALOGO == 4)
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

    public void BTPUSH1()//agua
    {
        IDBOTON = 0;
        if (ID == 0)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "¿Reconoces esto? lo ecnontramos cerca de la escena?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Si, es mi rociador de agua";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar ¿por que esta manchado de pastel? pudiste haber arrojado al pequeño Timmy a su pastel y al momento de huir dejaste caer tu objeto ¿no es asi? ¡¡¡PAYASO!!!";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "no, se equivoca yo no fui.";
            }
            if (DIALOGO == 4)
            {
                BOTONEXIT();
            }
        }
        if (ID == 1)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "¿Reconoces esto? lo ecnontramos cerca de la escena?";
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
                TXPOLICIA.text = "¿Reconoces esto? lo ecnontramos cerca de la escena?";
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
    public void BTPUSH2()//rociador de agua
    {
        IDBOTON = 1;
        if (ID == 0)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "¿Reconoces esto? lo ecnontramos cerca de la escena?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Si, es mi rociador de agua";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar ¿por que esta manchado de pastel? pudiste haber arrojado al pequeño Timmy a su pastel y al momento de huir dejaste caer tu objeto ¿no es asi? ¡¡¡PAYASO!!!";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "no, se equivoca yo no fui.";
            }
            if (DIALOGO == 4)
            {
                SOSPECHOSOX[0].CULPABLE = SOSPECHOSOX[0].CULPABLE + 30;
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
    public void BTPUSH3()//cartas
    {
        IDBOTON = 2;
        if (ID == 0)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "¿Reconoces esto? lo ecnontramos cerca de la escena?";
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

    public void BTPUSH4()//peluche
    {
        IDBOTON = 3;
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

    public void BTPUSH5()//flores
    {
        IDBOTON = 4;
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

    public void BTPUSH6()//respirador de asma
    {
        IDBOTON = 5;
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

    public void BTPUSH7()//palo de pinata
    {
        IDBOTON = 6;
        if (ID == 0)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "¿Reconoces esto? lo ecnontramos cerca de la escena?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Si, es el palo para la piñata";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar ¿por que esta manchado de pastel? pudiste haber roto la piña para luego seguir con una mas de tus payasadas o ¿me equivoco? ";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "no, no ya se lo deje yo no fui.";
            }
            if (DIALOGO == 4)
            {
                SOSPECHOSOX[0].CULPABLE = SOSPECHOSOX[0].CULPABLE + 30;
                BOTONEXIT();
            }
        }
        if (ID == 1)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "¿Reconoces esto? lo ecnontramos cerca de la escena?";
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

    public void BTPUSH8()//panuelo
    {
        IDBOTON = 7;
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

    public void BTPUSH9()//pollo
    {
        IDBOTON = 8;
        if (ID == 0)
        {
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "¿Reconoces esto? lo ecnontramos cerca de la escena?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Si, es mi pollo de hule";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar por que esta manchado de pastel? no tenias suficiente con hacer reir a todos con pocho el pollo gracioso tambien querias arrojado al pequeño Timmy a su pastel.";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Esta bien confieso, yo soy el que se rroba los desechables de las fiestas para revenderlos :C, pero yo no fui el que arrojo al niño lo juro.";
            }
            if (DIALOGO == 4)
            {
                SOSPECHOSOX[0].CULPABLE = SOSPECHOSOX[0].CULPABLE + 30;
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

    public void BTPUSHGUILTY()//CULPABLE
    {
        IDBOTON = 10;
        if (ID == 0)
        {
            SOSPECHOSOX[0].CULPABLE = SOSPECHOSOX[0].CULPABLE + 100;
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "LO CONSIDERO CULPABLE DEL PASTELAZO AL QUERIDO TIMMY";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "SE EQUIVOCA SOY INOCENTE";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "YA LO VERAN EN LA CORTE";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 4)
            {
                TXPOLICIA.text = "*AL FINAL CREO QUE NO ERA EL CULPABLE*";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 5)
            {
                TXPOLICIA.text = "*EL VERDADERO CULPABLE SE SALIO CON LA SUYA*";
                TXSOSPECHOSO.text = "GAME OVER";
            }
        }
        if (ID == 1)
        {
            SOSPECHOSOX[1].CULPABLE = SOSPECHOSOX[1].CULPABLE + 1000;
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "LO CONSIDERO CULPABLE DEL PASTELAZO AL QUERIDO TIMMY";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "SE EQUIVOCA SOY INOCENTE";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "YA LO VERAN EN LA CORTE";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 4)
            {
                TXPOLICIA.text = "*AL FINAL CREO QUE NO ERA EL CULPABLE*";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 5)
            {
                TXPOLICIA.text = "*EL VERDADERO CULPABLE SE SALIO CON LA SUYA*";
                TXSOSPECHOSO.text = "GAME OVER";
            }
        }
        if (ID == 2)
        {
            SOSPECHOSOX[2].CULPABLE = SOSPECHOSOX[2].CULPABLE + 1000;
            if (DIALOGO == 0)
            {
                TXPOLICIA.text = "LO CONSIDERO CULPABLE DEL PASTELAZO AL QUERIDO TIMMY";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "SE EQUIVOCA SOY INOCENTE";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "YA LO VERAN EN LA CORTE";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 4)
            {
                TXPOLICIA.text = "*BUEN CASO AGENTE*";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 5)
            {
                TXPOLICIA.text = "*EL VERDADERO CULPABLE FUE CAPTURADO*";
                TXSOSPECHOSO.text = "MISION COMPLETADA";
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
            BTPUSH1();
        }
        if (IDBOTON == 1)
        {
            BTPUSH2();
        }
        if (IDBOTON == 2)
        {
            BTPUSH3();
        }
        if (IDBOTON == 3)
        {
            BTPUSH4();
        }
        if (IDBOTON == 4)
        {
            BTPUSH5();
        }
        if (IDBOTON == 5)
        {
            BTPUSH6();
        }
        if (IDBOTON == 6)
        {
            BTPUSH7();
        }
        if (IDBOTON == 7)
        {
            BTPUSH8();
        }
        if (IDBOTON == 8)
        {
            BTPUSH9();
        }
        if (IDBOTON == 10)
        {
            BTPUSHGUILTY();
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
