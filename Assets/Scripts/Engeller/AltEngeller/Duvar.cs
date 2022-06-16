using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duvar : AltEngel
{
    void Start()
    {
        
    }

    void Update()
    {
        Hareket();
    }
    public override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
        if (collision.gameObject.tag == "karakter")
        {
            engelSesi.Play();
        }
    }
    public override void Hareket()
    {
        base.Hareket();
    }
}
