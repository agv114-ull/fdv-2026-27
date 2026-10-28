using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    public GameObject target;
    public float speed = 2.0f;
    public float rotSpeed = 2.0f;
    public float accuracy = 1.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.transform.position - this.transform.position;
        if(direction.magnitude > accuracy)
        {
            // Slerp recibe dos Quaternion: LookRotation pasa la direccion a la rotacion final
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, lookRotation, rotSpeed * Time.deltaTime);
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            Debug.DrawRay(this.transform.position,direction,Color.red);
        }
    }
}
