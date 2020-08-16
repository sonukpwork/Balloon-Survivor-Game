using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundscript : MonoBehaviour
{
    public static AudioClip explode;
    static AudioSource audSorce;
    // Start is called before the first frame update
    void Start()
    {
        explode = Resources.Load<AudioClip>("explode");
     
        audSorce = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void Soundplay(string audio)
    {
       
        if (audio == "explode") {
            audSorce.PlayOneShot(explode);
        }
        else
        {
            Debug.Log("not found");
        }
    }
}
