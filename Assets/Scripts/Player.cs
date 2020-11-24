using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Rigidbody myRigidbody;

    //public static int moneyAmount;
    //int lightSphere;
    //int whiteSphere;

    //public GameObject light;
    //public GameObject white;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

        //moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        //lightSphere = PlayerPrefs.GetInt ("lightSphere");
        //whiteSphere = PlayerPrefs.GetInt("whiteSphere");

        //if (lightSphere == 1)
        //{
        //    light.SetActive(true);
        //}
        //else
        //{
        //    light.SetActive(false);
        //}

        //if (whiteSphere == 1)
        //{
        //    white.SetActive(true);
        //}
        //else
        //{
        //    white.SetActive(false);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        DetectInput();
        //float horizontal = Input.GetAxis("Horizontal");
        //Movement(horizontal);

        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        //transform.position += movement * Time.deltaTime * moveSpeed;

    }

    public void MoveLeft()
    {
        myRigidbody.velocity = new Vector2(-moveSpeed, myRigidbody.velocity.y);
    }

    public void MoveRight()
    {
        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);
    }

    public void StopMoving()
    {
        myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
    }

    private void DetectInput()
    {
        float x = Input.GetAxisRaw("Horizontal");
        if (x > 0)
        {
            MoveRight();
        }
        else if (x < 0)
        {
            MoveLeft();
        }
        else
        {
            StopMoving();
        }
    }
}

//public void Movement(float horizontal)
//{
//    myRigidbody.velocity = new Vector2(horizontal * moveSpeed, myRigidbody.velocity.y);
//}
