using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Block : MonoBehaviour
{
    [SerializeField] private Vector2Int _destroyPriceRange;

    private int _destroyPrice;
    private int _filling;

    public int LeftToFill => _destroyPrice - _filling;
    public event UnityAction<int> FillingUpdated;

    private void Start()
    {
        _destroyPrice = Random.Range(_destroyPriceRange.x, _destroyPriceRange.y);
        FillingUpdated?.Invoke(LeftToFill);
    }

    public void Fill()
    {
        _filling++;
        FillingUpdated?.Invoke(LeftToFill); 

        if (_filling == _destroyPrice)
        {
            Destroy(gameObject);        
        }
    }
}