using UnityEngine;

public class TouchControls : MonoBehaviour
{
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>(); //get Player script component
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0) //if touches are greater than 0
        {
            Touch touch = Input.GetTouch(0); //get the touches
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position); //get the touch position on the screen

            if (touchPos.x > 0) //move player based on position of touch
            {
                player.MoveRight();
            }
            else if (touchPos.x < 0)
            {
                player.MoveLeft();
            }
            else
            {
                player.StopMoving();
            }
        }
    }
}
