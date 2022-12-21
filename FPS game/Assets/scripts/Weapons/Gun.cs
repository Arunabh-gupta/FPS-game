using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    public float Range = 100f;
    public float fireRate = 10f;
    public Camera fpsCam;
    float damage = 10f;
    float nextTimeTofire = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time>= nextTimeTofire){
            shooting();
        }
    }
    void shooting(){
        RaycastHit hit;
        nextTimeTofire = Time.time + 1f/fireRate;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, Range)){
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            // hit.rigidbody.AddForce(-hit.normal * 100f);
            if(target != null){
                target.TakeDamage(damage);
            }
        }
    }
}
