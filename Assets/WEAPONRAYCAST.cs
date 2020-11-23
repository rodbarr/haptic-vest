
using UnityEngine;

public class WEAPONRAYCAST : MonoBehaviour
{
    private GameObject raycastedObj;
    [SerializeField] private int raylenght = 100;
    [SerializeField] private LayerMask layerMaskInteract;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, raylenght,layerMaskInteract.value))
        {
            if (hit.collider.CompareTag("BOX"))
            {
                raycastedObj = hit.collider.gameObject;
                if (Input.GetKeyDown("mouse 0"))
                {
                    SerialController.Send("1");
                    Debug.Log("I HAVE INTERACTED WITH AN OBJECT");
                }
            }
        }

    }
   
}
