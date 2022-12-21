using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float Bullet_speed = 24f;
    [SerializeField] private Rigidbody Bullet_rb;
    private void FixedUpdate() {
        Bullet_rb.velocity = BulletPool.instance.shoot_point.right * Bullet_speed;
    }
}
