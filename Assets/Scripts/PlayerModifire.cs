using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class PlayerModifire : MonoBehaviour
{
    [SerializeField] int _width;
    [SerializeField] int _height;

    [SerializeField] Renderer _renderer;

    float _widthMultiplier = 0.0005f;
    float _heightMultiplier = 0.01f;

    [SerializeField] Transform _topSpine;
    [SerializeField] Transform _bottomSpine;

    [SerializeField] Transform _colliderTransform;

    private void Start()
    {
        SetHeight(Progress.Instance.Height);
        SetWidth(Progress.Instance.Width);
    }
    void Update()
    {
        float offsetY = _height * _heightMultiplier + 0.17f;
        _topSpine.position = _bottomSpine.position + new Vector3(0, offsetY, 0);
        _colliderTransform.localScale = new Vector3(0, 1.84f + _height * _heightMultiplier, 0);
    }

    public void AddWidth(int value)
    {
        _width += value;
        UpdateWidth();
    }
    public void AddHeight(int value)
    {
        _height += value;
    }

    public void SetWidth(int value)
    {
        _width += value;
        UpdateWidth();
    }

    public void SetHeight(int value)
    {
        _height += value;
    }

    public void HitBarrier()
    {
        if (_height > 0)
        {
            _height -= 50;
        }
        else if (_width > 0)
        {
            _width -= 50;
            UpdateWidth();
        }
        else
        {
            Die();
        }
    }

    public void UpdateWidth()
    {
        _renderer.material.SetFloat("_PushValue", _width * _widthMultiplier);
    }

    void Die()
    {
        Destroy(gameObject);
        FindObjectOfType<GameManager>().ShowFinishWindow("you dead");
    }
}
