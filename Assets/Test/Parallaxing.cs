using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxing : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] backgrounds;
    public float[] parallaxScales;
    public float smoothing;

    private Vector3 previousCameraPosition;
    void Start()
    {
        previousCameraPosition = transform.position;

        parallaxScales = new float[backgrounds.Length];
        for(int i=0; i<parallaxScales.Length; i++)
        {
            parallaxScales[i] = backgrounds[i].position.z * -1;
        }

    }

    // Update is called once per frame
    void LateUpdate()
    {
        for(int i=0; i<backgrounds.Length; i++)
        {
            Vector3 parallax = (previousCameraPosition - transform.position) * (parallaxScales[i] / smoothing);
            backgrounds[i].position = new Vector3(backgrounds[i].position.x + parallax.x, backgrounds[i].position.y + parallax.y, backgrounds[i].position.z);

        }

        previousCameraPosition = transform.position;   

    }
}
