using UnityEngine;

public class MoveObstacles : MonoBehaviour
{
    private float speed = 10;
    private PlayerController playerControllerScript;
    private float borderForObstacles = -15;

    void Start()
    {
        playerControllerScript = GameObject.Find("SimpleFarmer_Brown").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (playerControllerScript.gameOver == false)
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (transform.position.x < borderForObstacles && gameObject.CompareTag("Obstacle"))
            Destroy(gameObject);
    }
}
