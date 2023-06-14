using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneController : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }


    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "NPC_3")
        {
            Enemy3 VM = other.gameObject.GetComponent<Enemy3>();
            VM.HitVillain();
            Destroy(this.gameObject);

        }
        //GetComponent<Rigidbody>().isKinematic = true;
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
