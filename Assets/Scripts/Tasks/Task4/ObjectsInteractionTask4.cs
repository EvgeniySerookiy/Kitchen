using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    [SerializeField] private Toaster _toaster;
    [SerializeField] private Transform _waffleRoot;
    [SerializeField] private Waffle _prefabs;
    
    public void Awake()
    {
        _toaster.TimerIsUp += OnTimerIsUp;
    }

    private void OnTimerIsUp()
    {
        Instantiate(_prefabs, _waffleRoot);
    }

    private void OnDestroy()
    {
        _toaster.TimerIsUp -= OnTimerIsUp;
    }
}