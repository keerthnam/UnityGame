using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed = 10f;
    private Camera mainCam; 

    // Speed boost power up later, hence set to public
    public float moveSpeed = 5.0f;

    private Rigidbody2D rb;
    private Animator animator;
    private Vector2 moveInput;

    // Start is called before the first frame update
    void Start()
    {
        // This fills the rigidbody reference on the first frame of the game so we can edit it in the update method later.
        rb = GetComponent<Rigidbody2D>();
        animator= GetComponent<Animator>();
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        AimAndShoot();
    }

    private void PlayerMovement()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        moveInput.Normalize();

        // Rotate the player in the direction of the movement.
        // If statment is checking to see if the player is moving. 
        if (moveInput != Vector2.zero)
        {
            // If we are moving, we enter this scope.
            animator.SetBool("isWalking", true);
            float angle = Mathf.Atan2(moveInput.y, moveInput.x) * Mathf.Rad2Deg; // fancy math calculates the degree we are turning to look at
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
        }
        else
        {
            //Not moving
            animator.SetBool("isWalking", false);
        }
    }

    void AimAndShoot()
    {
        // Getting the mouse Position
        Vector3 mousePos = mainCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));

        // Firing the bullet, On left click
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 shootingDirection = (mousePos) - transform.position;
            FireBullet(shootingDirection.normalized);
        }
    }

    void FireBullet(Vector2 direction)
    {

        GameObject bulletInstance = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = bulletInstance.GetComponent<Rigidbody2D>();
        // Calculate the angle in degrees for the direction vector
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90; // Subtract 90 if the bullet's default orientation is up

        // Apply the rotation to the bullet
        bulletInstance.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        rb.velocity = direction * bulletSpeed;
    }

    private void FixedUpdate()
    {
        //movement
        rb.velocity = moveInput * moveSpeed;
    }
}
