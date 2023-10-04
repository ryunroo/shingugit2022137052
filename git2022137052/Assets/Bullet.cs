using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroyed : MonoBehaviour
{
    public int attackPoint = 10;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) // �÷��̾�� �浹
        {
            collision.gameObject.GetComponent<PlayerController>().PlayerDamaged(attackPoint);
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
