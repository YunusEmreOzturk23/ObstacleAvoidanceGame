using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AltEngel : Engeller
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Hareket();
    }
    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        rastgele = Random.Range(-2.50f, -0.2f);
        if (collision.gameObject.tag == "geri" || collision.gameObject.tag == "karakter")
        {
            engel.position =new Vector2(9.17f, rastgele);
        }
        

    }
    public virtual void Hareket()
    {
        transform.Translate(-2f * Time.deltaTime, 0, 0);
    }
    
}
