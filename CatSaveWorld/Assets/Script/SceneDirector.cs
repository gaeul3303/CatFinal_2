using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDirector : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveToMapScene()
    {
        SceneManager.LoadScene("MapScene");
        DontDestroyOnLoad(this.gameObject);
    }

    public void MoveToOpeningScnene()
    {
        SceneManager.LoadScene("OpeningScene");
        DontDestroyOnLoad(this.gameObject);
    }

}
