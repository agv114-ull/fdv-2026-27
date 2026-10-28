using UnityEngine;

public class Ejercicio5following : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float accuracy = 0.01f;
     
    private float distance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ería con un findObject coger el gameObject de "player" pero no me acuerdo del método o poner una referencia pública y añadirla desde el inspector veremos
        distance = (player.transform.position - this.transform.position).magnitude;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.transform.position - this.transform.position;
        if(direction.magnitude > accuracy)
        {
            this.transform.LookAt(player.transform.position);
            //Quaternion.LookRotation(this.transform.position, direction, 10f);
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            Debug.DrawRay(this.transform.position,direction,Color.red);
        }
        
 
    }
}
