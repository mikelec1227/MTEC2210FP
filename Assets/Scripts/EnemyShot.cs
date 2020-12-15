using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
  private Transform EnemyBullet;
  public float speed;


    // Start is called before the first frame update
    void Start()
    {
        EnemyBullet = GetComponent<Transform>();
    }

    // Update is called once per frame
    void fixedUpdate()
    {
      EnemyBullet.position += Vector3.down;
      if (EnemyBullet.position.y <= 10)
      Destroy(EnemyBullet.gameObject);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
      if (other.tag == "Player"){
        Destroy(other.gameObject);
        Destroy(gameObject);
      }
    }
}
