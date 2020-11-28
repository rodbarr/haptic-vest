
using UnityEngine;

public class WEAPONRAYCAST : MonoBehaviour
{
    private GameObject raycastedObj;
    [SerializeField] private int raylenght = 100;
    [SerializeField] private LayerMask layerMaskInteract;
    // Update is called once per frame
    void Start(){
        SerialController.Send("1");
    }
    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, raylenght,layerMaskInteract.value))
        {
            if (hit.collider.CompareTag("RIGHTC"))
            {
                raycastedObj = hit.collider.gameObject;
                if (Input.GetKeyDown("mouse 0"))
                {
                    SerialController.Send("2"); //Send code to arduino to activate the right part of the vest
                    //Debug.Log("I HAVE INTERACTED WITH AN OBJECT");
                    Debug.Log("Right Chest");
                }
            }
            else if (hit.collider.CompareTag("LEFTC"))
            {
                raycastedObj = hit.collider.gameObject;

                if (Input.GetKeyDown("mouse 0"))
                {
                    SerialController.Send("3"); //Send code to arduino to activate the right part of the vest
                    Debug.Log("Left Chest");
                }
            }
            else if (hit.collider.CompareTag("BACK"))
            {
                raycastedObj = hit.collider.gameObject;
                
                if (Input.GetKeyDown("mouse 0"))
                {
                    SerialController.Send("4");  //Send code to arduino to activate the right part of the vest
                    Debug.Log("Back");
                }
            }
        }

    }
   
}
