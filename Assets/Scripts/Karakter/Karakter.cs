using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    public float ziplamaGucu;
    public float hareketHizi;
    public Rigidbody2D rigi;
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){
            rigi.AddForce(new Vector3(0, ziplamaGucu,0), ForceMode2D.Impulse);
            //transform.Translate(0, Time.deltaTime * ziplamaGucu, 0);
        } 
        if (Input.GetKeyDown(KeyCode.A))
        {
            rigi.AddForce(new Vector3(-hareketHizi,0,0), ForceMode2D.Impulse);
            //transform.Translate(-Time.deltaTime * hareketHizi, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rigi.AddForce(new Vector3(hareketHizi,0,0), ForceMode2D.Impulse);
            //transform.Translate(Time.deltaTime * hareketHizi, 0, 0);
        }
    }
}
