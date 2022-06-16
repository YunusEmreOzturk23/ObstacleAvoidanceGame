using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Baslat : MonoBehaviour
    
{    // Start is called before the first frame update
    public TextMeshProUGUI tekrarText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DigerSahne()
    {
        SceneManager.LoadScene("Game");
    }
    public void TekrarOynat()
    {
        tekrarText.text = "Sen Bilirsin. Oynamak için evet tusuna bas";
    }
  
}
