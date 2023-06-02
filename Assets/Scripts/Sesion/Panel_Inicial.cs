using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Inicial : MonoBehaviour
{
    [Header("Panel Descriptivo")]
    public GameObject Panel;
    [Header("Objetos")]
    public GameObject hombroIzq;
    public GameObject hombroDer;
    [Header("Boton 3D Activador")]
    public GameObject Boton3D;
    [Header("Panel de Activacion Test")]
    public GameObject Panel_Activacion_Test;
    public GameObject Esfera_Activacion_Test;
    [Header("Objetos de Test")]
    public GameObject Superior;
    public GameObject Inferior;
    public GameObject Derecha;
    public GameObject Izquierda;


    void Start()
    {
        Panel.SetActive(true);
        hombroIzq.SetActive(true);
        hombroDer.SetActive(true);
        Boton3D.SetActive(true);
    }

    //Aceptar Calibración
    private void OnTriggerEnter(Collider other)
    {
            Panel.SetActive(false);
            hombroIzq.SetActive(false);
            hombroDer.SetActive(false);
            Boton3D.SetActive(false);
        Panel_Activacion_Test.SetActive(true);
        Esfera_Activacion_Test.SetActive(true);
        Superior.SetActive(true);
        Inferior.SetActive(true);
        Derecha.SetActive(true);
        Izquierda.SetActive(true);

    }
}
