using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

  private Transform bullet;
  public float speed;


    void Start()
    {
      bullet = GetComponent<Transform>();


    }

    // Update is called once per frame
    void Update()
    {

    }
}
