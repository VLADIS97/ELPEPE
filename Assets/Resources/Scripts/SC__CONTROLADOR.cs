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
                TXSOSPECHOSO.text = "Enserio tengo que repetirselo a usted tambien? bien como quiera de todos modos no tengo nada mejor que hacer";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Solo responda la pregunta";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Estaba entreteniendo a esos pequeños traga mocos, les regalaba juguetes de la mascota de la botarga y mis bailes de fornite";
            }
            if (DIALOGO == 4)
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
                TXSOSPECHOSO.text = "¿A usted tambien? ¿en serio? bien terminemos con esto";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Solo hacia mi Show de cartas magica, como es costumbre";
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
                TXSOSPECHOSO.text = "yo que se, apenas puedo ver y respirar, necesito usar mi inalador cada 15 segundos, honestamente no me pagan lo suficiente";
            }
            if (DIALOGO == 2)
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
                TXSOSPECHOSO.text = "Justo en el momento, yo ayude al pequeño a limpiarse con uno de mis pañuelos de uteleria ";
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
                TXPOLICIA.text = "" + general;
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "¿Relacion? de que rayos me habla? se supone que debo conocerlo o algo? ";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Solo responda la pregunta";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Pfff, lo unico que se del niño es que su mama me ofrecio unicamente una botella de agua, habiendo una fuentes de sodas y solo me ofrecen eso, genial";
            }
            if (DIALOGO == 4)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Creo que tuve que ser mejor Dr. Simi";
            }
            if (DIALOGO == 5)
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
                TXSOSPECHOSO.text = "creo que ya conteste suficientes preguntas a todos ustedes ¿ya me puedo ir?";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Solo responda";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "mire amigo ya repondi muchas veces esto, yo ayude al niño, yo no soy la culpable hasta le regale unas flores magicas";
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
                TXSOSPECHOSO.text = "Es una botella";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar por que esta manchado de pastel? no tenias suficiente con agua ¿verdad? querias algo mas incluso serias capaz de arrojar al pequeño Timmy a su pastel para crear una distraccion ¿no?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "No es mio oficial, yo uso otra cosa para tirar agua";
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
                TXSOSPECHOSO.text = "Si, es la botella que me regalaron";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar por que esta manchado de pastel? no tenias suficiente con agua ¿verdad? querias algo mas incluso serias capaz de arrojar al pequeño Timmy a su pastel para crear una distraccion ¿no?.";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Bien confieso, yo fui el que se robo el alchol de la casa de sus padres, pero yo no fui el que arrojo a Timmy.";
            }
            if (DIALOGO == 4)
            {
                SOSPECHOSOX[1].CULPABLE = SOSPECHOSOX[1].CULPABLE + 30;
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
                TXSOSPECHOSO.text = "Una botella y cual es el punto?";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar por que esta manchado de pastel? no tenias suficiente con agua ¿verdad? querias algo mas incluso serias capaz de arrojar al pequeño Timmy a su pastel para crear una distraccion ¿no?.";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "No y no. Eso lo dieron los tacaños de los jefes a la botarga, a mi me dieron solo comida los ruines";
            }
            if (DIALOGO == 4)
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
                TXPOLICIA.text = "¿Reconoces esto? lo ecnontramos cerca de la escena?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Un rociador, de verdad?";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar ¿por que esta manchado de pastel? pudiste haber arrojado al pequeño Timmy a su pastel y al momento de huir dejaste caer tu objeto ¿no es asi? ¡¡¡BOTARGA!!!";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Apenas puede tomar mi medicamento para el asma con esta cosa encima";
            }
            if (DIALOGO == 4)
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
                TXSOSPECHOSO.text = "Un rociador, que quiere probar?";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar ¿por que esta manchado de pastel? pudiste haber arrojado al pequeño Timmy a su pastel y al momento de huir dejaste caer tu objeto ¿no es asi? ¡¡¡MAGA!!!";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Un mago con un rociador... Que puedo hacer con eso refrescar la esperanza de mi carrera fallida, eh";
            }
            if (DIALOGO == 4)
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
                TXSOSPECHOSO.text = "Unas cartas";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces las reconoces, entonces me puedes explicar ¿por que estan manchadas de pastel? pudiste haber arrojado al pequeño Timmy a su pastel y al momento de disimular ayudarlo, dejaste caer tus cartas ¿no es asi? ";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "No, yo no uso cartas para mi show... creo que fue...";
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
                TXSOSPECHOSO.text = "Unas cartas creo";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces las reconoces, entonces me puedes explicar ¿por que estan manchadas de pastel? pudiste haber arrojado al pequeño Timmy a su pastel y al momento de disimular ayudarlo, dejaste caer tus cartas ¿no es asi? ";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Ni siquiera veo que carta sale, solo fingo sopresa cuando siento golpes de la espalda del payaso para bailar";
            }
            if (DIALOGO == 4)
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
                TXSOSPECHOSO.text = "Si, son las cartas que uso";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces las reconoces, entonces me puedes explicar ¿por que estan manchadas de pastel? pudiste haber arrojado al pequeño Timmy a su pastel y al momento de disimular ayudarlo, dejaste caer tus cartas ¿no es asi? ";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "¿Que, no de que habla?";
            }
            if (DIALOGO == 4)
            {
                SOSPECHOSOX[2].CULPABLE = SOSPECHOSOX[2].CULPABLE + 30;
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
                TXPOLICIA.text = "¿Reconoces esto? lo ecnontramos cerca de la escena?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Es el peluche de la empresa";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar ¿por que esta manchado de pastel? pudiste haber arrojado al pequeño Timmy a su pastel y al momento de huir dejaste caer tu objeto ¿no es asi? ¡¡¡PAYASO!!!";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "No... aunque he pensado en otras cosas";
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
                TXSOSPECHOSO.text = "Si, es el juguete que ragalo";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar ¿por que esta manchado de pastel? pudiste haber arrojado al pequeño Timmy a su pastel y al momento de huir dejaste caer tu objeto ¿no es asi? ¡¡¡BOTARGA!!!";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "De verdad cree que podria con estos brazos?";
            }
            if (DIALOGO == 4)
            {
                SOSPECHOSOX[1].CULPABLE = SOSPECHOSOX[1].CULPABLE + 30;
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
                TXSOSPECHOSO.text = "Los juguetes que regalamos, ajam";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar ¿por que esta manchado de pastel? pudiste haber arrojado al pequeño Timmy a su pastel y al momento de huir dejaste caer tu objeto ¿no es asi? ¡¡¡MAGA!!!";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Y un botarga gigante que se parece a este peluche, no te parece que el es sospechoso";
            }
            if (DIALOGO == 4)
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
                TXPOLICIA.text = "¿Reconoces esto? lo ecnontramos cerca de la escena?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Unas flores";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar por que esta manchado de pastel? se supone que Timmy ya estaba limpio, entonces las flores ya estaban manchadas de antes ¿verdad? querias arrojar al niño a su pastel por que te daba envidia, su pastel no es asi?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Creo que se las regalaron a la maga, pero a mi tambien me gustaria recibir flores";
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
                TXSOSPECHOSO.text = "Mmm flores";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar por que esta manchado de pastel? se supone que Timmy ya estaba limpio, entonces las flores ya estaban manchadas de antes ¿verdad? querias arrojar al niño a su pastel por que te daba envidia, su pastel no es asi?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "No es mio, y creo que es de la maga cuando fue rapido por algo";
            }
            if (DIALOGO == 4)
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
                TXSOSPECHOSO.text = "Si, son mis flores que le regale al niño";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar por que esta manchado de pastel? se supone que Timmy ya estaba limpio, entonces las flores ya estaban manchadas de antes ¿verdad? querias arrojar al niño a su pastel por que te daba envidia, su pastel no es asi?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Bien confieso, me las regalo un admirador pero ya las habia dejado en la mesa cuando todo eso paso alguien mas la tomo";
            }
            if (DIALOGO == 4)
            {
                SOSPECHOSOX[2].CULPABLE = SOSPECHOSOX[2].CULPABLE + 30;
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
                TXPOLICIA.text = "¿Reconoces esto? lo ecnontramos cerca de la escena?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Un respirador de asma?";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar ¿por que esta manchado de pastel? pudiste haber finjido tu enfermadad para luego seguir con tu ataque o ¿me equivoco?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "No de hecho me preocupa que lo hayan perdido... probecito el dueño";
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
                TXSOSPECHOSO.text = "Si, es de hecho lo necesito, me lo puede devolver?";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar ¿por que esta manchado de pastel? pudiste haber finjido tu enfermadad para luego seguir con tu ataque o ¿me equivoco?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "porfavor, devuelvamelo, empieza a hacer calor aqui.";
            }
            if (DIALOGO == 4)
            {
                SOSPECHOSOX[1].CULPABLE = SOSPECHOSOX[1].CULPABLE + 30;
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
                TXSOSPECHOSO.text = "Es para el asma, si";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar ¿por que esta manchado de pastel? pudiste haber finjido tu enfermadad para luego seguir con tu ataque o ¿me equivoco?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "No es mio, pero creo que es del payaso, esa cara de enfermedad no me ha dado confianza";
            }
            if (DIALOGO == 4)
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
                TXSOSPECHOSO.text = "Un palo grande";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar ¿por que esta manchado de pastel? pudiste haber roto la piña para luego seguir con una mas de tus payasadas o ¿me equivoco? ";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Dificilmente podria agarrarlo pero no es mala idea para un futuro...";
            }
            if (DIALOGO == 4)
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
                TXSOSPECHOSO.text = "Un palo de piñata";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar ¿por que esta manchado de pastel? pudiste haber roto la piña para luego seguir con una mas de tus payasadas o ¿me equivoco? ";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Se que eso es del payaso, lo vi cuando se lo dio a los niños";
            }
            if (DIALOGO == 4)
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
                TXPOLICIA.text = "¿Reconoces esto? lo ecnontramos cerca de la escena?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 1)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Un panuelo sucio";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar por que esta manchado de pastel? se supone que Timmy ya estaba limpio, entonces las flores ya estaban manchadas de antes ¿verdad? querias arrojar al niño a su pastel por que te daba envidia, su pastel no es asi?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "No es mio pero si no lo quiere me lo puede dar?";
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
                TXSOSPECHOSO.text = "Un panuelo?";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar por que esta manchado de pastel? se supone que Timmy ya estaba limpio, entonces las flores ya estaban manchadas de antes ¿verdad? querias arrojar al niño a su pastel por que te daba envidia, su pastel no es asi?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Sabes que pasa si ensuncio esta bortaga... esto vale mas que mi vida, literalmente";
            }
            if (DIALOGO == 4)
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
                TXSOSPECHOSO.text = "Si, es el pañuelo que use para limpiar al niño";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar por que esta manchado de pastel? se supone que Timmy ya estaba limpio, entonces las flores ya estaban manchadas de antes ¿verdad? querias arrojar al niño a su pastel por que te daba envidia, su pastel no es asi?";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Bien confieso, yo limpie al niño, Al ver al nino asi, me recordo a mis cumplaños y al momento de ver al mocoso, no pude no sentir lastima por el.";
            }
            if (DIALOGO == 4)
            {
                SOSPECHOSOX[2].CULPABLE = SOSPECHOSOX[2].CULPABLE + 30;
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
                TXSOSPECHOSO.text = "Esta bien confieso, yo soy el que se roba los desechables de las fiestas para revenderlos :C, pero yo no fui el que arrojo al niño lo juro.";
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
                TXSOSPECHOSO.text = "Un pollo";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar por que esta manchado de pastel? no tenias suficiente con hacer reir a todos con pocho el pollo gracioso tambien querias arrojado al pequeño Timmy a su pastel.";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Tengo mis peluches para que necesito mas, pero creo que eso es del payaso o de la maga?";
            }
            if (DIALOGO == 4)
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
                TXSOSPECHOSO.text = "Un pollo raro";
            }
            if (DIALOGO == 2)
            {
                TXPOLICIA.text = "Bien entonces lo reconoces, entonces me puedes explicar por que esta manchado de pastel? no tenias suficiente con hacer reir a todos con pocho el pollo gracioso tambien querias arrojado al pequeño Timmy a su pastel.";
                TXSOSPECHOSO.text = "";
            }
            if (DIALOGO == 3)
            {
                TXPOLICIA.text = "";
                TXSOSPECHOSO.text = "Yo nunca usaria algo asi, tengo mis herramientas para que necesito mas";
            }
            if (DIALOGO == 4)
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
