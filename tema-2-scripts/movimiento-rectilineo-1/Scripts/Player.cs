
using UnityEngine;

public class Player : MonoBehaviour 
{
    public float initSpeed = 0.2f;
    public float a;
    public float speed;

    void Start () 
    {

    }

    void Update () 
    {
        // no me acuerdo cómo era la sintaxis para coger el WASD
        float movement_x = Input.GetAxis("Horizontal");
        float movement_y = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(movement_x, movement_y, 0);

        if ( direction.magnitude > 1 )
        {
            direction.Normalize();
        }

        

        // bueno no me acuerdo de cómo era la sintaxis de pulsar la tecla X en este caso espaciadora if ( Input.GetKeyDown() ) 
        if ( Input.GetKey(KeyCode.Space) )
        {
            speed = initSpeed*a; // acelera cada vez que mantiene
            
        }
        

        this.transform.Translate(direction*speed* Time.deltaTime, Space.World);
    }
}