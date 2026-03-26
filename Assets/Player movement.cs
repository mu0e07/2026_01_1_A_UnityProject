using UnityEngine;

public class Playermovement : MonoBehaviour                      //이동 속도 변수 설정
{
    public float moveSpeed = 5.0f;                              //플레이어 강체 선언
    public float jumpForce = 5.0f;
    
    public Rigidbody rb;

    public bool isGrounded = true;

    public int coinCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //움직임 입력
        float moveHerizontal = Input.GetAxis("Horizontal");                 //수평 이동 (키값을 받아온다 , -1, ~1)
        float moveVertical = Input.GetAxis("Vertical");                     //수직 이동 (키값을 받아온다 , -1, ~1)

        //강체에 속도의 값을 변경해서 캐릭터를 이동 시킨다.
        rb.linearVelocity = new Vector3(moveHerizontal * moveSpeed, rb.linearVelocity.y, moveVertical * moveSpeed);
        
       //점프 입력
       if (Input.GetButtonDown("Jump") && isGrounded)  //&& 두 값을 만족할 떄 -> (스페이스 버튼을 눌렀을때와 땅 위에 있을때)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;     
        }
    
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coin"))
        {
            coinCount++;
            Destroy(other.gameObject);
        }
    }
}
