using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAnimatorController : MonoBehaviour
{
    public Animator DogAnimator;
    public GameObject target;
    public GameObject dog;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            DogAnimator.SetInteger("status", 0);
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            DogAnimator.SetInteger("status", 1);
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            DogAnimator.SetInteger("status", 2);
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            // smooth follow
            dog.transform.LookAt(target.transform);
        }
       

    }
}
