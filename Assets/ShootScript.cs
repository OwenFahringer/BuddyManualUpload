using System;
using UnityEngine;
using UnityEngine.Rendering;

public class ShootScript : MonoBehaviour
{
    public int ammo;
    public int maxAmmo = 8;

    public float reloadSpeed;
    public GameObject weapon;
    public GameObject projectile;
    public float damage;
    public float bulletSpeed = 50;
    public GameObject[] filter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyUp(KeyCode.Mouse0))
        {
           GameObject proj = Instantiate(projectile);
           proj.transform.position = weapon.transform.position;
           proj.transform.rotation = weapon.transform.rotation * Quaternion.Euler(-1f,-1f, 50f);
            Rigidbody2D projRB = proj.GetComponent<Rigidbody2D>();
            projRB.AddForce(transform.up * -bulletSpeed);
        }
    }
    
}
