using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resistencia_Conteo : MonoBehaviour
{
    [Header("Objeto con el codigo Destruir")]
    public Destruir destruir;
    private int conteo = 0;
    private float time = 0f;
    public float TMax = 0f;
    public float TMin = 2000f;
    //public int ejercicio;
    /*public Text TTime;
    public Text TTimeMin;
    public Text TTimeMax;*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (conteo == 1)
        {
            time += Time.deltaTime;
        }
        else if (conteo == 0) {
            time = 0;
        }
    }
    /*
    public void P1() 
    {
        Debug.Log("Se presiono 1");
    }
    public void P2()
    {
        Debug.Log("Se presiono 2");
    }
    public void P3()
    {
        Debug.Log("Se presiono 3");
    }
    public void P4()
    {
        Debug.Log("Se presiono 4");
    }
    public void P5()
    {
        Debug.Log("Se presiono 5");
    }
    public void P6()
    {
        Debug.Log("Se presiono 6");
    }*/
    public void AgarrarObjt()
    {
        Debug.Log("Agarraste objeto");
        conteo = 1;
        destruir.confirmarSoltar = 0;
        Debug.Log("confirmar soltar: "+ destruir.confirmarSoltar);
    }
    public void SoltarObjt()
    {
        Debug.Log("Soltaste objeto");
        Debug.Log("Tiempo: " + time);
        //TTime.text = "Tiempo" + "\n" + time;
        if (time > TMax) {
            TMax = time;
            //TTimeMax.text = "Max" + "\n" + TMax;
            destruir.Tiempo_Max = TMax;
        }
        if (time < TMin)
        {
            TMin = time;
            //TTimeMin.text = "Min" + "\n" + TMin;
            destruir.Tiempo_Min = TMin;
        }
        conteo = 0;
        Debug.Log("Tiempo Maximo: " + TMax);
        Debug.Log("Tiempo Minimo: " + TMin);
        Debug.Log("Tiempo: " + time);
        destruir.confirmarSoltar = 1;
        Debug.Log("confirmar soltar: " + destruir.confirmarSoltar);

    }/*
    public void P9()
    {
        Debug.Log("Se presiono 9");
    }
    public void P10()
    {
        Debug.Log("Se presiono 10");
    }*/
}
