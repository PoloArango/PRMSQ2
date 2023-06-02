using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccionActivador : MonoBehaviour
{
    [Header("Objeto con el codigo Spam")]
    public Spam Spam;
    [Header("Objeto con el codigo Destruir")]
    public Destruir Destruir;
    [Header("Boton 3D Activador")]
    public GameObject Boton3D;
    [Header("Panel Descriptivo")]
    public GameObject Panel;
    [Header("Bandera de objeto")]
    public int in_Bandera;
    private int Bandera;

    void Start()
    {
        Boton3D.SetActive(true);
        Panel.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        Bandera = in_Bandera;
        Boton3D.SetActive(false);
        Panel.SetActive(false);
        if (Bandera == 1)
        {
            Spam.Generar_Matriz();
            Destruir.Bandera_inicio_Matriz = 1;
            Destruir.Tiempo = 90;

        }
        if (Bandera == 2)
        {
            Spam.Generar_Reloj();
            Destruir.Bandera_inicio_Reloj = 1;
            Destruir.Tiempo = 90;
        }
        if (Bandera == 3)
        {
            Spam.Generar_Mesa();
            Destruir.Bandera_inicio_Mesa = 1;
            Destruir.Tiempo = 90;
        }
        
    }
}
