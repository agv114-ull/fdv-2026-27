using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
    public GameObject target;
    public float speed;
     
    private float distance;
    public float accuracy = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.transform.position - this.transform.position;
        if(direction.magnitude > accuracy)
        {
            this.transform.LookAt(target.transform.position);
            //Quaternion.LookRotation(this.transform.position, direction, 10f);
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            Debug.DrawRay(this.transform.position,direction,Color.red);
        }
        
 
    }
}
