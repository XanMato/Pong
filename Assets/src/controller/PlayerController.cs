using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{


    public KeyCode up;
    public KeyCode down;

   	public float speed = 0.3f;
    private GameObject top;
    private GameObject bottom;

    // Use this for initialization
    void Start()
    {

        top = GameObject.Find("border_top");
        bottom = GameObject.Find("border_bottom");

    }

    // Update is called once per frame
    void Update()
    {

        move();
    }

    private void move()
    {
        if (Input.GetKey(up) && transform.position.y + transform.localScale.y / 2 < top.transform.position.y - top.transform.localScale.y / 2)
        {
            transform.Translate(0, speed, 0);
        }
        else if (Input.GetKey(down) && transform.position.y - transform.localScale.y / 2 > bottom.transform.position.y + bottom.transform.localScale.y / 2)
        {
            transform.Translate(0, -speed, 0);
        }
    }
}
