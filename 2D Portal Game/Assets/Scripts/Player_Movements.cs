using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movements : MonoBehaviour
{
    public float movement_speed, jump_speed;
    Vector3 mouse_position;
    public Transform gun;
    //bool isGrounded;
    public Rigidbody2D player;
    public SpriteRenderer orange_bullet, blue_bullet;
    Color orange, blue;
    public GameObject[] panels;
    Vector2 in_velocity;
    void Start()
    {
        //isGrounded = true;
        player = GetComponent<Rigidbody2D>();
        orange = orange_bullet.GetComponent<SpriteRenderer>().color;
        blue = blue_bullet.GetComponent<SpriteRenderer>().color;
        for(int i = 0; i < panels.Length; i++)
        {
            panels[i].GetComponent<GameObject>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = (Input.GetAxisRaw("Horizontal"));
        transform.Translate(new Vector2(moveX * movement_speed * Time.deltaTime, 0f));

        mouse_position = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - gun.transform.position).normalized;
        float angle = Mathf.Atan2(mouse_position.x, mouse_position.y) * Mathf.Rad2Deg;
        gun.eulerAngles = new Vector3(0f, 0f,  0f - angle);

        //if(isGrounded && Input.GetKeyDown(KeyCode.Space))
        //{
        //    Vector2 jump = new Vector2(0f, jump_speed);
        //    player.AddForce(Vector2.up * jump);
        //}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //isGrounded = true;
        GameObject other = collision.gameObject;
        PanelChecker(other);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        //isGrounded = false;
    }
    void PanelChecker(GameObject other)
    {
        if (other.GetComponent<SpriteRenderer>().color == orange)
        {
            for (int i = 0; i < panels.Length; i++)
            {
                if (panels[i].GetComponent<SpriteRenderer>().color == blue)
                {
                    Debug.Log(other.transform.rotation.z);
                    switch (other.transform.rotation.z)
                    {
                        case 0.7071068f:
                            player.transform.position = new Vector2(panels[i].transform.position.x, panels[i].transform.position.y);
                            break;
                        case -0.7071068f:
                            player.transform.position = new Vector2(panels[i].transform.position.x, panels[i].transform.position.y);
                            break;
                        case 0f:
                            player.transform.position = new Vector2(panels[i].transform.position.x, panels[i].transform.position.y);
                            break;
                        case 1f:
                            player.transform.position = new Vector2(panels[i].transform.position.x, panels[i].transform.position.y);
                            break;
                    }
                    
                    in_velocity = player.velocity;
                    player.AddForce(in_velocity * 100f);
                }
            }
        }
        else if (other.GetComponent<SpriteRenderer>().color == blue)
        {
            for (int i = 0; i < panels.Length; i++)
            {
                if (panels[i].GetComponent<SpriteRenderer>().color == orange)
                {
                    Debug.Log(other.transform.rotation.z);
                    switch (other.transform.rotation.z)
                    {
                        case 0.7071068f:
                            player.transform.position = new Vector2(panels[i].transform.position.x, panels[i].transform.position.y);
                            break;
                        case -0.7071068f:
                            player.transform.position = new Vector2(panels[i].transform.position.x, panels[i].transform.position.y);
                            break;
                        case 0f:
                            player.transform.position = new Vector2(panels[i].transform.position.x, panels[i].transform.position.y);
                            break;
                        case 1f:
                            player.transform.position = new Vector2(panels[i].transform.position.x, panels[i].transform.position.y);
                            break;
                    }
                    in_velocity = player.velocity;
                    player.AddForce(in_velocity * 100f);
                }
            }
        }
    }
}
