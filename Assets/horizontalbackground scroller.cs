using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private float _scrollSpeed = 2f;
    private float _imageWidth;
    void Start()
    {
        var spriteRenderer = GetComponent<SpriteRenderer>();
        _imageWidth = spriteRenderer.size.x;
        spriteRenderer.drawMode = SpriteDrawMode.Tiled;
        spriteRenderer.size *= new Vector2(3, 1);
    }
    private void Update()
    {
        transform.position += Vector3.left * _scrollSpeed * Time.deltaTime;
        if(Mathf.Abs(transform.position.x) >= _imageWidth)
        {
            transform.position = Vector3.zero;
        }
    }
}
