using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Script : MonoBehaviour
{
    public GameObject this_;
    Color this_color;
    public Rigidbody2D rb;
    public float bullet_speed;
    // Start is called before the first frame update
    void Start()
    {
       rb.GetComponent<Rigidbody2D>();
       rb.velocity = -transform.right * bullet_speed;
       this_color = GetComponent<SpriteRenderer>().color;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject other = collision.gameObject;
        if(other.tag != "Static_Wall")
        {
            other.GetComponent<SpriteRenderer>().color = this_color;
            Destroy(this_);
        }
    }
}
