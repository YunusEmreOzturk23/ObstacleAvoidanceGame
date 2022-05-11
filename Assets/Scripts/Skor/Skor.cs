using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public  class Skor : MonoBehaviour
{
    
    public int skor;
    public Transform nesne;
    public float rastgele;
    public AudioSource skorSesi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public virtual void OnCollisionEnter2D(Collision2D collision)//virtual for  super class 
    {
        rastgele = Random.Range(0, 0);
        
    }
    public void Hareket()
    {
        nesne.transform.Translate(-2f * Time.deltaTime, 0, 0);
    }
    
}
