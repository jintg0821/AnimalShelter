using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medicine : MonoBehaviour
{
    public Camera cam;
    public DogBang Dog;

    // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameObject hitObj = hit.collider.gameObject;
                if (hitObj.GetComponent<DogBang>() != null)
                {
                    Dog = hitObj.GetComponent<DogBang>();
                    Dog.DogCondition = 100;
                    Dog.UpdateCondition();
                    Dog = null;
                }
            }
        }
    }
}
