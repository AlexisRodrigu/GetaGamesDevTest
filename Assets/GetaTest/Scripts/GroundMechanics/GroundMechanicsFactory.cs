using UnityEngine;

public class GroundMechanicsFactory 

{  private readonly GroundMechanicsConfiguration _groundMechanicsConfiguration;

    public GroundMechanicsFactory(GroundMechanicsConfiguration groundMechanicsConfiguration)
    {
        _groundMechanicsConfiguration = groundMechanicsConfiguration;
    }

    //Mecanica creada por el id
    public GroundMechanics Create(string id)
    {
        Object mechanics = _groundMechanicsConfiguration.GetMechanicsPrefab(id);
        // return (Items) Object.Instantiate(item);
        return (GroundMechanics) mechanics;
    }
}
