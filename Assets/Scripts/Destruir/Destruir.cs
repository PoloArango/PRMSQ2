using System;
using UnityEngine;


public class Destruir : MonoBehaviour
{
    [Header("Objeto con el codigo Web")]
    public Web Web;
    public int IDE;
    [Header("Objeto con el codigo Spam")]
    public Spam Spam;
    [Header("Objetos de ejercicio")]
    public GameObject Esfera_Roja;
    public GameObject Cuadrado_Mesa;
    [Header("Panel de Activacion Matriz")]
    public GameObject Panel_Activacion_Matriz;
    public GameObject Esfera_Activacion_Matriz;
    [Header("Panel para Activaciòn Reloj")]
    public GameObject Panel_Activacion_Reloj;
    public GameObject Esfera_Activacion_Reloj;
    [Header("Panel para Activaciòn Mesa")]
    public GameObject Panel_Activacion_Mesa;
    public GameObject Esfera_Activacion_Mesa;
    [Header("Datos de sesion")]
    public float Tiempo = 90f;
    public int Puntaje = 0;
    [Header("Banderas de inicio")]
    public int Bandera_inicio_Matriz = 0;
    public int Bandera_inicio_Reloj = 0;
    public int Bandera_inicio_Mesa = 0;
    [Header("Datos")]
    public float Tiempo_Max, Tiempo_Min, Tiempo_Prom;
    public int confirmarSoltar;
    [Header("Variable de Resistencia")]
    public Resistencia_Conteo resistencia_conteo;
    // Codigo de inicio
    void Start()
    {

    }

    // Codigo ciclico
    void Update()
    {

        if (Tiempo >= 0 && Bandera_inicio_Matriz == 1)
        {
            Tiempo -= Time.deltaTime;
            if (Tiempo <= 0)
            {
                Panel_Activacion_Matriz.SetActive(true);
                Esfera_Activacion_Matriz.SetActive(true);
                Debug.Log("TMin_Matriz: " + Tiempo_Min + " | TMax_Matriz: " + Tiempo_Max);
                /*if (confirmarSoltar == 1) 
                {*/
                    //Debug.Log("TMinB: " + Tiempo_Min + " | TMaxB: " + Tiempo_Max);
                    Enviardatos_Matriz();
                    Debug.Log("Destruyo objetos matriz");
                    Destroy(GameObject.FindWithTag("M_Matriz"));
                    Esfera_Roja.transform.position = new Vector3(2.360344f, 1.419875f, -0.02476189f);
                    Bandera_inicio_Matriz = 0;
                /*}*/
            }
        }

        if (Tiempo >= 0 && Bandera_inicio_Reloj == 1)
        {
            Tiempo -= Time.deltaTime;
            if (Tiempo <= 0)
            {
                Panel_Activacion_Reloj.SetActive(true);
                Esfera_Activacion_Reloj.SetActive(true);
                Debug.Log("TMin_Reloj: " + Tiempo_Min + " | TMax_Reloj: " + Tiempo_Max);
                /*if (confirmarSoltar == 1) 
                {*/
                    //Debug.Log("TMinB: " + Tiempo_Min + " | TMaxB: " + Tiempo_Max);
                    Enviardatos_Reloj();
                    Destroy(GameObject.FindWithTag("M_Reloj"));
                    Bandera_inicio_Reloj = 0;
                /*}*/
            }
        }

        if (Tiempo >= 0 && Bandera_inicio_Mesa == 1)
        {
            Tiempo -= Time.deltaTime;
            if (Tiempo <= 0)
            {
                Panel_Activacion_Mesa.SetActive(true);
                Esfera_Activacion_Mesa.SetActive(true);
                Debug.Log("TMin_Mesa: " + Tiempo_Min + " | TMax_Mesa: " + Tiempo_Max);
                /*if (confirmarSoltar == 1) 
                {*/
                    //Debug.Log("TMinB: " + Tiempo_Min + " | TMaxB: " + Tiempo_Max);
                    Enviardatos_Mesa();
                    Cuadrado_Mesa.SetActive(false);
                    Cuadrado_Mesa.transform.position = new Vector3(0.06f, 1.02f, 2.135f);
                    Bandera_inicio_Mesa = 0;
                /*}*/
            }
        }
    }

    //Deteccion de colisiones
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "M_Matriz"  && Tiempo >= 0)
        {
            Destroy(collision.gameObject);
            Spam.Generar_Matriz();
            Puntaje++;
            Debug.Log("Puntos Matriz: " + Puntaje);
        }

        if (collision.gameObject.tag == "M_Reloj" && Tiempo >= 0)
        {
            Destroy(collision.gameObject);
            Spam.Generar_Reloj();
            Puntaje++;
            Debug.Log("Puntos Reloj: " + Puntaje);
        }

        if (collision.gameObject.tag == "M_Mesa" && Tiempo >= 0)
        {
            //Cuadrado_Mesa.SetActive(false);
            if (confirmarSoltar == 1) {
                Cuadrado_Mesa.transform.position = new Vector3(0.06f, 1.02f, 2.044f);
                Puntaje++;
                //Cuadrado_Mesa.SetActive(true);
                Debug.Log("Puntos Mesa: " + Puntaje);
            }
        }
    }

    //Envio de datos
    public void Enviardatos_Matriz()
    {
        Debug.Log("TMin: " + Tiempo_Min + " | TMax: " + Tiempo_Max);
        Tiempo_Prom = (Tiempo_Max+Tiempo_Min) / 2;
        Debug.Log("TPromedio: " + Tiempo_Prom);
        Debug.Log("Puntos Enviados Puntaje: " + Puntaje + "Tiempo Max: " + Tiempo_Max + "Tiempo Min: " + Tiempo_Min + "Tiempo Prom: " + Tiempo_Prom);
        StartCoroutine(Web.Escribir_Entrenamiento("Matriz",Puntaje,Tiempo_Max,Tiempo_Min,Tiempo_Prom,IDE));
        Puntaje = 0;
        Tiempo_Max = 0;
        resistencia_conteo.TMax = 0f;
        Tiempo_Min = 0;
        resistencia_conteo.TMin = 2000f;
        Tiempo_Prom = 0;
    }

    public void Enviardatos_Reloj()
    {
        Tiempo_Prom = (Tiempo_Max + Tiempo_Min) / 2;
        Debug.Log("Puntos Enviados Puntaje: " + Puntaje + "Tiempo Max: " + Tiempo_Max + "Tiempo Min: " + Tiempo_Min + "Tiempo Prom: " + Tiempo_Prom);
        StartCoroutine(Web.Escribir_Entrenamiento("Reloj", Puntaje, Tiempo_Max, Tiempo_Min, Tiempo_Prom, IDE));
        Puntaje = 0;
        Tiempo_Max = 0;
        resistencia_conteo.TMax = 0f;
        Tiempo_Min = 0;
        resistencia_conteo.TMin = 2000f;
        Tiempo_Prom = 0;
    }

    public void Enviardatos_Mesa()
    {
        Tiempo_Prom = (Tiempo_Max + Tiempo_Min) / 2;
        Debug.Log("Puntos Enviados Puntaje: " + Puntaje + "Tiempo Max: " + Tiempo_Max + "Tiempo Min: " + Tiempo_Min + "Tiempo Prom: " + Tiempo_Prom);
        StartCoroutine(Web.Escribir_Entrenamiento("Mesa", Puntaje, Tiempo_Max, Tiempo_Min, Tiempo_Prom, IDE));
        Puntaje = 0;
        Tiempo_Max = 0;
        resistencia_conteo.TMax = 0f;
        Tiempo_Min = 0;
        resistencia_conteo.TMin = 2000f;
        Tiempo_Prom = 0;
    }
}