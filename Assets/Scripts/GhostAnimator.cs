using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAnimator : MonoBehaviour
{

    public GameObject gameObject;
    public float time = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(RotateGhost), 0.5f, this.time);
    }

    void RotateGhost()
    {
        gameObject.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
