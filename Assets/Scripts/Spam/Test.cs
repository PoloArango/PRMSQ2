using System;
using UnityEngine;

public class Test : MonoBehaviour
{
    [Header("Objeto con el codigo Web")]
    public Web Web;
    public int IDE;
    [Header("Panel de Activacion Test")]
    public GameObject Panel_Activacion_Test;
    public GameObject Esfera_Activacion_Test;
    [Header("Objeto Logout")]
    public Logout logout;
    [Header("Objetos de Test")]
    public GameObject Superior;
    public GameObject Inferior;
    public GameObject Derecha;
    public GameObject Izquierda;
    [Header("Objetos de referencia")]
    public GameObject Esfera_Izquierda;
    public GameObject Esfera_Derecha;
    public GameObject Linea;
    [Header("Coordenadas referencia")]
    public float Altura_Hombro_Derecho;
    public float Altura_Hombro_Izquierdo;
    public float Linea_Test_X;
    public float Linea_Test_Z;
    [Header("Coordenadas Vertical")]
    public float Superior_Test_X;
    public float Inferior_Test_X;
    public float Superior_Test_Y;
    public float Inferior_Test_Y;
    [Header("Coordenadas Horizontal")]
    public float Derecha_Test_X;
    public float Izquierda_Test_X;
    public float Derecha_Test_Z;
    public float Izquierda_Test_Z;
    [Header("Banderas de inicio")]
    public int Bandera_inicio_Test = 0;
    [Header("Tiempo de Test")]
    public float time = 60f;
    private float Altura = 0;
    [Header("Angulos")]
    public float AnguloSup;
    public float AnguloInf;
    public float AnguloDer;
    public float AnguloIz;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Lectura();
        //Debug.Log("AnguloSup " + AnguloSup + " AnguloInf " + AnguloInf + " AnguloIz " + AnguloIz + " AnguloDer " + AnguloDer);
        if (time >= 0 && Bandera_inicio_Test == 1)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                Debug.Log("AnguloSup " + AnguloSup + " AnguloInf " + AnguloInf + " AnguloIz " + AnguloIz + " AnguloDer " + AnguloDer);
                StartCoroutine(Web.Escribir_Test(AnguloSup, AnguloInf, AnguloIz,  AnguloDer, IDE));
                Reinicio_Test();
            }
        }
    }

    public void Lectura()
    {
        Vector3 Posicion_Superior = Superior.transform.position;
        Vector3 Posicion_Inferior = Inferior.transform.position;
        Vector3 Posicion_Derecha = Derecha.transform.position;
        Vector3 Posicion_Izquierda = Izquierda.transform.position;
        Vector3 Posicion_Esfera_Derecha = Esfera_Derecha.transform.position;
        Vector3 Posicion_Esfera_Izquierda = Esfera_Izquierda.transform.position;
        Vector3 Posicion_Linea = Linea.transform.position;

        Altura_Hombro_Derecho = Posicion_Esfera_Derecha.y;
        Altura_Hombro_Izquierdo = Posicion_Esfera_Izquierda.y;
        Superior_Test_Y = Posicion_Superior.y;
        Inferior_Test_Y = Posicion_Inferior.y;
        Superior_Test_X = Posicion_Superior.x;
        Inferior_Test_X = Posicion_Inferior.x;
        Derecha_Test_X = Posicion_Derecha.x;
        Izquierda_Test_X = Posicion_Izquierda.x;
        Derecha_Test_Z = Posicion_Derecha.z;
        Izquierda_Test_Z = Posicion_Izquierda.z;
        Linea_Test_X = Posicion_Linea.x;
        Linea_Test_Z = Posicion_Linea.z;

        Altura = (Altura_Hombro_Derecho + Altura_Hombro_Izquierdo) / 2;
        AnguloSup = (float)(Math.Atan((Superior_Test_Y - Altura) / (Linea_Test_X - Superior_Test_X)) * (180 /Math.PI)) + 90;
        AnguloInf = (float)(Math.Atan((Altura - Inferior_Test_Y) / (Linea_Test_X - Inferior_Test_X)) * (180 / Math.PI));
        AnguloDer = (float)(Math.Atan((Derecha_Test_Z - Linea_Test_Z) / (Linea_Test_X - Derecha_Test_X)) * (180 / Math.PI));
        AnguloIz = (float)(Math.Atan((Math.Abs(Izquierda_Test_Z) - Linea_Test_Z) / (Linea_Test_X - Izquierda_Test_X)) * (180 / Math.PI));

    }
    public void Inicio_Test()
    {
        Panel_Activacion_Test.SetActive(false);
        Esfera_Activacion_Test.SetActive(false);
        Bandera_inicio_Test = 1;
    }
    public void Reinicio_Test()
    {
        Vector3 Posicion_Superior = Superior.transform.position;
        Superior.transform.position = new Vector3 (-2.246304f, 0.929f, 0.1235f);
        Inferior.transform.position = new Vector3(-2.246304f, 0.9269999f, -0.0155f);
        Derecha.transform.position = new Vector3(-2.246304f, 0.9305f, 0.3525f);
        Izquierda.transform.position = new Vector3(-2.246304f, 0.9194999f, -0.2335f);
        logout.Activar_Logout();
        Bandera_inicio_Test = 0;
        time = 60;
    }
}
