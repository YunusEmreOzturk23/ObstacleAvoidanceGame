using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kalp : Skor
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
    public override void OnCollisionEnter2D(Collision2D collision)
    {
        rastgele = Random.Range(-2.73f, -0.21f);
        if (collision.gameObject.tag == "karakter")
        {
            skor = skor + 5;
            nesne.position = new Vector2(9, rastgele);
        }
        if (collision.gameObject.tag == "geri")
        {
            nesne.position = new Vector2(9, rastgele);
        }
        if (collision.gameObject.tag == "karakter")
        {
            skorSesi.Play();
        }
    }
}
