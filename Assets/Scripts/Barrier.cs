using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    [SerializeField] GameObject _bricksEffectPrefab;
    private void OnTriggerEnter(Collider other)
    {
        PlayerModifire playerModifire = other.attachedRigidbody.GetComponent<PlayerModifire>();
        if(playerModifire != null )
        {
            playerModifire.HitBarrier();
            Destroy(gameObject);
            Instantiate(_bricksEffectPrefab, transform.position, transform.rotation);
        }
    }
}
