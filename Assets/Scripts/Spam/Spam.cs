using UnityEngine;

public class Spam : MonoBehaviour
{
    [Header("Objetos a generar")]
    public GameObject[] Objetos;
    public GameObject Cuadrado_Mesa;
    [Header("Objeto con el codigo Destruir")]
    public Destruir Destruir;

    private int Seleccion = 0;

    // Codigo de inicio
    void Start()
    {
     
    }

    // Codigo ciclico
    void Update()
    {
        
    }
    //Generadores de objetos
    public void Generar_Matriz()
    {
        float CoordX = 2.360f;

        Vector3 Pos_Generacion_1 = new Vector3(CoordX, 1.419875f, 0.464f);
        Vector3 Pos_Generacion_2 = new Vector3(CoordX, 1.419875f, -0.027f);
        Vector3 Pos_Generacion_3 = new Vector3(CoordX, 1.419875f, -0.435f);
        Vector3 Pos_Generacion_4 = new Vector3(CoordX, 0.979f, -0.435f);
        Vector3 Pos_Generacion_5 = new Vector3(CoordX, 0.979f, -0.022f);
        Vector3 Pos_Generacion_6 = new Vector3(CoordX, 0.979f, 0.481f);
        Vector3 Pos_Generacion_7 = new Vector3(CoordX, 1.852f, 0.464f);
        Vector3 Pos_Generacion_8 = new Vector3(CoordX, 1.852f, -0.027f);
        Vector3 Pos_Generacion_9 = new Vector3(CoordX, 1.852f, -0.435f);
        Seleccion = Random.Range(0, 8);
        if (Seleccion == 0) { Instantiate(Objetos[0], Pos_Generacion_1, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 1) { Instantiate(Objetos[0], Pos_Generacion_2, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 2) { Instantiate(Objetos[0], Pos_Generacion_3, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 3) { Instantiate(Objetos[0], Pos_Generacion_4, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 4) { Instantiate(Objetos[0], Pos_Generacion_5, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 5) { Instantiate(Objetos[0], Pos_Generacion_6, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 6) { Instantiate(Objetos[0], Pos_Generacion_7, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 7) { Instantiate(Objetos[0], Pos_Generacion_8, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 8) { Instantiate(Objetos[0], Pos_Generacion_9, Objetos[1].gameObject.transform.rotation); }
    }
    public void Generar_Reloj()
    {
        float CoordZ = -2.284f;
        Vector3 Pos_Generacion_1 = new Vector3(-0.036f, 1.794f, CoordZ);
        Vector3 Pos_Generacion_2 = new Vector3(-0.036f, 0.91f, CoordZ);
        Vector3 Pos_Generacion_3 = new Vector3(0.415f, 1.349f, CoordZ);
        Vector3 Pos_Generacion_4 = new Vector3(-0.473f, 1.349f, CoordZ);
        Vector3 Pos_Generacion_5 = new Vector3(-0.444f, 1.205f, CoordZ);
        Vector3 Pos_Generacion_6 = new Vector3(-0.33f, 1.028f, CoordZ);
        Vector3 Pos_Generacion_7 = new Vector3(0.251f, 1.01f, CoordZ);
        Vector3 Pos_Generacion_8 = new Vector3(0.365f, 1.148f, CoordZ);
        Vector3 Pos_Generacion_9 = new Vector3(0.381f, 1.532f, CoordZ);
        Vector3 Pos_Generacion_10 = new Vector3(0.21f, 1.715f, CoordZ);
        Vector3 Pos_Generacion_11 = new Vector3(-0.256f, 1.731f, CoordZ);
        Vector3 Pos_Generacion_12 = new Vector3(-0.414f, 1.581f, CoordZ);

        Seleccion = Random.Range(0, 11);

        if (Seleccion == 0) { Instantiate(Objetos[1], Pos_Generacion_1, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 1) { Instantiate(Objetos[1], Pos_Generacion_2, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 2) { Instantiate(Objetos[1], Pos_Generacion_3, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 3) { Instantiate(Objetos[1], Pos_Generacion_4, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 4) { Instantiate(Objetos[1], Pos_Generacion_5, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 5) { Instantiate(Objetos[1], Pos_Generacion_6, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 6) { Instantiate(Objetos[1], Pos_Generacion_7, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 7) { Instantiate(Objetos[1], Pos_Generacion_8, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 8) { Instantiate(Objetos[1], Pos_Generacion_9, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 9) { Instantiate(Objetos[1], Pos_Generacion_10, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 10) { Instantiate(Objetos[1], Pos_Generacion_11, Objetos[1].gameObject.transform.rotation); }
        if (Seleccion == 11) { Instantiate(Objetos[1], Pos_Generacion_12, Objetos[1].gameObject.transform.rotation); }
    }
    public void Generar_Mesa()
    {

        Cuadrado_Mesa.transform.position = new Vector3(0.06f, 1.02f, 2.135f);
        Cuadrado_Mesa.SetActive(true);

    }

    //Iniciadores para boton


    public void Generar_Objeto_Matriz()
    {
        Generar_Matriz();
        Debug.Log("Genero esfera Matriz");
    }


    public void Generar_Objeto_Reloj()
    {
        Generar_Reloj();
        Debug.Log("Genero esfera Reloj");
    }


    public void Generar_Objeto_Mesa()
    {
        Generar_Mesa();
        Debug.Log("Genero Cuadrados");
    }
}


