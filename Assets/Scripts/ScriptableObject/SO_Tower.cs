using UnityEngine;

[CreateAssetMenu(fileName = "SO_Tower", menuName = "Scriptable Objects/SO_Tower")]
public class SO_Tower : ScriptableObject
{
    public int price;
    public int towerType;
    public int damage;
    public int attackSpeede;
    public int range;
}
