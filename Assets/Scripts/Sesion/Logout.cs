using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logout : MonoBehaviour
{
    [Header("Objeto Sesion")]
    public Sesion sesion;
    [Header("Paneles")]
    public GameObject Panel_Login;
    public GameObject Panel_Test;
    public GameObject Panel_Logout;
    [Header("Botones 3D")]
    public GameObject boton3D_Login;
    public GameObject boton3D_Test;
    public GameObject boton3D_Logout;
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Activar_Logout()
    {
        Panel_Login.SetActive(false);
        boton3D_Login.SetActive(false);
        Panel_Test.SetActive(false);
        boton3D_Test.SetActive(false);
        Superior.SetActive(false);
        Inferior.SetActive(false);
        Derecha.SetActive(false);
        Izquierda.SetActive(false);
        Panel_Logout.SetActive(true);
        boton3D_Logout.SetActive(true);
        Reloj.SetActive(true);
        Matriz.SetActive(true);
        Mesa.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        sesion.Cerrar_Sesion();
    }

}
