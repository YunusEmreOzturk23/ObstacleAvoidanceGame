using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UstEngel : Engeller
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        rastgele = Random.Range(-7.90f, 7.90f);
        if (collision.gameObject.tag == "zemin" || collision.gameObject.tag=="karakter")
        {
            engel.position = new Vector2(rastgele, 5.22f);
        }
    }
}
