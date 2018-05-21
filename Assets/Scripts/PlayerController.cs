using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text m_pickUpsCountText;
    public Text m_winText;

    public float m_speed = 2f;

    private Rigidbody2D m_rgb2d;

    private int m_pickUpsCount;

    private void Start()
    {
        m_rgb2d = GetComponent<Rigidbody2D>();
        m_pickUpsCount = 0;
        UpdatePickUpsCountText();
        SetWinTextVisible(false);
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 delta = new Vector2(moveHorizontal, moveVertical);
        m_rgb2d.AddForce(delta * m_speed);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickUp"))
        {
            collision.gameObject.SetActive(false);

            m_pickUpsCount++;
            UpdatePickUpsCountText();

            if (m_pickUpsCount >= 12)
            {
                SetWinTextVisible(true);
            }
        }
    }

    private void UpdatePickUpsCountText()
    {
        m_pickUpsCountText.text = "Count: " + m_pickUpsCount;
    }

    private void SetWinTextVisible(bool value)
    {
        m_winText.gameObject.SetActive(value);
    }
}
