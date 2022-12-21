using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Fire();
        }
        if(Input.GetKey(KeyCode.R)){
            BulletPool.instance.Reload();
        }
    }
    private void Fire(){
        GameObject bullet = BulletPool.instance.GetBullet();
        if(bullet!=null){
            bullet.transform.position = transform.position;
            bullet.SetActive(true);
            // bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bullet_speed * Time.deltaTime, ForceMode.Impulse);
        }
    }
}
