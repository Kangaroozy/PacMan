using UnityEngine;
using System.Collections;

public class PacMan : MonoBehaviour
{
    public float speed = 1.0f;
    public int i = 0;
    public GameObject pocMan;


    Vector3[] positionArray = new[] { new Vector3(-9.15f, 14.3f, -9.0f),
                                      new Vector3(-3.8f, 14.3f, -9.0f),
                                      new Vector3(-3.8f, 10.2f, -9.0f),
                                      new Vector3(-9.15f, 10.2f, -9.0f)
     };

    void Update()
    {
        float step = speed * Time.deltaTime; 
        transform.position = Vector3.MoveTowards(transform.position, positionArray[i], step);
        if (Vector3.Distance(transform.position, positionArray[i]) < 0.001f)
        {

            if (i == 3)
            {
                i = 0;
            }
            else
            {
                i++;
            }
        }

    }
}