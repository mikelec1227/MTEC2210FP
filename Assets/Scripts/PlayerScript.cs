using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
public float playerSpeed;
public float bulletSpeed;
public float Bullet;
public GameObject bullet;
public Transform bulletAppears;
public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
      //Player Movement
      float xValue = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
      Vector3 xMovement =  new Vector3(xValue,0,0);
      transform.position += xMovement;

    }
    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        Instantiate (bullet, bulletAppears, enemy);
      }

}
}
