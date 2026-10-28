using UnityEngine;
using System.Collections.Generic;

public class Ejercicio10 : MonoBehaviour
{

    private List<GameObject> waypoints = new List<GameObject>();
    private int current = 0;

    public float speed;
    public float accuracy = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;
        GameObject wp = GameObject.Find("Waypoint" + i);
        while (wp != null)
        {
            waypoints.Add(wp);

            // marcador: una esfera en cada waypoint
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Destroy(sphere.GetComponent<Collider>());
            sphere.transform.SetParent(wp.transform, false);
            sphere.transform.localScale = Vector3.one * 0.5f;

            i++;
            wp = GameObject.Find("Waypoint" + i);
        }
    }

    Vector3 calculateDirection(GameObject waypoint)
    {
        return (waypoint.transform.position - this.transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        if (waypoints.Count == 0) return;

        if (Vector3.Distance(this.transform.position, waypoints[current].transform.position) < accuracy)
        {
            current = (current + 1) % waypoints.Count;
        }

        Vector3 direction = calculateDirection(waypoints[current]);
        this.transform.LookAt(waypoints[current].transform.position);
        this.transform.Translate(speed * Time.deltaTime * direction, Space.World);
    }
}
