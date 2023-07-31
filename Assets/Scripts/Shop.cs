using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] CoinManager _coinManager;
    PlayerModifire _playerModifire;
    private void Start()
    {
        _playerModifire=FindObjectOfType<PlayerModifire>();
    }
    public void BuyWidth()
    {
        if (_coinManager.NumberOfCoins >= 20)
        {
            _coinManager.SpendMoney(20);
            Progress.Instance.Coins -= 20;
            Progress.Instance.Width += 25;
            _playerModifire.SetWidth(Progress.Instance.Width);
        }
    }
    public void BuyHeigth()
    {
        if (_coinManager.NumberOfCoins >= 20)
        {
            _coinManager.SpendMoney(20);
            Progress.Instance.Coins -= 20;
            Progress.Instance.Height += 25;
            _playerModifire.SetWidth(Progress.Instance.Height);
        }
    }
}
