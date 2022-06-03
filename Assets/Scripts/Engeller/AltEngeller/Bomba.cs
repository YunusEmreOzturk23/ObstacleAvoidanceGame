using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : AltEngel
{
    public Karakter karakter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Hareket();
    }
    public override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
        if (collision.gameObject.tag=="karakter")
        {
            Destroy(karakter, 0.5f);
        }
    }
    public override void Hareket()
    {
        base.Hareket();
    }

}
