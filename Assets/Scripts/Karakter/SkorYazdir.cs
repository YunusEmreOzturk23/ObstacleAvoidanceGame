using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SkorYazdir : MonoBehaviour
{
    public TextMeshProUGUI skor_text;
    int skor=0;
    public TextMeshProUGUI can_text;
    int can=3;
    public TextMeshProUGUI stop_text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        skor_text.text = "skor: " + skor.ToString();
        can_text.text = "can: " + can.ToString();
        if (can == 0)
        {
            Time.timeScale=0;
            stop_text.text = "Oyun Bitti! Yeniden Baþlatmak icin space ana ekrana donus icin x ebas";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                SceneManager.LoadScene("Giris");
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "skor")
        {
            skor += 5;
        }
        if (collision.gameObject.tag == "engel")
        {
            can -= 1;
        }
    }
}
