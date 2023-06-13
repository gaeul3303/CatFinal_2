using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round01Director : MonoBehaviour
{
    bool item01;
    bool round01_Clear;
    public GameObject student01;
    public GameObject student02;

    // Start is called before the first frame update
    void Start()
    {

        item01 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (item01 == true)
        {
            //
            Debug.Log("Round01 clear");
            round01_Clear = true;
            // mpc active
            this.student01.SetActive(false);
            this.student02.SetActive(true);
        }
    }

    public void setItem01()
    {
        item01 = true;
    }

}
