using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HM : MonoBehaviour
{
    public enum Hitmrkr{Body, Head}
    public Hitmrkr hitmarkerttype;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(hitmarkerttype == Hitmrkr.Body && other.gameObject.tag =="bullet")
        {
            Health.instance.maxHealth -= 10;
        }
        else if (hitmarkerttype == Hitmrkr.Head && other.gameObject.tag == "bullet")
        {
            Health.instance.maxHealth -= 10;
        }
    }

}
