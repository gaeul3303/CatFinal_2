using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToClass : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(this.gameObject.name == "ClassDoor" && collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene("ClassScene");
        }
        else if (this.gameObject.name == "ExitDoor" && collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene("MapScene");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
