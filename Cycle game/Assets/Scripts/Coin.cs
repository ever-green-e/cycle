using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField] float turnSpeed = 90f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Obstacle>() != null)
        {
            Destroy(gameObject);
            return;
        }
        //check that the object we collided with is the player
        if (other.gameObject.name != "Player")
        {
            return;
        }
        //add to the players score

        GameManager.inst.IncrementScore();

        //destroy the coin object
        Destroy(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
}
