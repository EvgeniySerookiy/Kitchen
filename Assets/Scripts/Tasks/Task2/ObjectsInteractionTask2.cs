using System;
using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    [SerializeField] private Transform _lampRoot;
    [SerializeField] private GameObject _prefabs;

    public void Awake()
    {
        Instantiate(_prefabs, _lampRoot);
    }
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps)    
}