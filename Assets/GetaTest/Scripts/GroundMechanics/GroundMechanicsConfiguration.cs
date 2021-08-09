using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

[CreateAssetMenu(fileName = "GroundMechanicsConfiguration", menuName = "CreateMechanics", order = 0)]
public class GroundMechanicsConfiguration : ScriptableObject
{
    [SerializeField] private GroundMechanics[] _groundMechanics;
    private Dictionary<string, GroundMechanics> _idGroundMechanics;


    private void Awake()
    {
        _idGroundMechanics = new Dictionary<string, GroundMechanics>();
        foreach (var mechanics in _groundMechanics)
        {
            _idGroundMechanics.Add(mechanics.IDMechanics, mechanics);
        }
    }


    public Object GetMechanicsPrefab(string id)
    {
        if (!_idGroundMechanics.TryGetValue(id,out var groundMechanics))
        {
            throw new Exception($"Item {id} does exist");
        }

        return groundMechanics;
    }
}
