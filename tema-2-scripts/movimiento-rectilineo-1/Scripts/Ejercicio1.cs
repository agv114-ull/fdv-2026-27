using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{

    public GameObject goal;

    private Vector3 target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = goal.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // a)
        this.transform.Translate(target);

        target = target*0.5f;
    }
}
