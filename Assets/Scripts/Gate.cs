using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] int _value;

    [SerializeField] DeformationType _deformationType;

    [SerializeField] GateAppeareance _gateApperiens;
    private void OnValidate()
    {
        _gateApperiens.UpdateVisual(_deformationType, _value);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerModifire playerModifire = other.attachedRigidbody.GetComponent<PlayerModifire>();
        if (playerModifire!=null)
        {
            if(_deformationType==DeformationType.Width)
            {
                playerModifire.AddWidth(_value);
            } else if (_deformationType == DeformationType.Height)
            {
                playerModifire.AddHeight(_value);
            }
            Destroy(gameObject);
        }
    }
}
