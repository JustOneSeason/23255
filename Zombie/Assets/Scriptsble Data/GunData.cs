using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable/GunData",fileName = "Gun Data")]
public class GunData : ScriptableObject 
{
    public AudioClip shotClip;
    public AudioClip reloadClip;

    public float damage = 25;

    public int ammoRemain = 100;
    public int magCapacity = 25; // 탄창 용량
    public int magAmmo; // 현재 탄창에 남아있는 탄약

    public float timeBetFire = 0.12f; // 총알 발사 간격

    public float reloadTime = 1.8f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
