using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable/ZombieData",fileName ="ZobieData")]
public class ZomebieData : ScriptableObject
{

    public float health = 100.0f;
    public float damge = 20.0f;
    public float speed = 2f;
    public Color skinColor = Color.white;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
