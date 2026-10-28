using UnityEngine;

public class SphereController : MonoBehaviour
{
    //public float initSpeed = 0.2f;
    public float force;

    private float movement_x;
    private float movement_y;
    private Rigidbody rb;
    private Vector3 direction;

    void Start () 
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update () 
    {
        movement_x = Input.GetAxis("Horizontal");
        movement_y = Input.GetAxis("Vertical");

        direction = new Vector3(movement_x, 0, movement_y);

        if ( direction.magnitude > 1 )
        {
            direction.Normalize();
        }

        //
    
    }

    void FixedUpdate() {

        rb.AddForce(direction * force);
        
        
    }
}


