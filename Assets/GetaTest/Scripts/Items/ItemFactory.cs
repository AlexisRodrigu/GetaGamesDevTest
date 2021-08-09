using UnityEngine;
using Object = UnityEngine.Object;

public class ItemFactory
{
    private readonly ItemConfiguration _itemConfiguration;

    public ItemFactory(ItemConfiguration itemConfiguration)
    {
        _itemConfiguration = itemConfiguration;
    }

    //Item creado por el id
    public Items Create(string id)
    {
        Object item = _itemConfiguration.GetItemPrefab(id);
        // return (Items) Object.Instantiate(item);
        return (Items) item;
    }
        
}