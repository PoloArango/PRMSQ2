using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sesion : MonoBehaviour
{
    [Header("Objeto con el codigo Web")]
    public Web Web;
    //public User user;
    public int IDE;
    [Header("Paneles funcionales")]
    public GameObject Panel_Login;
    public GameObject Panel_Calibracion;
    public GameObject Panel_Logout;
    public GameObject Panel_Test;
    [Header("Paneles funcionales")]
    public GameObject Boton3D_Login;
    public GameObject Boton3D_Calibracion;
    public GameObject Boton3D_Logout;
    public GameObject Boton3D_Test;
    [Header("Variables de usuario")]
    public GameObject esferas_Calibracion_izq;
    public GameObject esferas_Calibracion_der;
    [Header("Variables de usuario")]
    public string Alias;
    public Text aviso;
    [Header("Opciones de usuario")]
    public GameObject OpcUser;
    [Header("Objetos de Test")]
    public GameObject Superior;
    public GameObject Inferior;
    public GameObject Derecha;
    public GameObject Izquierda;
    [Header("Ejercicios")]
    public GameObject Reloj;
    public GameObject Matriz;
    public GameObject Mesa;


    // Start is called before the first frame update
    void Start()
    {
        OpcUser.SetActive(true);
        Panel_Login.SetActive(true);
        Boton3D_Login.SetActive(true);
        Panel_Calibracion.SetActive(false);
        Boton3D_Calibracion.SetActive(false);
        esferas_Calibracion_izq.SetActive(false);
        esferas_Calibracion_der.SetActive(false);
        Panel_Logout.SetActive(false);
        Boton3D_Logout.SetActive(false);
        Panel_Test.SetActive(false);
        Boton3D_Test.SetActive(false);
        Superior.SetActive(false);
        Inferior.SetActive(false);
        Derecha.SetActive(false);
        Izquierda.SetActive(false);
        Reloj.SetActive(false);
        Matriz.SetActive(false);
        Mesa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Activar_Usuario();
        Debug.Log("Colision");
    }
    public void Activar_Usuario()
    {
        
        if (Alias == "Sin usuario")
        {
            aviso.text = "Escoge un usuario";
        }
        else 
        {
            Debug.Log("Alias: " + Alias + " ID: " + IDE);
           // StartCoroutine(Web.Login(Alias));
            OpcUser.SetActive(false);
            Panel_Login.SetActive(false);
            Boton3D_Login.SetActive(false);
            Panel_Calibracion.SetActive(true);
            Boton3D_Calibracion.SetActive(true);
            esferas_Calibracion_izq.SetActive(true);
            esferas_Calibracion_der.SetActive(true);
            aviso.text = "";
            //Debug.Log("Entraste: " + Alias + " Ide: " + IDE);
        }
    }
    public void Cerrar_Sesion()
    {
        Alias = "Sin usuario";
        IDE = 0;
        Web.IDES = 0;
        Debug.Log("Cerraste Sesión");
        OpcUser.SetActive(true);
        Panel_Login.SetActive(true);
        Boton3D_Login.SetActive(true);
        Panel_Calibracion.SetActive(false);
        Boton3D_Calibracion.SetActive(false);
        esferas_Calibracion_izq.SetActive(false);
        esferas_Calibracion_der.SetActive(false);
        Panel_Logout.SetActive(false);
        Boton3D_Logout.SetActive(false);
        Panel_Test.SetActive(false);
        Boton3D_Test.SetActive(false);
        Reloj.SetActive(false);
        Matriz.SetActive(false);
        Mesa.SetActive(false);
        esferas_Calibracion_der.transform.position = new Vector3(-1.00327f, 1.229403f, -0.096f);
        esferas_Calibracion_izq.transform.position = new Vector3(-1.00327f, 1.229403f, 0.3080001f);
    }

    public void Mostrar_User() 
    {
        aviso.text = Alias;
    }

}
