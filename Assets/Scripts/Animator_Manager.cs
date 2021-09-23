using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Animator_Manager : MonoBehaviour
{
    public SpriteRenderer spriteRenderer { get; private set; }
    public Sprite[] sprites = new Sprite[0];
    public float time = 0.25f;
    public int frame { get; private set; }
    public bool loop = true;

    private void Awake()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(Advance), this.time, this.time);
    }

    private void Advance()
    {
        if (!this.spriteRenderer.enabled)
        {
            return;
        }

        this.frame++;

        if (this.frame >= this.sprites.Length && this.loop)
        {
            this.frame = 0;
        }

        if (this.frame >= 0 && this.frame < this.sprites.Length)
        {
            this.spriteRenderer.sprite = this.sprites[this.frame];
        }
    }

    public void Restart()
    {
        this.frame = -1;

        Advance();
    }

}