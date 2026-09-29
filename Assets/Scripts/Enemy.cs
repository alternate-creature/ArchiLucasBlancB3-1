using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private SO_Enemies data;
    private bool isDead;

    void Start()
    {
        
    }

    private void Move()
    {
        transform.position = transform.position + Vector3.right * data.Speed * Time.deltaTime; // Change variable later.
    }

    private void TakeDmg(int dommage)
    {
        data.Health = Mathf.Clamp(data.Health - dommage, 0, data.Health);
    }


    // Update is called once per frame
    void Update()
    {
        Move();
        
    }
}
