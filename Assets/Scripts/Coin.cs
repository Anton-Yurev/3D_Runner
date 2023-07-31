using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float speed = 15.0f;
    [SerializeField] GameObject _effectPrefab;
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<CoinManager>().AddOne();
        Destroy(gameObject);
        Instantiate(_effectPrefab, transform.position, transform.rotation);

    }
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, 0, 0);
    }
}
