using UnityEngine;

public class Ejercicio1d : MonoBehaviour
{

    public GameObject goal;
    public float speed = 2.0f;
    public float runway = 5.0f;

    private Vector3 target;
    private Vector3 start;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = goal.transform.position;
        start = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // d) en la pista avanza con Y = 0 (como en b); cuando la ha recorrido, usa la Y del goal (como en c) y despega
        Vector3 direction = target;
        if ((this.transform.position - start).magnitude <= runway)
        {
            direction.y = 0;
        }

        this.transform.LookAt(this.transform.position + direction);
        this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }
}
