using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Script : MonoBehaviour
{
    Color bullet_color;
    public SpriteRenderer[] panels;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < panels.Length; i++)
        {
            panels[i].GetComponent<SpriteRenderer>();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject bullet = collision.gameObject;
        bullet_color = bullet.GetComponent<SpriteRenderer>().color;
        for(int i = 0; i < panels.Length; i++)
        {
            if(panels[i] != gameObject.GetComponent<SpriteRenderer>())
            {
                if(panels[i].color == bullet_color)
                {
                    panels[i].color = Color.white;
                }
            }
        }
    }
}
