using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStick : MonoBehaviour
{
    public Transform player;
    public float speed = 5.0f;
    public float balloonUpSpeed = 2f;
    public static bool touchStart = false;
    public static bool joysticActive = true;
    private Vector2 pointA;
    private Vector2 pointB;
    private GameObject pan;
    public Transform circle;
    public Transform outerCircle;
    public Sprite BalloonMove;
    public Sprite BalloonIdle;

    // Update is called once per frame

    private void Start()
    {
        joysticActive = true;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));

            circle.transform.position = pointA * -1;
            outerCircle.transform.position = pointA * 1;
            circle.GetComponent<SpriteRenderer>().enabled = true;
            outerCircle.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (Input.GetMouseButton(0))
        {
            touchStart = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }
        else
        {
            touchStart = false;
        }

        if (touchStart == false)
        {
            player.Translate((new Vector3(0, 1, 0)) * balloonUpSpeed * Time.deltaTime);
        }

        if(joysticActive == false)
        {
            circle.GetComponent<SpriteRenderer>().enabled = false;
            outerCircle.GetComponent<SpriteRenderer>().enabled = false;
        }

    }
    private void FixedUpdate()
    {
        if (touchStart)
        {
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            moveCharacter(direction * 1);

            circle.transform.position = new Vector2(pointA.x + direction.x, pointA.y + direction.y) * 1;
            //outerCircle.transform.position = new Vector2(pointA.x + direction.x, pointA.y + direction.y) * 1;
            player.GetComponent<SpriteRenderer>().sprite = BalloonMove;
            
        }
        else
        {
            circle.GetComponent<SpriteRenderer>().enabled = false;
            outerCircle.GetComponent<SpriteRenderer>().enabled = false;
            player.GetComponent<SpriteRenderer>().sprite = BalloonIdle;


        }

    }
    void moveCharacter(Vector2 direction)
    {
        player.Translate(direction * speed * Time.deltaTime);
        
    }
}
