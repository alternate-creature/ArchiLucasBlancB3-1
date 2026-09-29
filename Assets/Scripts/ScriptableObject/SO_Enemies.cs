using UnityEngine;

[CreateAssetMenu(fileName = "SO_Enemies", menuName = "Scriptable Objects/SO_Enemies")]
public class SO_Enemies : ScriptableObject
{
    public int EnemyType;
    public int Health;
    public float Speed;
    public int MoneyDrop;
}
