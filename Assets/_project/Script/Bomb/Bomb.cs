
using UnityEngine;


public class Bomb : MonoBehaviour
{
    [SerializeField] private int _damage = -2;


    private void OnCollisionEnter (Collision collision)
    {
        if (collision.collider.TryGetComponent<LifeController> (out var life))
        {
            life.AddHp(_damage);

            Destroy(gameObject);
        } 
    }
}
