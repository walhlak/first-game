 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{


    public Transform options;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Startmenu()
    {

        SceneManager.LoadScene(1);  

    }

    public void Options()
    {

        options.gameObject.SetActive(true);   
    
    }
    


}
