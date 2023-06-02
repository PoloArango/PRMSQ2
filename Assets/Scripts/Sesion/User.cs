using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    public string usuario;
    public Web Web;
    public Sesion sesion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // sesion.Alias = usuario;
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Web.Login(usuario));
        sesion.Alias = usuario;
        sesion.Mostrar_User();
        Debug.Log("sesion.Alias = Usuario :" + usuario);
        
    }
}
