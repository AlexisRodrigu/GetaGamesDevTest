using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

[CreateAssetMenu(fileName = "ItemsConfiguration", menuName = "CreateItem", order = 0)]
public class ItemConfiguration : ScriptableObject
{
    [SerializeField] private Items[] _items;
    private Dictionary<string, Items> _idItems;

    private void Awake()
    {
        _idItems = new Dictionary<string, Items>();
        foreach (var item in _items)
        {
            _idItems.Add(item.IDItem, item);
        }
    }

    public Object GetItemPrefab(string id)
    {
        if (!_idItems.TryGetValue(id,out var item))
        {
            throw new Exception($"Item {id} does exist");
        }

        return item;
    }
}