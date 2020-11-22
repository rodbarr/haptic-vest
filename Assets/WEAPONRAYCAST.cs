
using UnityEngine;
using System.Threading;
using Sysem.IO.Port;

public class WEAPONRAYCAST : MonoBehaviour
{
    private GameObject raycastedObj;

    [SerializeField] private int raylenght = 100;
    [SerializeField] private LayerMask layerMaskInteract;
    // Update is called once per frame
    void Update()
    {
        SystemPort sp;
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, raylenght,layerMaskInteract.value))
        {
            if (hit.collider.CompareTag("BOX"))
            {
                raycastedObj = hit.collider.gameObject;
                if (Input.GetKeyDown("mouse 0"))
                {
                    SerialPort sp = new SerialPort();
                    sp.PortName = "COM4";//Check before run 
                    sp.BaudRate = 9600;
                    sp.Open();
                    sp.Write("chest");
                    Debug.Log("I HAVE INTERACTED WITH AN OBJECT");
                }
            }
        }

    }
   
}
