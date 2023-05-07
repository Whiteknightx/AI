using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class aimovement : MonoBehaviour
{
    public Transform[] wayPoint;
    int currentIndex;
    public float speed=1;
    // Start is called before the first frame update
    void Start()
    {
        currentIndex = Random.Range(0, wayPoint.Length);
    }

    // Update is called once per frame
    void Update()
    {
        RandomMove();
    }

    void RandomMove()
    {
        float distance = Vector3.Distance(transform.position, wayPoint[currentIndex].position);

        if (distance < 1f)
        {
            currentIndex = Random.Range(0, wayPoint.Length);
        }
        transform.position = Vector3.MoveTowards(transform.position, wayPoint[currentIndex].position, speed * Time.deltaTime);
    }

    void Move()
    {
        float distance = Vector3.Distance(transform.position, wayPoint[currentIndex].position);

        if (distance < 1f)
        {
            currentIndex = currentIndex == wayPoint.Length-1 ? 0 : currentIndex + 1;
        }
        transform.position = Vector3.MoveTowards(transform.position,wayPoint[currentIndex].position, speed * Time.deltaTime);
    }
}
