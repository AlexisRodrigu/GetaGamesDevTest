using UnityEngine;

public class Items :MonoBehaviour
{
    [SerializeField] private string _idItem;
    public string IDItem => _idItem;
    
    protected void DestroyGO()
    {
        Destroy(gameObject);
    }
}