using UnityEngine;

public class Ejercicio3Collision : MonoBehaviour
{
   
    public string mensaje;
    public Material nuevoMaterial; 


    void Start () 
    {
    }

    void Update () 
    {
        
        
    }

    void OnCollisionEnter(Collision other) 
    {
        other.gameObject.GetComponent<Renderer>().material = nuevoMaterial;

        mensaje = other.gameObject.name; 

        Debug.Log(mensaje);
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 400, 30), mensaje);   // x, y, ancho, alto en píxeles
    }
}


