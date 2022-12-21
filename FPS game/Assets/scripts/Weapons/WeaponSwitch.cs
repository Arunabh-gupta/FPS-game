using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch: MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject[] Weapons;
    [SerializeField] private GameObject WeaponHolder;
    [SerializeField] private GameObject CurrentWeapon;
    private int currentWeaponIndex = 0;
    private void Start() {
        int totalWeapons = WeaponHolder.transform.childCount;
        Weapons = new GameObject[totalWeapons];
        for (int i = 0; i < totalWeapons; i++)
        {
            Weapons[i] = WeaponHolder.transform.GetChild(i).gameObject;
            Weapons[i].SetActive(false);
        }
        Weapons[0].SetActive(true); // setting first weapon active
        CurrentWeapon = Weapons[0];
    }
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.Alpha1)){
        //     Weapons[0].SetActive(true);
        //     BulletPool.instance.FillBulletPool(Weapons[0].transform, 30);
        //     Weapons[1].SetActive(false);
        // }
        // if(Input.GetKeyDown(KeyCode.Alpha2)){
        //     Weapons[1].SetActive(true);
        //     BulletPool.instance.FillBulletPool(Weapons[1].transform, 10);
        //     Weapons[0].SetActive(false);
        // }
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            BulletPool.instance.FillBulletPool(Weapons[0].transform.GetChild(0).transform, 10);
            ChangeWeapon(0);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            BulletPool.instance.FillBulletPool(Weapons[1].transform.GetChild(0).transform, 30);
            ChangeWeapon(1);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)){
            ChangeWeapon(2);
        }
        // if(Input.GetKeyDown(KeyCode.Alpha4)){
        //     ChangeWeapon(4);
        // }
    }
    void ChangeWeapon(int index){
        CurrentWeapon.SetActive(false);
        currentWeaponIndex = index;
        CurrentWeapon = Weapons[currentWeaponIndex];
        CurrentWeapon.SetActive(true);
    }
}
// [System.Serializable]
class Pair<TFirst, TSecond> {

  public TFirst First { get; set; }

  public TSecond Second { get; set; }

}
