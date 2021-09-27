using UnityEngine;
using System.Collections;

public class PacMan : MonoBehaviour
{
    public float speed = 1.0f;
    public int i = 0;
    public GameObject pocMan;


    Vector3[] positionArray = new[] { new Vector3(-8.5f, 2.6f, -9.65f),
                                      new Vector3(-3.5f, 2.7f, -9.65f),
                                      new Vector3(-3.45f, -1.4f, -9.65f),
                                      new Vector3(-8.55f, -1.35f, -9.65f)
     };

    void Update()
    {
        float step = speed * Time.deltaTime; 
        transform.position = Vector3.MoveTowards(transform.position, positionArray[i], step);

        if (Vector3.Distance(transform.position, positionArray[i]) < 0.001f)
        {
            pocMan.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
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