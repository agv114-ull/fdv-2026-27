using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{

    public GameObject goal;
    public float speed = 0.1f;

    private Vector3 target;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = goal.transform.position.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        
        this.transform.Translate(target*speed* Time.deltaTime);

    }
}