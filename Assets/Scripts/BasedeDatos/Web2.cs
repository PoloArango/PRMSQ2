using UnityEngine;
using System.Collections;
using System;
using UnityEngine.Networking;

public class Web2 : MonoBehaviour
{

    [Header("Id del usuario")]
    private int IDe;
    public int IDES;
    private string fecha;

    void Start()
    {
        fecha = DateTime.Now.ToString("dd MMM yyyy");

    }
    public IEnumerator Escribir_Usuario(string nombre, string apellido, string cedula, string edad, string ocupacion, string alias)
    {
        WWWForm form = new WWWForm();

        form.AddField("nombre", nombre);
        form.AddField("apellido", apellido);
        form.AddField("cedula", cedula);
        form.AddField("edad", edad);
        form.AddField("ocupacion", ocupacion);
        form.AddField("alias", alias);

        using (UnityWebRequest www = UnityWebRequest.Post("http://plataformarms.000webhostapp.com/RegisterUser.php", form))
        {
            yield return www.SendWebRequest();
            Debug.Log(www.downloadHandler.text);
        }
    }
    public IEnumerator Escribir_Entrenamiento(string ejercicio, int colisiones, float tiempoMax, float tiempoMin, float tiempoProm, int ForUser)
    {
        WWWForm form = new WWWForm();

        form.AddField("fecha", fecha);
        form.AddField("ejercicio", ejercicio);
        form.AddField("colisiones", colisiones);
        form.AddField("tiempoMax", (int)tiempoMax);
        form.AddField("tiempoMin", (int)tiempoMin);
        form.AddField("tiempoProm", (int)tiempoProm);
        form.AddField("ForUser", ForUser);

        using (UnityWebRequest www = UnityWebRequest.Post("http://plataformarms.000webhostapp.com/RegisterEntre.php", form))
        {
            yield return www.SendWebRequest();
            Debug.Log(www.downloadHandler.text);
        }
    }
    public IEnumerator Escribir_Test(float AnguloSup, float AnguloInf, float AnguloIz, float AnguloDer, int forUser)
    {
        WWWForm form = new WWWForm();

        form.AddField("Fecha", fecha);
        form.AddField("AnguloSup", (int)AnguloSup);
        form.AddField("AnguloInf", (int)AnguloInf);
        form.AddField("AnguloIz", (int)AnguloIz);
        form.AddField("AnguloDer", (int)AnguloDer);
        form.AddField("forUser", forUser);

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

        using (UnityWebRequest www = UnityWebRequest.Post("http://plataformarms.000webhostapp.com/Login.php", form))
        {
            yield return www.SendWebRequest();
            Debug.Log(www.downloadHandler.text);
            int.TryParse(www.downloadHandler.text, out IDe);

            Debug.Log("ID usuario: " + IDe);
        }
        IDES = IDe;
    }
}
