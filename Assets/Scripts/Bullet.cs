using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _damage;
    private Transform _traget;
    private float _speed;
    private Vector3 _targetPosition;
    public void Initialization(float damage, float lifeTime,float speed,  Transform target)
    {
        _damage = damage;
        _traget = target;
        _targetPosition = _traget.position;
        _speed = speed;
        Destroy(this.gameObject, lifeTime);
    }
    public void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, _traget.position, _speed * Time.fixedDeltaTime);
        Debug.Log(transform.position);
    }
}
