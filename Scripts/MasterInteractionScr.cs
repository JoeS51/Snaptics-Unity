using UnityEngine;

public class MasterInteractionScr : MonoBehaviour
{
    public Color allColor = new Color(0f, 0f, 0f, 1f);
    public Interactions interactions;
    public Vector2 target;
    public float moveTime;
    public Interactions.interactionTypes intType;
    // Start is called before the first frame update
    void Start()
    {
        interactions.SetUp(target, moveTime, intType);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1f - allColor.r, 1f - allColor.g, 1f - allColor.b, allColor.a);
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(target.x, target.y));
    }
    private void OnValidate()
    {
        interactions.gameObject.GetComponent<SpriteRenderer>().color = allColor;
        interactions.door.GetComponent<SpriteRenderer>().color = allColor;
    }
}
