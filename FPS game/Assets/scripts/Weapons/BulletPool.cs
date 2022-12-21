using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public static BulletPool instance;
    private List<GameObject> pool;
    [SerializeField] public Transform shoot_point;
    [SerializeField] private GameObject bullet_prefab;
    [SerializeField] private int bullet_count;
    private void Awake() {
        if(instance == null){
            instance = this;
        }
    }
    void Start()
    {   pool = new List<GameObject>();
        for (int i = 0; i < bullet_count; i++)
        {
            GameObject clone = Instantiate(bullet_prefab, shoot_point.position, Quaternion.identity);
            clone.SetActive(false);
            pool.Add(clone);
        }
    }
    public void FillBulletPool(Transform shootPoint, int ammo){
        // pool.Clear();
        for (int i = 0; i < pool.Count; i++)
        {
            Destroy(pool[i]);   
        }
        pool.Clear();
        for (int i = 0; i < ammo; i++)
        {
            GameObject clone = Instantiate(bullet_prefab, shoot_point.position, Quaternion.identity);
            clone.SetActive(false);
            pool.Add(clone);
        }
        Debug.Log(pool.Count);
    }
    public GameObject GetBullet(){
        for (int i = 0; i < pool.Count; i++)
        {
            if(!pool[i].activeInHierarchy){
                return pool[i];
            }
            
        }
        return null;
    }
    public void Reload(){
        for (int i = 0; i < pool.Count; i++)
        {
            pool[i].SetActive(false);
        }
    }
}
