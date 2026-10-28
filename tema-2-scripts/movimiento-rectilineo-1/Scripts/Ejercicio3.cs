using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{

    public Transform goal;
    public float speed = 1.0f;

    private Vector3 target;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.LookAt(goal.position);
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direction = goal.position - this.transform.position;
        this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        Debug.DrawRay(this.transform.position,direction,Color.red);

    }
}