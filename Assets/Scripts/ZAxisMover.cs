using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 5.0f;
    public float timer = 5.0f;

    // Update is called once per frame
    void Update()
    {
        //z축 방향으로 이동 (앞으로 이동한다)
        transform.Translate(0,0,speed * Time.deltaTime);

        timer = Time.deltaTime;

        if (timer < 0)
        {
            Destroy(gameObject);
        }
    }
}
