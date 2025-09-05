using UnityEngine;

[CreateAssetMenu(fileName = "NameData", menuName = "Scriptable Objects/NameData")]
public class NameData : ScriptableObject
{
    public string name;
    public string description;
    public GameObject namePrefab;

    public float fireRate;
    public int ammo;

}
