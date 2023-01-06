using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleUpdate : MonoBehaviour
{
    public GameObject Image1 = null;
    public GameObject Image2 = null;
    Vector3 dist;
    float mod = 0;
    float min = 0.2f;

    void Update()
    {
        MarkDist SpherePosition = Image1.GetComponent<MarkDist>();
        MarkDist CubePosition = Image2.GetComponent<MarkDist>();
        dist = SpherePosition.delta - CubePosition.delta;
        if (SpherePosition.goIn == true && CubePosition.goIn == true)
        {
            mod = dist.magnitude;
            if(mod < min)
            {
                Debug.LogWarning("Nice");
            }
            Debug.Log("module" + mod);
        }
    }
}
