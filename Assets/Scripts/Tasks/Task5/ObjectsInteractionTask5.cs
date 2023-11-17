using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    [SerializeField] private Shelf[] _shelves;

    private void Awake()
    {
        foreach (var shelf in _shelves)
        {
            shelf.ItemSpawned += OnItemSpawned;
        }
    }

    private void OnItemSpawned(Shelf shelf)
    {
        if (shelf.ItemsCount > 3)
        {
            shelf.Fall();
        }
    }
}