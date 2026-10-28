using UnityEngine;


public class Ejercicio4Cube : MonoBehaviour 
{
    public GameObject target;
    public float speed;
    public float accuracy;
    public Material nuevoMaterial;

    private float distance;
    private Rigidbody rb;
    private Vector3 direction;
    private bool moving;    


    void Start() 
    {
        distance = (target.transform.position - this.transform.position).magnitude;
        rb = this.GetComponent<Rigidbody>();
    }

    void Update() 
    {
        direction = target.transform.position - this.transform.position;
    }

    void FixedUpdate() 
    {
        if ( moving )
        {
            if ( direction.magnitude > accuracy ) 
            {
                transform.Translate(Vector3.forward* speed *Time.deltaTime);
            }
        }
        
    }


    void OnCollisionEnter() 
    {
        this.GetComponent<Renderer>().material = nuevoMaterial;
        moving = true;

    }
}










