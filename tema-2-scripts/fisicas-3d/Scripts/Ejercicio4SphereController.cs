using UnityEngine;

public class Ejercicio4SphereController : MonoBehaviour
{

    public GameObject target;
    public float force;
    public float accuracy = 1.7f;

    private Vector3 direction;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        direction = target.transform.position - this.transform.position;

    }

    void FixedUpdate()
    {

        if ( direction.magnitude > accuracy)
        {
            rb.AddForce(direction.normalized*force);
        }


    }

    
}
