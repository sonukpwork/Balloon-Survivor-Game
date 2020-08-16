using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explosion;
    public GameObject pan;
   
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
       
        Debug.Log("Collision Detected");
        GameObject e = Instantiate(explosion) as GameObject;
        e.transform.position = transform.position;  //At position of Collision
        Soundscript.Soundplay("explode"); //Sound Enable
        this.gameObject.SetActive(false);          //Making Object invisible in which collider is attached.
        //Destroy(collision.gameObject); //Destroying Object in which collider is attached.
        
        pan.SetActive(true);

        BgScroller.shoudMove = false;
        JoyStick.joysticActive = false;
      

    }

    //IEnumerator LateCall(int sec)
    //{
    //    //gameObject.SetActive(true);
    //    yield return new WaitForSeconds(sec);
    //    Time.timeScale = 0;

    //}
}
