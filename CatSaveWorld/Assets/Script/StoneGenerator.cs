using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneGenerator : MonoBehaviour
{
    public GameObject stonePrefab;
    public GameObject enemy3;
    float distance = 30f;
    float throwPower = 2000f;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)
            && Vector3.Distance(transform.position, enemy3.transform.position) < distance)
        {
            GameObject stone = Instantiate(stonePrefab) as GameObject;

            // 위치 조절 : 플레이어 위치로 
            stone.transform.position = this.transform.position;

            stone.GetComponent<StoneController>().Shoot(Camera.main.transform.forward.normalized * throwPower);

        }
        //Vector3.Distance(transform.position, enemy3.transform.position) < distance
    }
}
