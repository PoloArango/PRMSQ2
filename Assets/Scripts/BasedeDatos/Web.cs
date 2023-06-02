using UnityEngine;
using System.Collections;
using System;
using UnityEngine.Networking;


public class Web : MonoBehaviour
{
    [Header("Objeto con el codigo Test")]
    public Test Test;
    [Header("Objeto con el codigo Destruir")]
    public Destruir Destruir_matriz;
    public Destruir Destruir_reloj;
    public Destruir Destruir_mesa;
    [Header("Objeto con el codigo Sesion")]
    public Sesion Sesion;
    [Header("Id del usuario")]
    private int IDe;
    public int IDES;
    private string fecha;

    void Start()
    {
        fecha = DateTime.Now.ToString("dd MMM yyyy");
    }
    public IEnumerator Escribir_Usuario(string nombre, string apellido, string cedula,string edad, string ocupacion, string alias)
    {
        WWWForm form = new WWWForm();

        form.AddField("nombre",nombre);
        form.AddField("apellido",apellido);
        form.AddField("cedula",cedula);
        form.AddField("edad",edad);
        form.AddField("ocupacion",ocupacion);
        form.AddField("alias",alias);

        using (UnityWebRequest www = UnityWebRequest.Post("http://plataformarms.000webhostapp.com/RegisterUser.php", form))
        {
            yield return www.SendWebRequest();
            Debug.Log(www.downloadHandler.text);
        }
    }
    public IEnumerator Escribir_Entrenamiento( string ejercicio, int colisiones, float tiempoMax, float tiempoMin, float tiempoProm, int ForUser)
    {
        WWWForm form = new WWWForm();
        
        form.AddField("fecha", fecha);
        form.AddField("ejercicio", ejercicio);
        form.AddField("colisiones", colisiones);
        form.AddField("tiempoMax", tiempoMax.ToString());
        form.AddField("tiempoMin", tiempoMin.ToString());
        form.AddField("tiempoProm", tiempoProm.ToString());
        form.AddField("ForUser", ForUser);
        //Debug.Log("Escribir entrenamiento");
        using (UnityWebRequest www = UnityWebRequest.Post("http://plataformarms.000webhostapp.com/RegisterEntre.php", form))
        {
            yield return www.SendWebRequest();
            Debug.Log(www.downloadHandler.text);
        }
    }
    public IEnumerator Escribir_Test(float AnguloSup, float AnguloInf, float AnguloIz, float AnguloDer, int forUser)
    {
        WWWForm form = new WWWForm();

        form.AddField("fecha", fecha);
        form.AddField("AnguloSup", AnguloSup.ToString());
        form.AddField("AnguloInf", AnguloInf.ToString());
        form.AddField("AnguloIz", AnguloIz.ToString());
        form.AddField("AnguloDer", AnguloDer.ToString());
        form.AddField("forUser", forUser);
        Debug.Log("Escribir test");
        using (UnityWebRequest www = UnityWebRequest.Post("http://plataformarms.000webhostapp.com/RegisterTest.php", form))
        {
            yield return www.SendWebRequest();
            Debug.Log(www.downloadHandler.text);
        }
    }
    public IEnumerator Login(string alias)
    {
        WWWForm form = new WWWForm();
        form.AddField("alias", alias);

        Debug.Log("Sub rutina de web");

        Debug.Log("alias1: " + alias);

        form.AddField("alias", alias);

        Debug.Log("alias: " + alias);

        using (UnityWebRequest www = UnityWebRequest.Post("http://plataformarms.000webhostapp.com/Login.php", form))
        {
            Debug.Log("Sub rutina de web codigo url");
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else 
            {
                Debug.Log("Despues de send");
                Debug.Log(www.downloadHandler.text);
                int.TryParse(www.downloadHandler.text, out IDe);

                Debug.Log("ID usuario: " + IDe);

            }
        }
        IDES = IDe;
        Destruir_mesa.IDE = IDES;
        Destruir_reloj.IDE = IDES;
        Destruir_matriz.IDE = IDES;
        Test.IDE = IDES;
        Sesion.IDE = IDES;
        
        Debug.Log("IDES: " + IDES);
    }
}