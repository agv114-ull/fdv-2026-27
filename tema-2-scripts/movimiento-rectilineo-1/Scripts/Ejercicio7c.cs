using UnityEngine;

public class Ejercicio7c : MonoBehaviour
{
    public GameObject target;
    public float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.transform.position - this.transform.position;
        if (this.transform.position != target.transform.position)
        {
            this.transform.LookAt(target.transform.position);
        }

        // c) MoveTowards no se pasa nunca: si el paso es mayor que lo que falta, deja el objeto justo en el destino
        this.transform.position = Vector3.MoveTowards(this.transform.position, target.transform.position, speed * Time.deltaTime);
        Debug.DrawRay(this.transform.position,direction,Color.red);
    }
}
