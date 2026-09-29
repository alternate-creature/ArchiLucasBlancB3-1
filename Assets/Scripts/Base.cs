using UnityEngine;

public class Base : MonoBehaviour
{
    [SerializeField] private int baseHealth;

    public void TakeDmg(int enemyHealth)
    {
        baseHealth = Mathf.Clamp(baseHealth - enemyHealth, 0, baseHealth);
    }
}
